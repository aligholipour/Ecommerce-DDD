using AutoMapper;
using Catalog.Application.Products.Dtos;
using Catalog.Application.Products.UseCases.Queries;
using Catalog.Infrastructure.Repositories;
using MediatR;

namespace Catalog.Application.Products.UseCases.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<GetProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductAsync(request.ProductId);

            var result = _mapper.Map<GetProductDto>(product);

            return result;
        }
    }
}
