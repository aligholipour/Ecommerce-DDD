namespace Catalog.Domain.Entities.Exceptions
{
    public class InvalidPriceValueException : Exception
    {
        public InvalidPriceValueException() { }

        public InvalidPriceValueException(string message) : base(message) { }
    }
}
