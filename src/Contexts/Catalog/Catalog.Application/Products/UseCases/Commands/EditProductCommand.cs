using Catalog.Application.Products.Dtos;

namespace Catalog.Application.Products.UseCases.Commands
{
    public class EditProductCommand
    {
        public EditProductDto EditProductDto { get; private set; }

        public EditProductCommand(EditProductDto editProductDto)
        {
            EditProductDto = editProductDto;
        }
    }
}
