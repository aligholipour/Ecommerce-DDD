using BuildingBlocks.Domain;

namespace Order.Domain.Entities.Orders
{
    public class Order : AggregateRoot<int>
    {
        private DateTime _orderDate;

        public Order()
        {
            _orderDate = DateTime.UtcNow;
        }
    }
}
