namespace Basket.Application.ShoppingCarditems.Dtos
{
    public class ShoppingCartItemCreateDto
    {
        public string UserID { get; set; }
        public string ProductID { get; set; }
        public decimal Amount { get; set; }
    }
}
