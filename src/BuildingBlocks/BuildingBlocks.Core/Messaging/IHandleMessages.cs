using BuildingBlocks.Core.Events;

namespace BuildingBlocks.Core.Messaging
{
    public interface IHandleMessages<T> where T : IEvent
    {
        Task Handle(T message);
    }
}
