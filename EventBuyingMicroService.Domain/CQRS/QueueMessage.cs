using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.CQRS
{
    public abstract class QueueMessage : Message
    {
        public abstract string QueueName { get;}
    }
}
