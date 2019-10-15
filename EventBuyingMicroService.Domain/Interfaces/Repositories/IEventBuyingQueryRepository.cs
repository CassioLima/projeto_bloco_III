using EventBuyingMicroService.Domain.EventBuyingAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.Interfaces.Repositories
{
    public interface IEventBuyingQueryRepository
    {
        EventsBuyingEntity Get(int id);
        IEnumerable<EventsBuyingEntity> GetAll();
    }
}
