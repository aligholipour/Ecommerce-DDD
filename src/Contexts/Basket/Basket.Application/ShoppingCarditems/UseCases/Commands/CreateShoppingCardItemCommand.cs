﻿using Basket.Application.ShoppingCarditems.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.ShoppingCarditems.UseCases.Commands
{
    public class CreateShoppingCardItemCommand : IRequest<int>
    {
        public ShoppingCardItemCreateDto shoppingCardItem { get; private set; }

        public CreateShoppingCardItemCommand(ShoppingCardItemCreateDto shoppingCardItem)
        {
            this.shoppingCardItem = shoppingCardItem;
        }
    }
}