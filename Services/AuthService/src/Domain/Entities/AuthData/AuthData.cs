using System;
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

        public AuthData(Origen origen, Guid usuarioProfileId, string password, IEncrypt auth) : this()
        {
            UsuarioProfileId = usuarioProfileId;
            HashSalt hashSalt = auth.EncryptPassword(password);
            Password = hashSalt.Hash;
            Salt = Convert.ToBase64String(hashSalt.Salt);
            Origen = origen.Nombre;
            recuperar();
        }

        public bool verificarPassword(string enteredPassword, IEncrypt auth)
        {
            return auth.VerifyPassword(enteredPassword, this.Salt, this.Password);
        }

        public void recuperar()
        {
            CodigoRecupero = Guid.NewGuid().ToString().Split('-')[0].ToUpper();
            Vigencia = DateTime.Now.AddMinutes(15);
        }

        public bool verificarRecupero(string codigo)
        {
            return this.CodigoRecupero == codigo.Trim().ToUpper();
        }

        public void limpiarRecupero()
        {
            CodigoRecupero = "";
            Vigencia = null;
        }
    }
}
