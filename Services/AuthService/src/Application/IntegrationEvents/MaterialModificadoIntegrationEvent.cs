using System;
using System.Text.Json.Serialization;
using OSPeConTI.Auth.BuildingBlocks.EventBus.Events;

namespace OSPeConTI.Auth.Services.Application.IntegrationEvents
{
    public record MaterialModificadoIntegrationEvent : IntegrationEvent
    {
        [JsonInclude]
        public Guid MaterialId { get; set; }
        [JsonConstructor]
        public MaterialModificadoIntegrationEvent(Guid materialId)
        {
            MaterialId = materialId;

        }
    }
}