using AutoMapper;
using Basket.Application.ShoppingCarditems.Dtos;
using Basket.Application.ShoppingCarditems.UseCases.Commands;
using Basket.Domain.Contracts;
using Basket.Domain.Entities.ShoppingCardItems;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Application.ShoppingCarditems.UseCases.Handlers
{
    public class CreateShoppingCardItemHandler : IRequestHandler<CreateShoppingCardItemCommand, int>
    {
        private readonly IShoppingCardItemRepository shoppingCardItemRepository;
        private readonly IMapper mapper;

        public CreateShoppingCardItemHandler(IShoppingCardItemRepository shoppingCardItemRepository, IMapper mapper)
        {
            this.shoppingCardItemRepository = shoppingCardItemRepository;
            this.mapper = mapper;
        }

        public async Task<int> Handle(CreateShoppingCardItemCommand request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<ShoppingCardItem>(request.shoppingCardItem);

            await shoppingCardItemRepository.AddAsync(entity);

            //TODO Add new shopping card item event

            return entity.Id;
        }
    }
}
