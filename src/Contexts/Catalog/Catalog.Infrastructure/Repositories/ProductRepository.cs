using Catalog.Domain.Entities;
using Catalog.Infrastructure.Data;

namespace Catalog.Infrastructure.Repositories
{
    public class ProductRepository
    {
        private readonly CatalogDbContext _context;
        public ProductRepository(CatalogDbContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }
    }
}
