using EventsListMicroservices.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventsListMicroservices.Domain.IngressoAggregate
{
    public interface IEventosQueryRepository
    {
        Task<IEnumerable<Eventos>> GetAll();
        Eventos Get(Guid id);
    }
}
