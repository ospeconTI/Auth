using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using OSPeConTI.Auth.BuildingBlocks.EventBus.Abstractions;
using OSPeConTI.Auth.BuildingBlocks.EventBus.Events;
using OSPeConTI.Auth.Services.Application.IntegrationEvents;
using OSPeConTI.Auth.Services.Domain.Entities;

namespace OSPeConTI.Auth.Services.Application.Commands
{
    // Regular CommandHandler
    public class
    AddMaterialesCommandHandler
    : IRequestHandler<AddMaterialesCommand, Guid>
    {
        private readonly IMaterialesRepository _materialesRepository;

        private readonly IEventBus _eventBus;

        public AddMaterialesCommandHandler(
            IMaterialesRepository materialesRepository,
            IEventBus eventBus
        )
        {
            _materialesRepository = materialesRepository;
            _eventBus = eventBus;
        }

        public async Task<Guid>
        Handle(
            AddMaterialesCommand command,
            CancellationToken cancellationToken
        )
        {
            Material material =
                new Material(command.Codigo,
                    command.Descripcion,
                    command.Costo,
                    command.ClasificacionId,
                    command.TipoMaterialId);

            _materialesRepository.Add (material);

            await _materialesRepository
                .UnitOfWork
                .SaveEntitiesAsync(cancellationToken);
            MaterialCreadoIntegrationEvent evento =
                new MaterialCreadoIntegrationEvent(material.Id);

            _eventBus.Publish (evento);
            return material.Id;
        }
    }
}
