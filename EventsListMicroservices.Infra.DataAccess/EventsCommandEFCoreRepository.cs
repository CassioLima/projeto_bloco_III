using EventsListMicroservices.Domain.IngressoAggregate;
using EventsListMicroservices.Domain.Model;
using EventsListMicroservices.Infra.DataAccess.Repositories.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventsListMicroservices.Infra.DataAccess
{
    public class EventsCommandEFCoreRepository : IEventosCommandRepository
    {
        private EventsListContext _eventsListContext;

        public EventsCommandEFCoreRepository(EventsListContext eventsListContext)
        {
            _eventsListContext = eventsListContext;
        }

        public void Create(Eventos eventos)
        {
            _eventsListContext.Add(eventos);
        }

        public void Delete(Guid id)
        {
            var eventos = _eventsListContext
                .Eventos.Find(id);
            _eventsListContext.Remove(eventos);
        }

        public void SaveChanges()
        {
            _eventsListContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _eventsListContext.SaveChangesAsync();
        }

        public void Update(Eventos eventos)
        {
            _eventsListContext.Entry<Eventos>(eventos)
                .State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
