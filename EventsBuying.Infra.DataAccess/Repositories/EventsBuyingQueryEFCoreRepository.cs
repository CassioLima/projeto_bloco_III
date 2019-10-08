using EventBuyingMicroService.Domain.EventBuyingAggregate;
using EventsBuying.Infra.DataAccess.Repositories.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsBuying.Infra.DataAccess.Repositories
{
    public class EventsBuyingQueryEFCoreRepository : IEventBuyingQueryRepository
    {
        private EventsBuyingContext _eventsBuyingContext;

        public EventsBuyingQueryEFCoreRepository(EventsBuyingContext eventsBuyingContext)
        {
            _eventsBuyingContext = eventsBuyingContext;
        }

        public EventsBuyingEntity Get(Guid id)
        {
            return _eventsBuyingContext.EventsBuyings.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<EventsBuyingEntity> GetAll()
        {
            return _eventsBuyingContext.EventsBuyings;
        }
    }
}
