using AutoMapper;
using Catalog.Application.Products.UseCases.Commands;
using Catalog.Infrastructure.Repositories;
using MediatR;

namespace Catalog.Application.Products.UseCases.Handlers
{
    public class EditProductCommandHandler : IRequestHandler<EditProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public EditProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            var getProduct = await _productRepository.GetProductAsync(request.EditProductDto.ProductId);
            if (getProduct is null)
                return false;

            var updateProduct = _mapper.Map(request, getProduct);

            await _productRepository.UpdateProductAsync(updateProduct);

            return true;
        }
    }
}
