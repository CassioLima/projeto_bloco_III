using EventBuyingMicroService.Domain.EventBuyingAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.Interfaces.Repositories
{
    public interface IEventBuyingRepository
    {
        void Create(EventsBuyingEntity eventsBuyingEntity);
    }
}
