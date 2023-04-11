using BuildingBlocks.Core.Utils;
using Catalog.Application.Products.Dtos;
using MediatR;

namespace Catalog.Application.Products.UseCases.Commands
{
    public class AddProductCommand : IRequest<Result>
    {
        public AddProductDto AddProduct { get; private set; }

        public AddProductCommand(AddProductDto addProduct)
        {
            AddProduct = addProduct;
        }
    }
}
