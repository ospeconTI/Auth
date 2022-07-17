using System;
using OSPeConTI.Auth.Services.Domain.Exceptions;
using OSPeConTI.Auth.Services.Domain.SeedWork;

namespace OSPeConTI.Auth.Services.Domain.Entities {
    public class UsuarioProfile : Entity, IAggregateRoot {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreUsuario { get; set; }

        public string Imagen { get; set; }

        public UsuarioProfile() {
        }

        public UsuarioProfile(string apellido, string nombre, string nombreUsuario, string imagen) : this() {
            Apellido = apellido;
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
            Imagen = imagen;
        }

        public void Update(Guid id) {
        }
    }
}
