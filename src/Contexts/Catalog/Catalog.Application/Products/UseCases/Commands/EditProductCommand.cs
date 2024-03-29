﻿using BuildingBlocks.Core.Utils;
using Catalog.Application.Products.Dtos;
using MediatR;

namespace Catalog.Application.Products.UseCases.Commands
{
    public class EditProductCommand : IRequest<Result>
    {
        public EditProductDto EditProductDto { get; private set; }

        public EditProductCommand(EditProductDto editProductDto)
        {
            EditProductDto = editProductDto;
        }
    }
}
