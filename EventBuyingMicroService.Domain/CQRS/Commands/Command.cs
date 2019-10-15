using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.CQRS.Commands
{
    public abstract class Command : QueueMessage
    {
    }
}
