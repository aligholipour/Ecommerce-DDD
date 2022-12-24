using Basket.Application.ShoppingCarditems.Events.IntegrationEvent;
using Basket.Application.ShoppingCarditems.UseCases.Commands;
using Basket.Domain.Contracts;
using MediatR;

namespace Basket.Application.ShoppingCarditems.UseCases.Handlers
{
    public class CheckoutShoppingCartHandler : IRequestHandler<CheckoutShoppingCartCommand, bool>
    {
        private readonly IShoppingCardItemRepository _shoppingCardItemRepository;
        private readonly IPublisher _publisher;

        public CheckoutShoppingCartHandler(IShoppingCardItemRepository shoppingCardItemRepository, IPublisher publisher)
        {
            _shoppingCardItemRepository = shoppingCardItemRepository;
            _publisher = publisher;
        }

        public async Task<bool> Handle(CheckoutShoppingCartCommand request, CancellationToken cancellationToken)
        {
            var userId = "1"; // TODO: Get userId from identity service

            var shoppingCart = await _shoppingCardItemRepository.GetShoppingCartByUserId(userId);

            if (shoppingCart is null)
                return false;

            var shoppingCartEvent = new CheckoutShoppingCartIntegrationEvent
            {
                ShoppingCardItem = shoppingCart
            };

            await _publisher.Publish(shoppingCartEvent);

            return true;
        }
    }
}
