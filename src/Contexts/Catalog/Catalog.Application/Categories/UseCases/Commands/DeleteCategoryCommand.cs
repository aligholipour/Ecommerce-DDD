using MediatR;

namespace Catalog.Application.Categories.UseCases.Commands
{
    public class DeleteCategoryCommand : IRequest
    {
        public int CategoryId { get; set; }
    }
}
