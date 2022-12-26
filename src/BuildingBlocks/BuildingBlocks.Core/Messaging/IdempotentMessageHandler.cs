using BuildingBlocks.Core.Events;
using System.Transactions;

namespace BuildingBlocks.Core.Messaging
{
    public class IdempotentMessageHandler<T> : IHandleMessages<T> where T : IEvent
    {
        private readonly IDuplicateHandler _duplicateHandler;
        public IdempotentMessageHandler(IDuplicateHandler duplicateHandler)
        {
            _duplicateHandler = duplicateHandler;
        }
        public async Task Handle(T message)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled))
            {
                if (!await _duplicateHandler.HasMessageBeenProcessedBefore(message.EventId))
                {
                    await _duplicateHandler.HandleMessage(message);
                    await _duplicateHandler.MarkMessageAsProcessed(message.EventId);
                    scope.Complete();
                }
            }
        }
    }
}
