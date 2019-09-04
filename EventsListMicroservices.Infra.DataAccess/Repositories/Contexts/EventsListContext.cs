using EventsListMicroservices.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EventsListMicroservices.Infra.DataAccess.Properties;

namespace EventsListMicroservices.Infra.DataAccess.Repositories.Contexts
{
    public class EventsListContext: DbContext
    {
        public DbSet<Eventos> Eventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(Resources.DbConnectionString);
        }

        public EventsListContext()
        {
            //Database.EnsureCreated();
        }
    }
}
