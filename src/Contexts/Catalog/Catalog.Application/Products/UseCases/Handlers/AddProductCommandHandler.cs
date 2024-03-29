﻿using AutoMapper;
using BuildingBlocks.Core.Utils;
using Catalog.Application.Products.UseCases.Commands;
using Catalog.Domain.Entities.Products;
using Catalog.Infrastructure.Repositories;
using MediatR;

namespace Catalog.Application.Products.UseCases.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Result>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public AddProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request.AddProduct);

            await _productRepository.AddProductAsync(product);

            return Result.Success();
        }
    }
}
