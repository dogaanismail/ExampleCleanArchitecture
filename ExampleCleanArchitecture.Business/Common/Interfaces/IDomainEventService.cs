using ExampleCleanArchitecture.Domain.Common;
using System.Threading.Tasks;

namespace ExampleCleanArchitecture.Business.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
