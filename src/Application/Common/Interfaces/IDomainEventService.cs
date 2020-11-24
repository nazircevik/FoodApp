using FoodApp.Domain.Common;
using System.Threading.Tasks;

namespace FoodApp.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
