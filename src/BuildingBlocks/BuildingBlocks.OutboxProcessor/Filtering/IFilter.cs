using BuildingBlocks.Core.Events;

namespace BuildingBlocks.OutboxProcessor.Filtering
{
    public interface IFilter
    {
        void ShouldBePublish(IEvent @event);
    }
}
