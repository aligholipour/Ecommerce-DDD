using Catalog.Api.Models.Products;
using Catalog.Application.Products.Dtos;
using Catalog.Application.Products.UseCases.Commands;
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

        [HttpPost("InsertProduct")]
        public async Task<IActionResult> InsertProduct(AddProductModel productModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productCommand = new AddProductCommand(new AddProductDto
            {
                Name = productModel.Name,
                Description = productModel.Description,
                Price = productModel.Price,
                Quantity = productModel.Quantity
            });

            var result = await _mediator.Send(productCommand);

            if (result.IsSuccess)
                return Ok();

            return BadRequest();
        }
    }
}