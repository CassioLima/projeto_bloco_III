using EventBuyingMicroService.Domain.Services;
using EventsBuying.Application;
using EventsBuying.Application.AppModel.DTO;
using EventsBuying.Application.AutoMapper;
using EventsBuying.Infra.DataAccess.CQRS;
using EventsBuying.Infra.DataAccess.Repositories;
using EventsBuying.Infra.DataAccess.Repositories.Contexts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventsBuyingTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EventsBuyingDTO events = new EventsBuyingDTO
            {
                Id = 1,
                IdEvento = 2,
                Nome = "Ale",
                NomeEvento = "Show Ivete"
            };

            var dtoConfig = AutoMapperConfig.RegisterAllMappings();
            var mapper = dtoConfig.CreateMapper();

            var apiAppService = new ApiAppService(new RabbitMQueue(),
                mapper, new EventsBuyingManagerService(new EventsBuyingCommandEFCoreRepository(
                    new EventsBuyingContext())));

            apiAppService.AddEventsBuying(events);
        }
    }
}
