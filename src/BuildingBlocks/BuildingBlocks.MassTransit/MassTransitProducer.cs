using BuildingBlocks.Core.Events;
using MassTransit;

namespace BuildingBlocks.MassTransit
{
    public class MassTransitProducer : IPublisher
    {
        private readonly IPublishEndpoint? _publishEndpoint;

        public MassTransitProducer(IPublishEndpoint? publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public async Task Publish<TMessage>(TMessage message, CancellationToken cancellationToken = default) where TMessage : IEvent
        {
            await _publishEndpoint.Publish(message, cancellationToken);
        }
    }
}
