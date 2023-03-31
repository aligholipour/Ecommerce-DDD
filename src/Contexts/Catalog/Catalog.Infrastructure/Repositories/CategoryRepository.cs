using Catalog.Domain.Entities.Categories;
using Catalog.Infrastructure.Data;

namespace Catalog.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CatalogDbContext _context;

        public CategoryRepository(CatalogDbContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Category category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            return await _context.Categorys.FindAsync(categoryId);
        } 
    }
}
