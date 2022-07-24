namespace OSPeConTI.Auth.Services.Application.Queries
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using System.Linq;
    using OSPeConTI.Auth.Services.Domain;
    using System.IdentityModel.Tokens.Jwt;
    using System.Text;
    using Microsoft.IdentityModel.Tokens;
    using System.Security.Claims;
    using Microsoft.Extensions.Configuration;
    using OSPeConTI.Auth.Services.Application.Helper;
    using OSPeConTI.Auth.Services.Application.Exceptions;

    public class AuthQueries
        : IAuthQueries
    {
        private readonly Pbkdf2 _encrypt;
        private string _connectionString = string.Empty;
        string _secret;
        dynamic _result;

        public AuthQueries(IConfiguration config, Pbkdf2 encrypt)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");

            _secret = config.GetSection("AppSettings").Get<AppSettings>().Secret;

            _encrypt = encrypt;
        }

        public async Task<LoginDTO> LoginAsync(string nombreUsuario, string enteredPassword)

        {

            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"
                SELECT a.Id,a.Password,a.Salt,u.Email,u.Imagen,u.Apellido,u.Nombre 
                FROM UsuarioProfile u 
                LEFT JOIN AuthData a on u.id = a.UsuarioProfileId
                WHERE u.NombreUsuario =@NombreUsuario and a.Activo=1";

                IEnumerable<dynamic> results = await connection.QueryAsync<dynamic>(sql, new { nombreUsuario });

                _result = results.FirstOrDefault();

                if (_result == null) throw new NotFoundException();


                if (!_encrypt.VerifyPassword(enteredPassword, _result.Salt, _result.Password)) throw new ForbiddenException();

            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secret);
            var claimId = new Claim(ClaimTypes.NameIdentifier, _result.Id.ToString(), ClaimValueTypes.String);
            var claimUsuario = new Claim(ClaimTypes.Name, nombreUsuario, ClaimValueTypes.String);
            var claimApellido = new Claim(ClaimTypes.Surname, _result.Apellido.ToString(), ClaimValueTypes.String);
            var claimNombre = new Claim(ClaimTypes.GivenName, _result.Nombre.ToString(), ClaimValueTypes.String);
            var claimEmail = new Claim(ClaimTypes.Email, _result.Email != null ? _result.Email.ToString() : "", ClaimValueTypes.String);
            var claimImagen = new Claim(ClaimTypes.Uri, _result.Imagen != null ? _result.Imagen.ToString() : "", ClaimValueTypes.String);


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { claimId, claimUsuario, claimEmail, claimImagen, claimApellido, claimNombre }),
                Expires = DateTime.UtcNow.AddMinutes(180),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new LoginDTO(tokenHandler.WriteToken(token));

        }
    }
}