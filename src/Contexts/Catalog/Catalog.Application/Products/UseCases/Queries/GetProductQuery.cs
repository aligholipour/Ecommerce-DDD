using Catalog.Application.Products.Dtos;
using MediatR;

namespace Catalog.Application.Products.UseCases.Queries
{
    public class GetProductQuery : IRequest<GetProductDto>
    {
        public int ProductId { get; set; }
    }
}
