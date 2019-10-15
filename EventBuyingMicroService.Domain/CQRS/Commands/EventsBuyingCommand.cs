using EventBuyingMicroService.Domain.EventBuyingAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.CQRS.Commands
{
    public abstract class EventsBuyingCommand : Command
    {
        public EventsBuyingEntity EventsBuying { get; set; }
        public EventsBuyingCommand(EventsBuyingEntity eventsBuying)
        {
            EventsBuying = eventsBuying;
        }
    }
}
