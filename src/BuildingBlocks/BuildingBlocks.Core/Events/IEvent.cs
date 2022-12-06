namespace BuildingBlocks.Core.Events
{
    public interface IEvent
    {
        Guid EventId { get; }
        DateTime PublishDateTime { get; }
    }
}
