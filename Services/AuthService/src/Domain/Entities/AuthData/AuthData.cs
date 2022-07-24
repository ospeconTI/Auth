using System;
using OSPeConTI.Auth.Services.Domain.Exceptions;
using OSPeConTI.Auth.Services.Domain.SeedWork;

namespace OSPeConTI.Auth.Services.Domain.Entities
{
    public class AuthData : Entity, IAggregateRoot
    {
        public Guid? UsuarioProfileId { get; set; }

        public string Origen { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public string CodigoRecupero { get; set; }

        DateTime? Vigencia { get; set; }

        public AuthData()
        {
        }

        public AuthData(Origen origen, Guid usuarioProfileId, string password, IEncrypt encript) : this()
        {
            UsuarioProfileId = usuarioProfileId;
            HashSalt hashSalt = encript.EncryptPassword(password);
            Password = hashSalt.Hash;
            Salt = Convert.ToBase64String(hashSalt.Salt);
            Origen = origen.Nombre;
            RecoverPassword();
        }

        public bool VerifyPassword(string enteredPassword, IEncrypt encript)
        {
            return encript.VerifyPassword(enteredPassword, this.Salt, this.Password);
        }

        public void RecoverPassword()
        {
            CodigoRecupero = Guid.NewGuid().ToString().Split('-')[0].ToUpper();
            Vigencia = DateTime.Now.AddMinutes(15);
        }

        public void VerifyRecoveryCode(string codigo)
        {

            if (this.CodigoRecupero == codigo.Trim().ToUpper() && this.Vigencia > DateTime.Now) throw new RecoveryCodeDomainException("codigo recuperacion erroneo o vencido ");


        }

        public void CleanRecoveryCode()
        {
            CodigoRecupero = "";
            Vigencia = null;
        }
    }
}
