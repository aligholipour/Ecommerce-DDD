using BuildingBlocks.Core.Utils;
using Catalog.Application.Categories.UseCases.Commands;
using Catalog.Domain.Entities.Categories;
using MediatR;

namespace Catalog.Application.Categories.UseCases.Handlers
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, Result>
    {
        private readonly ICategoryRepository _categoryRepository;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Result> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetCategoryById(request.CategoryId);

            await _categoryRepository.DeleteCategoryById(category);

            return Result.Success();
        }
    }
}
