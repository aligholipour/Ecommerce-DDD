using Basket.Domain.Contracts;
using Basket.Domain.Entities;
using Basket.Infrastructure.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Infrastructure.Repositories
{
    public class ShoppingCardRepository : IShoppingCardRepository
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
    }
}
