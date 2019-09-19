using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventsListMicroservices.Domain.Model;
using EventsListMicroservices.Domain.Service;
using EventsListMicroservices.Infra.DataAccess;
using EventsListMicroservices.Infra.DataAccess.Repositories.Contexts;

namespace EventsListMicroservices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class eventsController : ControllerBase
    {


        private EventsManagerService _eventsManagerService;
        private EventsQueryService _eventsQueryService;

        public eventsController()
        {
            _eventsManagerService = new EventsManagerService(
                new EventsCommandEFCoreRepository(
                    new EventsListContext()));


            _eventsQueryService = new EventsQueryService(
                new EventsQueryEFCoreRepository(
                    new EventsListContext()));
        }


        // GET api/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/events/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/events
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/events/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/events/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //[HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<Eventos>> GetAll()
        {
            return await _eventsQueryService.GetAllEventos();

        }


    }
}
