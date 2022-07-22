using MediatR;
using OSPeConTI.Auth.Services.Domain.Entities;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using System;
using OSPeConTI.Auth.BuildingBlocks.EventBus.Abstractions;
using OSPeConTI.Auth.Services.Application.IntegrationEvents;
using OSPeConTI.Auth.Services.Domain;

namespace OSPeConTI.Auth.Services.Application.Commands
{
    // Regular CommandHandler
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Guid>
    {
        private readonly IUsuarioProfileRepository _usuarioProfileRepository;
        private readonly IEventBus _eventBus;
        private readonly IAuthIntegrationEventService _authIntegrationEventService;
        private readonly Pbkdf2 _encrypt;
        public RegisterCommandHandler(IUsuarioProfileRepository usuarioProfileRepository, IEventBus eventBus, IAuthIntegrationEventService authIntegrationEventService)
        {
            _usuarioProfileRepository = usuarioProfileRepository;
            _eventBus = eventBus;
            _authIntegrationEventService = authIntegrationEventService;
            _encrypt = new Pbkdf2();
        }

        public async Task<Guid> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {

            UsuarioProfile usuarioProfile = new UsuarioProfile();
            usuarioProfile.RequestLogon(command.Apellido, command.Nombre, command.NombreUsuario, command.Email, command.Password, Origen.SQL, _encrypt);
            _usuarioProfileRepository.add(usuarioProfile);

            await _usuarioProfileRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            /*             ClasificacionCreadoIntegrationEvent evento = new ClasificacionCreadoIntegrationEvent(clasificacion.Id, clasificacion.Descripcion);

                       Guid transactionId = Guid.NewGuid();
                       await _clasificacionIntegrationEventService.AddAndSaveEventAsync(evento, transactionId);
                       await _clasificacionIntegrationEventService.PublishEventsThroughEventBusAsync(transactionId);
             */
            return usuarioProfile.Id;
        }
    }
}