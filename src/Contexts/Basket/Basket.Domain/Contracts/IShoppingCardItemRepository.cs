using Basket.Domain.Entities.ShoppingCardItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Domain.Contracts
{
    public interface IShoppingCardItemRepository
    {
        Task AddAsync(ShoppingCardItem cardItem);
    }
}
