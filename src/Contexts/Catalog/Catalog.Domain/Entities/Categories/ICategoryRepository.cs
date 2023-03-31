using Catalog.Domain.Entities.Products;

namespace Catalog.Domain.Entities.Categories
{
    public interface ICategoryRepository
    {
        Task AddProductAsync(Category category);
        Task<Category> GetCategoryById(int categoryId);
    }
}
