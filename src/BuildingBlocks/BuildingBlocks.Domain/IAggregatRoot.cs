namespace BuildingBlocks.Domain
{
    public interface IAggregatRoot
    {
        IReadOnlyList<IDomainEvent> UncommitedEvents { get; }
    }
}
