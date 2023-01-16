using BuildingBlocks.Core.Events;

namespace BuildingBlocks.OutboxProcessor.EventTransformation
{
    public abstract class EventTransformer<T> : IEventTransformer where T : IEvent
    {
        protected abstract IEvent Transform(T @event);
        public IEvent Transform(IEvent @event)
        {
            return Transform(@event);
        }
    }
}
