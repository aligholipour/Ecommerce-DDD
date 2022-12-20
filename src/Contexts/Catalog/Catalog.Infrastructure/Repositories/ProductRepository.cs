using Catalog.Domain.Entities.Products;
using Catalog.Infrastructure.Data;

namespace Catalog.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CatalogDbContext _context;
        public ProductRepository(CatalogDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductAsync(int productId)
        {
            return await _context.Products.FindAsync(productId);
        }

        public async Task AddProductAsync(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }
    }
}
