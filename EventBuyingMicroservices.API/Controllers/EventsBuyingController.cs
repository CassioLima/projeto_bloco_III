using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventBuyingMicroService.Domain.Services;
using EventsBuying.Application;
using EventsBuying.Application.AppModel.DTO;
using EventsBuying.Application.AutoMapper;
using EventsBuying.Infra.DataAccess.CQRS;
using EventsBuying.Infra.DataAccess.Repositories;
using EventsBuying.Infra.DataAccess.Repositories.Contexts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBuyingMicroservices.API.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class EventsBuyingController : ControllerBase
    {
        private EventsBuyingContext db = new EventsBuyingContext();
        private ApiAppService apiAppService;

        public EventsBuyingController()
        {
            //EventsBuyingDTO eventsBuyingDTO = new EventsBuyingDTO
            //{
            //    Id = 1,
            //    IdEvento = 2,
            //    Nome = "ALE",
            //    NomeEvento = "Show Ivete Sangalo"
            //};

            //var dtoConfig = AutoMapperConfig.RegisterAllMappings();
            //var mapper = dtoConfig.CreateMapper();

            //apiAppService = new ApiAppService(new RabbitMQueue(),
            //    mapper, new EventsBuyingManagerService(new EventsBuyingCommandEFCoreRepository(
            //                                            new EventsBuyingContext())));

            //apiAppService.AddEventsBuying(eventsBuyingDTO);
        }

        public object Post([FromBody]EventsBuyingDTO eventsBuyingDTO)
        {

            var dtoConfig = AutoMapperConfig.RegisterAllMappings();
            var mapper = dtoConfig.CreateMapper();

            apiAppService = new ApiAppService(new RabbitMQueue(),
                mapper, new EventsBuyingManagerService(new EventsBuyingCommandEFCoreRepository(
                                                        new EventsBuyingContext())));

            apiAppService.AddEventsBuying(eventsBuyingDTO);

            return eventsBuyingDTO;

        }

        //[ResponseType(typeof(ProductDTO))]
        //public async Task<IHttpActionResult> PostProductDTO(ProductDTO productDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Products.Add(productDTO);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ProductDTOExists(productDTO.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = productDTO.Id }, productDTO);
        //}
    }
}