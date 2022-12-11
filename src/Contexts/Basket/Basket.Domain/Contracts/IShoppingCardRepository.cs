using Basket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Domain.Contracts
{
    public interface IShoppingCardRepository
    {
        Task AddAsync(ShoppingCardItem cardItem);
    }
}
