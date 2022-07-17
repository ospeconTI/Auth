using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace OSPeConTI.Auth.Services.Domain.Entities
{
    public class
    UsuarioProfileAgregadoHandler : INotificationHandler<UsuarioProfileRequested>
    {
        private readonly IUsuarioProfileRepository _usuarioProfileRepository;

        public UsuarioProfileAgregadoHandler(IUsuarioProfileRepository usuarioProfileRepository)
        {
            _usuarioProfileRepository = usuarioProfileRepository;
        }

        public async Task Handle(UsuarioProfileRequested notificacion, CancellationToken cancellationToken)
        {

            UsuarioProfile usuarioExistente = await _usuarioProfileRepository.getByNombreUsuarioAsync(notificacion.UsuarioProfile.NombreUsuario);

            if (usuarioExistente != null) throw new System.InvalidOperationException("el nombre de usuario ya esta ocupado");

            return;
        }
    }
}
