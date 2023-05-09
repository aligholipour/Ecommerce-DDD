using Basket.Application.ShoppingCarditems.Dtos;
using BuildingBlocks.Core.Utils;
using MediatR;

namespace Basket.Application.ShoppingCarditems.UseCases.Commands
{
    public class CreateShoppingCartItemCommand : IRequest<Result>
    {
        public ShoppingCartItemCreateDto shoppingCardItem { get; private set; }

        public CreateShoppingCartItemCommand(ShoppingCartItemCreateDto shoppingCardItem)
        {
            this.shoppingCardItem = shoppingCardItem;
        }
    }
}
