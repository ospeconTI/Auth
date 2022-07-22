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
    public class ActivateUserCommandHandler : IRequestHandler<ActivateUserCommand, bool>
    {
        private readonly IUsuarioProfileRepository _usuarioProfileRepository;
        private readonly IEventBus _eventBus;
        private readonly IAuthIntegrationEventService _authIntegrationEventService;

        public ActivateUserCommandHandler(IUsuarioProfileRepository usuarioProfileRepository, IEventBus eventBus, IAuthIntegrationEventService authIntegrationEventService)
        {
            _usuarioProfileRepository = usuarioProfileRepository;
            _eventBus = eventBus;
            _authIntegrationEventService = authIntegrationEventService;
        }

        public async Task<bool> Handle(ActivateUserCommand command, CancellationToken cancellationToken)
        {

            UsuarioProfile user = await _usuarioProfileRepository.getByNombreUsuarioAsync(command.NombreUsuario);

            if (user == null) throw new InvalidCastException();

            user.ActivateUser(command.CodigoRecupero);

            await _usuarioProfileRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return true;
        }
    }
}