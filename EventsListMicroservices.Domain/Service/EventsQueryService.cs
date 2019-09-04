using EventsListMicroservices.Domain.IngressoAggregate;
using EventsListMicroservices.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsListMicroservices.Domain.Service
{
    public class EventsQueryService
    {
        readonly IEventosQueryRepository _eventosQueryRepository;

        public EventsQueryService(IEventosQueryRepository eventosQueryRepository)
        {
            _eventosQueryRepository = eventosQueryRepository;
        }

        public IEnumerable<Eventos> GetAllEventos()
        {
            return _eventosQueryRepository.GetAll();
        }
    }
}
