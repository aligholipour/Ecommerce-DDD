using Basket.Domain.Contracts;
using Basket.Domain.Entities.ShoppingCardItems;
using Basket.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Infrastructure.Repositories
{
    public class ShoppingCardRepository : IShoppingCardItemRepository
    {
        private readonly ShoppingDbContext dbContext;

        public ShoppingCardRepository(ShoppingDbContext dbContext)
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
