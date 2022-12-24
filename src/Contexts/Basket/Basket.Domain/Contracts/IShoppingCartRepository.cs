using Basket.Domain.Entities.ShoppingCardItems;

namespace Basket.Domain.Contracts
{
    public interface IShoppingCartRepository
    {
        Task AddAsync(ShoppingCardItem cardItem);
        Task<ShoppingCardItem> GetShoppingCartByUserId(string userId);
    }
}
