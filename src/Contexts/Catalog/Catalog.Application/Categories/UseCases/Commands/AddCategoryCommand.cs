using BuildingBlocks.Core.Utils;
using Catalog.Application.Categories.Dtos;
using MediatR;

namespace Catalog.Application.Categories.UseCases.Commands
{
    public class AddCategoryCommand : IRequest<Result>
    {
        public AddCategoryDto addCategoryDto { get; private set; }
        public AddCategoryCommand(AddCategoryDto addCategoryDto)
        {
            this.addCategoryDto = addCategoryDto;
        }
    }
}
