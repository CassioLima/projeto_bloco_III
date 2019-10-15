using EventBuyingMicroService.Domain.CQRS;
using EventBuyingMicroService.Domain.Interfaces.CQRS;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsBuying.Infra.DataAccess.CQRS
{
    public class RabbitMQueue : IQueue
    {
        public string Dequeue(string queueName)
        {
            throw new NotImplementedException();
        }

        public void Enqueue(QueueMessage message)
        {
            var factory = new ConnectionFactory() { HostName = "rabbitmq1", Port = 5672, UserName = "guest", Password = "guest" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: message.QueueName,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null
                                     );
                var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));
                channel.BasicPublish(exchange: "",
                                     routingKey: message.QueueName,
                                     basicProperties: null,
                                     body: body);
            }
        }
    }
}
