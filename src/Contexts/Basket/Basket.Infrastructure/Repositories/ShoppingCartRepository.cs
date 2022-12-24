using Basket.Domain.Contracts;
using Basket.Domain.Entities.ShoppingCardItems;
using Basket.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Basket.Infrastructure.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ShoppingDbContext dbContext;

        public ShoppingCartRepository(ShoppingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task AddAsync(ShoppingCardItem cardItem)
        {
            await dbContext.AddAsync(cardItem);
        }

        public async Task<ShoppingCardItem> GetShoppingCartByUserId(string userId)
        {
            return await dbContext.shoppingCardItems.Where(x => x.UserID == userId).SingleOrDefaultAsync();
        }
    }
}
