namespace BuildingBlocks.Core.Messaging
{
    public interface IDuplicateHandler
    {
        Task<bool> HasMessageBeenProcessedBefore<T>(T evetnId);
        Task MarkMessageAsProcessed<T>(T eventId);
        Task HandleMessage<T>(T message);
    }
}
