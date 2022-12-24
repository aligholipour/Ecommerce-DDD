using Basket.Application.ShoppingCarditems.Dtos;
using MediatR;

namespace Basket.Application.ShoppingCarditems.UseCases.Commands
{
    public class CheckoutShoppingCartCommand : IRequest<bool>
    {
        public CheckoutShoppingCartDto CheckoutShoppingCart { get; private set; }
        public CheckoutShoppingCartCommand(CheckoutShoppingCartDto checkoutShoppingCart)
        {
            CheckoutShoppingCart = checkoutShoppingCart;
        }
    }
}
