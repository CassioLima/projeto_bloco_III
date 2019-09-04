using EventsListMicroservices.Domain.IngressoAggregate;
using EventsListMicroservices.Domain.Model;
using EventsListMicroservices.Infra.DataAccess.Repositories.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsListMicroservices.Infra.DataAccess
{
    public class EventsQueryEFCoreRepository : IEventosQueryRepository
    {
        private EventsListContext _eventsListContext;

        public EventsQueryEFCoreRepository(EventsListContext eventsListContext)
        {
            _eventsListContext = eventsListContext;
        }

        Eventos IEventosQueryRepository.Get(Guid id)
        {
            return _eventsListContext.Eventos.Find(id);
        }

        IEnumerable<Eventos> IEventosQueryRepository.GetAll()
        {
            return _eventsListContext.Eventos;
        }
    }
}
