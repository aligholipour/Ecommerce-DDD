using BuildingBlocks.Core.Events;
using System.Reflection;

namespace BuildingBlocks.OutboxProcessor.Types
{
    public class EventTypeResolver : IEventTypeResolver
    {
        private Dictionary<string, Type> _types = new Dictionary<string, Type>();

        public void AddTypesFromAssembly(Assembly assembly)
        {
            var events = assembly.GetTypes().Where(type => typeof(IEvent).IsAssignableFrom(type)).ToList();

            events.ForEach(a =>
            {
                _types.Add(a.Name, a);
            });
        }

        public Type GetType(string typeName)
        {
            if (_types.ContainsKey(typeName))
                return _types[typeName];

            return null;
        }
    }
}
