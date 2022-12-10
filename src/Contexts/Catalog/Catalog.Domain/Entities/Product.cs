using BuildingBlocks.Domain;

namespace Catalog.Domain.Entities
{
    public class Product : AggregateRoot<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
