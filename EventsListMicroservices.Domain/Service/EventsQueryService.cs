using EventsListMicroservices.Domain.IngressoAggregate;
using EventsListMicroservices.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventsListMicroservices.Domain.Service
{
    public class EventsQueryService
    {
        readonly IEventosQueryRepository _eventosQueryRepository;

        public EventsQueryService(IEventosQueryRepository eventosQueryRepository)
        {
            _eventosQueryRepository = eventosQueryRepository;
        }

        public async Task<IEnumerable<Eventos>> GetAllEventos()
        {
            return await _eventosQueryRepository.GetAll();
        }
    }
}
