using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using OSPeConTI.Auth.BuildingBlocks.EventBus.Events;

namespace OSPeConTI.Auth.Services.Application.IntegrationEvents
{
    public interface IMaterialIntegrationEventService
    {
        Task PublishEventsThroughEventBusAsync(Guid transactionId);

        Task AddAndSaveEventAsync(IntegrationEvent evt, Guid transacationId);
    }
}
