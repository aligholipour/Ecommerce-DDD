using Basket.Application.ShoppingCarditems.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.ShoppingCarditems.UseCases.Commands
{
    public class CreateShoppingCartItemCommand : IRequest<int>
    {
        public ShoppingCartItemCreateDto shoppingCardItem { get; private set; }

        public CreateShoppingCartItemCommand(ShoppingCartItemCreateDto shoppingCardItem)
        {
            this.shoppingCardItem = shoppingCardItem;
        }
    }
}
