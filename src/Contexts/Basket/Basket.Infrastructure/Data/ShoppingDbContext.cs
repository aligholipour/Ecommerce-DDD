using Basket.Domain.Entities.ShoppingCardItems;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Infrastructure.Data
{
    public class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> option) : base(option)
        {
        }

        public DbSet<ShoppingCardItem> shoppingCardItems { get; set; }
    }
}
