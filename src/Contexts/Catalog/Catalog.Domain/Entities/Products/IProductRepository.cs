using Catalog.Domain.Entities.Products;

namespace Catalog.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductAsync(int productId);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
    }
}