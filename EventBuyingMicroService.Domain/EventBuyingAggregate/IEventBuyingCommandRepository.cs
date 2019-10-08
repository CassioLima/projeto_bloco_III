using EventBuyingMicroService.Domain.CatalogEventAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBuyingMicroService.Domain.EventBuyingAggregate
{
    public interface IEventBuyingCommandRepository
    {
        void Create(EventsBuyingEntity eventsBuying);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
