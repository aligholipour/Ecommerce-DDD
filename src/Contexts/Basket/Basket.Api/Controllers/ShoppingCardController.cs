using Basket.Api.Models.ShoppingCardItems;
using Basket.Application.ShoppingCarditems.Dtos;
using Basket.Application.ShoppingCarditems.UseCases.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Basket.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingCardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShoppingCardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddShoppingCarItem")]
        public async Task<ActionResult> AddShoppingCarItem(ShoppingCartItemCreateModel shoppingCartItemModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var shoppingCartItemCommand = new CreateShoppingCartItemCommand(new ShoppingCartItemCreateDto
            {
                Amount = shoppingCartItemModel.Amount,
                ProductID = shoppingCartItemModel.ProductID,
                UserID = shoppingCartItemModel.UserID,
            });

            var result = await _mediator.Send(shoppingCartItemCommand);

            if (result.IsSuccess)
                return Ok();

            return BadRequest();
        }
    }
}