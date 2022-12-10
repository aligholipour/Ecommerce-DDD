namespace BuildingBlocks.Domain
{
    public class AggregateRoot<TKey> : Entity<TKey>, IAggregatRoot
    {
        private List<IDomainEvent> _uncommitedEvents;
        public IReadOnlyList<IDomainEvent> UncommitedEvents => _uncommitedEvents.AsReadOnly();
        public AggregateRoot()
        {
            _uncommitedEvents = new List<IDomainEvent>();
        }
    }
}
