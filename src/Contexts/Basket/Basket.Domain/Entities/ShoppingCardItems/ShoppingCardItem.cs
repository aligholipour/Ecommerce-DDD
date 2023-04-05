using BuildingBlocks.Domain;

namespace Basket.Domain.Entities.ShoppingCardItems
{
    public class ShoppingCardItem : AggregateRoot<int>
    {
        public string UserID { get; set; }
        public string ProductID { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }

        public void AddItemToShoppingCard(string userId, string productId, decimal amount)
        {
            UserID = userId;
            ProductID = productId;
            Amount = amount;
        }
    }
}
