using AutoMapper;
using BuildingBlocks.Core.Utils;
using Catalog.Application.Products.UseCases.Commands;
using Catalog.Infrastructure.Repositories;
using MediatR;

namespace Catalog.Application.Products.UseCases.Handlers
{
    public class EditProductCommandHandler : IRequestHandler<EditProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public EditProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            var getProduct = await _productRepository.GetProductAsync(request.EditProductDto.ProductId);
            if (getProduct is null)
                return Result.Failure("Product not found");

            var updateProduct = _mapper.Map(request, getProduct);

            await _productRepository.UpdateProductAsync(updateProduct);

            return Result.Success();
        }
    }
}
