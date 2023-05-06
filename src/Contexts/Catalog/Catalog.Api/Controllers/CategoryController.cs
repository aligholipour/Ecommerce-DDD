using Catalog.Application.Categories.UseCases.Queries;
using Catalog.Application.Products.UseCases.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCategory")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var categoryQuery = new GetCategoryQuery
            {
                CategoryId = id
            };

            var category = await _mediator.Send(categoryQuery);

            return Ok(category);
        }
    }
}
