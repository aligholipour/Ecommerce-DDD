using BuildingBlocks.Domain;

namespace Order.Domain.Entities.Orders
{
    public class OrderItem : Entity<int>
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
    }
}
