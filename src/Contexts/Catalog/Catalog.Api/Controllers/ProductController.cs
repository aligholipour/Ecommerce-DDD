using Catalog.Application.Products.UseCases.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetProduct")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var productQuery = new GetProductQuery
            {
                ProductId = id
            };

            var product = await _mediator.Send(productQuery);

            return Ok(product);
        }
    }
}