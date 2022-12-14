using BuildingBlocks.Domain;

namespace Basket.Domain.Entities.ShoppingCardItems
{
    public class ShoppingCardItem : AggregateRoot<int>
    {
        public string UserID { get; set; }
        public string ProductID { get; set; }
        public decimal Amount { get; set; }
    }
}
