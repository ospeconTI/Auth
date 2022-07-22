using System;
using System.Text.Json.Serialization;
using OSPeConTI.Auth.BuildingBlocks.EventBus.Events;

namespace OSPeConTI.Auth.Services.Application.IntegrationEvents
{
    public record MaterialCreadoIntegrationEvent : IntegrationEvent
    {
        [JsonInclude]
        public Guid MaterialId { get; set; }

        [JsonConstructor]
        public MaterialCreadoIntegrationEvent(Guid materialId)
        {
            MaterialId = materialId;

        }
    }
}