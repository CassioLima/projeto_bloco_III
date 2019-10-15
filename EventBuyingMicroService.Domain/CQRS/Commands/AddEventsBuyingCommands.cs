using EventBuyingMicroService.Domain.EventBuyingAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.CQRS.Commands
{
    public class AddEventsBuyingCommands : EventsBuyingCommand
    {
        public const string ConstQueueName = "add-event-buying-command-queue";
        public override string QueueName { get => ConstQueueName; }

        public AddEventsBuyingCommands(EventsBuyingEntity eventsBuyingEntity)
            :base (eventsBuyingEntity)
        {

        }
    }
}
