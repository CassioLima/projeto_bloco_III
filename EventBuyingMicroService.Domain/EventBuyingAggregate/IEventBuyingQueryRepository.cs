using EventBuyingMicroService.Domain.CatalogEventAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.EventBuyingAggregate
{
    public interface IEventBuyingQueryRepository
    {
        IEnumerable<EventsBuyingEntity> GetAll();
        EventsBuyingEntity Get(Guid id);
    }
}
