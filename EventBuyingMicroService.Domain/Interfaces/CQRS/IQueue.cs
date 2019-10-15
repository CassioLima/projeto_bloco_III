using EventBuyingMicroService.Domain.CQRS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBuyingMicroService.Domain.Interfaces.CQRS
{
    public interface IQueue
    {
        void Enqueue(QueueMessage message);
        string Dequeue(string queueName);
    }
}
