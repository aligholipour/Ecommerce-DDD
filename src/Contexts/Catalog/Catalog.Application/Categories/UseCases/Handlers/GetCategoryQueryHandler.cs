using AutoMapper;
using Catalog.Application.Categories.Dtos;
using Catalog.Application.Categories.UseCases.Queries;
using Catalog.Domain.Entities.Categories;
using MediatR;

namespace Catalog.Application.Categories.UseCases.Handlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, GetCategoryDto>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<GetCategoryDto> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetCategoryById(request.CategoryId);

            var result  = _mapper.Map<GetCategoryDto>(category);

            return result;
        }
    }
}
