using BuildingBlocks.Core.Events;

namespace BuildingBlocks.OutboxProcessor.EventTransformation
{
    public interface IEventTransformer
    {
        IEvent Transform(IEvent @event);
    }
}
