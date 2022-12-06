namespace BuildingBlocks.Domain
{
    public class Entity<TKey>
    {
        public TKey Id { get; protected set; }
    }
}
