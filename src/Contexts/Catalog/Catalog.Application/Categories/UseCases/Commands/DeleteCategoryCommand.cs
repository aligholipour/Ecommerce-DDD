using BuildingBlocks.Core.Utils;
using MediatR;

namespace Catalog.Application.Categories.UseCases.Commands
{
    public class DeleteCategoryCommand : IRequest<Result>
    {
        public int CategoryId { get; set; }
    }
}
