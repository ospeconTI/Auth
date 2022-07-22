using System;
using OSPeConTI.Auth.Services.Domain.Exceptions;
using OSPeConTI.Auth.Services.Domain.SeedWork;

namespace OSPeConTI.Auth.Services.Domain.Entities
{
    public class UsuarioProfile : Entity, IAggregateRoot
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreUsuario { get; set; }

        public string Imagen { get; set; }

        public string Email { get; set; }

        public AuthData AuthData { get; set; }
        public UsuarioProfile()
        {

        }
        public void RequestLogon(string apellido, string nombre, string nombreUsuario, string email, string password, Origen origen, IEncrypt encrypt)
        {
            Id = Guid.NewGuid();
            Apellido = apellido;
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
            Email = email;
            Activo = false;
            AuthData = new AuthData(origen, Id, password, encrypt);
            AuthData.Activo = false;
        }

        public void ActivateUser(string codigoRecupero)
        {
            if (codigoRecupero != AuthData.CodigoRecupero) throw new Exception("El codigo de recupero no es válido");
            Activo = true;
            AuthData.Activo = true;
            AuthData.CodigoRecupero = "";
        }
    }
}
