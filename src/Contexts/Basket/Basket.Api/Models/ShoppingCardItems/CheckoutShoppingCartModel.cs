namespace Basket.Api.Models.ShoppingCardItems
{
    public class CheckoutShoppingCartModel
    {
        public string UserID { get; set; }
        public string ProductID { get; set; }
        public decimal Amount { get; set; }
    }
}
