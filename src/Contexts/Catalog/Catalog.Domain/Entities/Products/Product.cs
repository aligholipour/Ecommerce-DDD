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
        public int CategoryId { get; set; }

        public Product(string name, string description, decimal price, int quantity)
        {
            if (price <= 0)
                throw new InvalidPriceValueException("The price is less than zero");

            if (quantity < 0)
                throw new InvalidProductQuantityException("Product quantity must be zero or greater than");

            Name = name;
            Description = description; 
            Price = price;
            Quantity = quantity;
        }

        public void ChangePrice(decimal price)
        {
            if (price <= 0)
                throw new InvalidPriceValueException("The price is less than zero");

            Price = price;
        }

        public void ChangeQuantity(int quantity)
        {
            if (quantity < 0)
                throw new InvalidProductQuantityException("Product quantity must be zero or greater than");

            Quantity = quantity;
        }

        public void SetCategory(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
