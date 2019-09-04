using EventsListMicroservices.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsListMicroservices.Domain.IngressoAggregate
{
    public interface IEventosQueryRepository
    {
        IEnumerable<Eventos> GetAll();
        Eventos Get(Guid id);
    }
}
