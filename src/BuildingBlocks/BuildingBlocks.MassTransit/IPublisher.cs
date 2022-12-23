using BuildingBlocks.Core.Events;

namespace BuildingBlocks.MassTransit
{
    public interface IPublisher
    {
        Task Publish<TMessage>(TMessage message, CancellationToken cancellationToken = default) where TMessage : IEvent;
    }
}
