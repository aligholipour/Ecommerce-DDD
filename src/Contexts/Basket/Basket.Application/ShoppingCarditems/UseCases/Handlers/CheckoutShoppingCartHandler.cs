﻿using Basket.Application.ShoppingCarditems.Events.IntegrationEvent;
using Basket.Application.ShoppingCarditems.UseCases.Commands;
using Basket.Domain.Contracts;
using BuildingBlocks.Core.Utils;
using MediatR;

namespace Basket.Application.ShoppingCarditems.UseCases.Handlers
{
    public class CheckoutShoppingCartHandler : IRequestHandler<CheckoutShoppingCartCommand, Result>
    {
        private readonly IShoppingCartRepository _shoppingCardItemRepository;
        private readonly IPublisher _publisher;

        public CheckoutShoppingCartHandler(IShoppingCartRepository shoppingCardItemRepository, IPublisher publisher)
        {
            _shoppingCardItemRepository = shoppingCardItemRepository;
            _publisher = publisher;
        }

        public async Task<Result> Handle(CheckoutShoppingCartCommand request, CancellationToken cancellationToken)
        {
            var userId = "1"; // TODO: Get userId from identity service

            var shoppingCart = await _shoppingCardItemRepository.GetShoppingCartByUserId(userId);

            if (shoppingCart is null)
                return Result.Failure("ShoppingCart is not found");

            var shoppingCartEvent = new CheckoutShoppingCartIntegrationEvent
            {
                ShoppingCardItem = shoppingCart
            };

            await _publisher.Publish(shoppingCartEvent);

            return Result.Success();
        }
    }
}
