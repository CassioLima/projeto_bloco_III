using EventBuyingMicroService.Domain.EventBuyingAggregate;
using EventBuyingMicroService.Domain.Interfaces.Repositories;
using EventsBuying.Infra.DataAccess.Repositories.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventsBuying.Infra.DataAccess.Repositories
{
    public class EventsBuyingCommandEFCoreRepository : IEventBuyingRepository
    {
        private EventsBuyingContext _eventsBuyingContext;

        public EventsBuyingCommandEFCoreRepository(EventsBuyingContext eventsBuyingContext)
        {
            _eventsBuyingContext = eventsBuyingContext;
        }

        public void Create(EventsBuyingEntity eventsBuying)
        {
            _eventsBuyingContext.Add(eventsBuying);
        }

        public void SaveChanges()
        {
            _eventsBuyingContext.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _eventsBuyingContext.SaveChangesAsync();
        }
    }
}
