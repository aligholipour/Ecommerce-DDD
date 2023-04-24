using BuildingBlocks.Domain;

namespace Order.Domain.Entities.Orders
{
    public class Order : AggregateRoot<int>
    {
        private DateTime _orderDate;
        public Address Address { get; private set; }

        public Order(Address address)
        {
            _orderDate = DateTime.UtcNow;
            Address = address;
        }
    }
}
