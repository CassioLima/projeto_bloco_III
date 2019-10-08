using Microsoft.Extensions.Configuration;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using System.IO;
using APIMensagens;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;
using APIMensagens.Models;
using EventsConsumerConsoleApp.Model;

namespace EventsConsumerConsoleApp
{
    class Program
    {
        private static IConfiguration _configuration;
        static string model;
        static void Main(string[] args)
        {

            /*Funcionou
            string message = String.Empty;
            var factory = new ConnectionFactory() { HostName = "localhost", Port = 15672};
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "TestesASPNETCore",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    message = Encoding.UTF8.GetString(body);
                };
                channel.BasicConsume(queue: "TestesASPNETCore",
                     autoAck: true,
                     consumer: consumer);


                Console.WriteLine(Environment.NewLine +
                    "[Nova mensagem recebida] " + message);
            }
            */
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");
            _configuration = builder.Build();

            // Para este exemplo foi criado um container Docker baseado
            // em uma imagem do RabbitMQ. Segue o comando para geração
            // desta estrutura:
            // docker run -d --hostname rabbit-local --name testes-rabbitmq -p 6672:5672 -p 15672:15672 -e RABBITMQ_DEFAULT_USER=testes -e RABBITMQ_DEFAULT_PASS=Testes2018! rabbitmq:3-management-alpine
            var rabbitMQConfigurations = new RabbitMQConfigurations();
            new ConfigureFromConfigurationOptions<RabbitMQConfigurations>(
                _configuration.GetSection("RabbitMQConfigurations"))
                    .Configure(rabbitMQConfigurations);

            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                Port = 15672,//rabbitMQConfigurations.Port,
                UserName = rabbitMQConfigurations.UserName,
                Password = rabbitMQConfigurations.Password
            };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "TestesASPNETCore",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += Consumer_Received;
                channel.BasicConsume(queue: "TestesASPNETCore",
                     autoAck: true,
                     consumer: consumer);

                Console.WriteLine("Aguardando mensagens para processamento");
                Console.WriteLine("Pressione uma tecla para encerrar...");

                Console.ReadKey();
            }

        }
        private static void Consumer_Received(
            object sender, BasicDeliverEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Body);
            Console.WriteLine(Environment.NewLine +
                "[Nova mensagem recebida] " + message);

            ConteudoDTO convert = JsonConvert.DeserializeObject<ConteudoDTO>(message);

            if(!string.IsNullOrEmpty(convert.Mensagem) && !string.IsNullOrEmpty(convert.Nome))
                PostTelegram1(new Mensagem { MensagemCompra = "Sua compra foi realizada com sucesso", Nome = convert.Nome });
        }

        private static string PostTelegram()
        {
            HttpClient clientGet = new HttpClient();
            clientGet.BaseAddress = new Uri("http://localhost:8082/api/values");

            HttpResponseMessage response = clientGet.GetAsync("/api/values").Result;
            if (response.IsSuccessStatusCode)
            {
                string serializedPost = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<string>(serializedPost);

                Console.WriteLine(model);
            }

            return model;

        }

        private static void PostTelegram1(Mensagem mensagem)
        {
            using (var client = new WebClient())
            {
                //EventTB objtb = new EventTB(); //Setting parameter to post  
                //objtb.EventID = 0;
                //objtb.EventName = "Late-Night Music";
                //objtb.EventStartsDate = DateTime.Now;
                //objtb.EventEndsDate = DateTime.Now;
                //objtb.EventLocation = "Mumbai";
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("http://localhost:8082/api/values", JsonConvert.SerializeObject(mensagem));
                Console.WriteLine(result);
            }

        }


    }
}

