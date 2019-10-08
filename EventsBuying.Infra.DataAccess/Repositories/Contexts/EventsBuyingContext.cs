using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EventBuyingMicroService.Domain.EventBuyingAggregate;
using EventsBuying.Infra.DataAccess;
using EventsBuying.Infra.DataAccess.Properties;

namespace EventsBuying.Infra.DataAccess.Repositories.Contexts
{
    public class EventsBuyingContext : DbContext
    {
        public DbSet<EventsBuyingEntity> EventsBuyings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Resources.DbConnectionString);
        }

        public EventsBuyingContext()
        {

        }
    }
}
