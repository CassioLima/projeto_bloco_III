using EventBuyingMicroService.Domain.EventBuyingAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBuyingMicroService.Domain.CatalogEventAggregate
{
    public interface EventBuyingCommandRepository
    {
        void Create(EventsBuyingEntity catalogEvents);
        void Update(EventsBuyingEntity catalogEvents);
        void Delete(Guid id);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
