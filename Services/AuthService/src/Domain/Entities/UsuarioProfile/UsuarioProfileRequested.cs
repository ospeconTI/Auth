using MediatR;

namespace OSPeConTI.Auth.Services.Domain.Entities
{
    public class UsuarioProfileRequested : INotification
    {
        public UsuarioProfile UsuarioProfile { get; set; }

        public UsuarioProfileRequested(UsuarioProfile usuarioProfile)
        {
            UsuarioProfile = usuarioProfile;
        }
    }
}
