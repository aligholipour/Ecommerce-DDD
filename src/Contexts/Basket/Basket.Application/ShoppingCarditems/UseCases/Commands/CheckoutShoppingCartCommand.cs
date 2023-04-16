using Basket.Application.ShoppingCarditems.Dtos;
using BuildingBlocks.Core.Utils;
using MediatR;

namespace Basket.Application.ShoppingCarditems.UseCases.Commands
{
    public class CheckoutShoppingCartCommand : IRequest<Result>
    {
        public CheckoutShoppingCartDto CheckoutShoppingCart { get; private set; }
        public CheckoutShoppingCartCommand(CheckoutShoppingCartDto checkoutShoppingCart)
        {
            CheckoutShoppingCart = checkoutShoppingCart;
        }
    }
}
