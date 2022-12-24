using Basket.Application.ShoppingCarditems.UseCases.Commands;
using Basket.Domain.Contracts;
using MediatR;

namespace Basket.Application.ShoppingCarditems.UseCases.Handlers
{
    public class CheckoutShoppingCartHandler : IRequestHandler<CheckoutShoppingCartCommand, bool>
    {
        private readonly IShoppingCardItemRepository shoppingCardItemRepository;
        public CheckoutShoppingCartHandler(IShoppingCardItemRepository shoppingCardItemRepository)
        {
            this.shoppingCardItemRepository = shoppingCardItemRepository;
        }

        public async Task<bool> Handle(CheckoutShoppingCartCommand request, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}
