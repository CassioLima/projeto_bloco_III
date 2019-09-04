using EventsListMicroservices.Domain.IngressoAggregate;
using EventsListMicroservices.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsListMicroservices.Domain.Service
{
    public class EventsManagerService
    {
        readonly IEventosCommandRepository _IventosCommandRepository;

        public EventsManagerService(IEventosCommandRepository IventosCommandRepository)
        {
            _IventosCommandRepository = IventosCommandRepository;
        }

        public void AddEvento(Eventos eventoe)
        {
            _IventosCommandRepository.Create(eventoe);
            _IventosCommandRepository.SaveChanges();
        }
    }
}
