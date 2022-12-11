using Catalog.Domain.Entities.Products;

namespace Catalog.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task AddProductAsync(Product product);
    }
}