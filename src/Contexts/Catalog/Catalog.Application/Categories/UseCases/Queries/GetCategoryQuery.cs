using Catalog.Application.Categories.Dtos;
using MediatR;

namespace Catalog.Application.Categories.UseCases.Queries
{
    public class GetCategoryQuery : IRequest<GetCategoryDto>
    {
        public int CategoryId { get; set; }
    }
}
