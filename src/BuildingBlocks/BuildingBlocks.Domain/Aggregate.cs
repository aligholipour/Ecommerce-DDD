namespace BuildingBlocks.Domain
{
    public class Aggregate<TKey> : Entity<TKey>, IAggregatRoot
    {
        private List<IDomainEvent> _uncommitedEvents;
        public IReadOnlyList<IDomainEvent> UncommitedEvents => _uncommitedEvents.AsReadOnly();
        public Aggregate()
        {
            _uncommitedEvents = new List<IDomainEvent>();
        }
    }
}
