using AutoMapper;
using Basket.Application.ShoppingCarditems.UseCases.Commands;
using Basket.Domain.Contracts;
using Basket.Domain.Entities.ShoppingCardItems;
using BuildingBlocks.Core.Utils;
using MediatR;

namespace Basket.Application.ShoppingCarditems.UseCases.Handlers
{
    public class CreateShoppingCartItemHandler : IRequestHandler<CreateShoppingCartItemCommand, Result>
    {
        private readonly IShoppingCartRepository shoppingCardItemRepository;
        private readonly IMapper mapper;

        public CreateShoppingCartItemHandler(IShoppingCartRepository shoppingCardItemRepository, IMapper mapper)
        {
            this.shoppingCardItemRepository = shoppingCardItemRepository;
            this.mapper = mapper;
        }

        public async Task<Result> Handle(CreateShoppingCartItemCommand request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<ShoppingCardItem>(request.shoppingCardItem);

            await shoppingCardItemRepository.AddAsync(entity);

            //TODO Add new shopping card item event

            return Result.Success();
        }
    }
}
