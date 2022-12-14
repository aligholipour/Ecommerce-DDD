using Catalog.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Data
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> option) : base(option)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
