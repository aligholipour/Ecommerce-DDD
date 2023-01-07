using System.Reflection;

namespace BuildingBlocks.OutboxProcessor.Types
{
    public interface IEventTypeResolver
    {
        void AddTypesFromAssembly(Assembly assembly);
        Type GetType(string typeName);
    }
}
