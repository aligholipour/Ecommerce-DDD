namespace Catalog.Domain.Entities.Exceptions
{
    public class InvalidProductQuantityException : Exception
    {
        public InvalidProductQuantityException() { }

        public InvalidProductQuantityException(string message) : base(message) { }
    }
}
