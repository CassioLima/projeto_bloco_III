using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Repositories.Elastic.Log;
using DataAccess.Services.Elastic;
using DataAccess.Services.Elastic.Config.Log;
using DomainModel.Log;
using DomainService;
using Microsoft.AspNetCore.Mvc;

namespace Logger.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private ActivityLogService<UserActivityLog> _activityLogService;

        public ValuesController()
        {

            //ActivityLogService
            var logElasticConnection = new ElasticConnection<UserActivityLog>(new UserActivityLogElasticConfig());
            _activityLogService = new ActivityLogService<UserActivityLog>
                (new ActivityLogElasticRepository<UserActivityLog>(logElasticConnection));

        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _activityLogService.RegisterActivity(new UserActivityLog("oi oi oi oi"));


            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
