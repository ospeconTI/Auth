using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OSPeConTI.Auth.BuildingBlocks.EventBus.Abstractions;
using OSPeConTI.Auth.Services.Domain.Entities;


namespace OSPeConTI.Auth.Services.Application.IntegrationEvents
{
    public class MaterialModificadoIntegrationEventHandler : IIntegrationEventHandler<MaterialModificadoIntegrationEvent>
    {
        private readonly ILogger<MaterialModificadoIntegrationEventHandler> _logger;
        private readonly IMaterialesRepository _repository;

        public MaterialModificadoIntegrationEventHandler(
            ILogger<MaterialModificadoIntegrationEventHandler> logger,
            IMaterialesRepository repository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task Handle(MaterialModificadoIntegrationEvent @event)
        {
            _logger.LogInformation("Se Modifico el material Id = " + @event.MaterialId.ToString());
        }
    }


}