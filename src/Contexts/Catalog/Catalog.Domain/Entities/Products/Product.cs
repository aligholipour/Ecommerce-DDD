using BuildingBlocks.Domain;
using Catalog.Domain.Entities.Exceptions;

namespace Catalog.Domain.Entities.Products
{
    public class Product : AggregateRoot<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public void ChangePrice(decimal price)
        {
            if (price <= 0)
                throw new InvalidPriceValueException("The price is less than zero");

            Price = price;
        }
    }
}
