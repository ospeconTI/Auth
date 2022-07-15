using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OSPeConTI.Auth.BuildingBlocks.EventBus.Abstractions;

namespace EventBus.Tests
{
    public class
    TestIntegrationEventHandler
    : IIntegrationEventHandler<TestIntegrationEvent>
    {
        public bool Handled { get; private set; }

        public TestIntegrationEventHandler()
        {
            Handled = false;
        }

        public async Task Handle(TestIntegrationEvent @event)
        {
            Handled = true;
        }
    }
}
