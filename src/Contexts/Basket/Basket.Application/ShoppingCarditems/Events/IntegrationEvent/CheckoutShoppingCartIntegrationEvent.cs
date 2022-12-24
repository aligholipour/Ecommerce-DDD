using Basket.Domain.Entities.ShoppingCardItems;
using BuildingBlocks.Core.Events;

namespace Basket.Application.ShoppingCarditems.Events.IntegrationEvent
{
    public class CheckoutShoppingCartIntegrationEvent : IEvent
    {
        public Guid EventId => Guid.NewGuid();
        public DateTime PublishDateTime => DateTime.Now;
        public ShoppingCardItem ShoppingCardItem { get; set; }
    }
}
