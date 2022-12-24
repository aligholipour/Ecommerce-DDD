using Basket.Domain.Entities.ShoppingCardItems;

namespace Basket.Domain.Contracts
{
    public interface IShoppingCardItemRepository
    {
        Task AddAsync(ShoppingCardItem cardItem);
        Task<ShoppingCardItem> GetShoppingCartByUserId(string userId);
    }
}
