using EventsListMicroservices.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventsListMicroservices.Domain.IngressoAggregate
{
    public interface IEventosCommandRepository
    {
        void Create(Eventos events);
        void Update(Eventos events);
        void Delete(Guid id);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
