using ExampleCleanArchitecture.Domain.Common;
using ExampleCleanArchitecture.Domain.Entities;

namespace ExampleCleanArchitecture.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
