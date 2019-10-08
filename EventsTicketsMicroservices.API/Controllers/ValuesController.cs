using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using EventsTicketsMicroservices.API.Model.DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EventsTicketsMicroservices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            string urlString = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}";
            string apiToken = "985421199:AAGdlt4bTa4se-AUlS_68QSA-5GntWMIu4c";//"952149526:AAG4I43m2bmKAOebeHfYpwPKKP8aZHzkrpI";
            string chatId = "-237548196";
            string text = "Hello world! Ale";
            urlString = String.Format(urlString, apiToken, chatId, text);
            WebRequest request = WebRequest.Create(urlString);
            Stream rs = request.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(rs);
            string line = "";
            StringBuilder sb = new StringBuilder();
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                    sb.Append(line);
            }
            string response = sb.ToString();


            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(Conteudo conteudo)
        {
            string urlString = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}";
            string apiToken = "985421199:AAGdlt4bTa4se-AUlS_68QSA-5GntWMIu4c";//"952149526:AAG4I43m2bmKAOebeHfYpwPKKP8aZHzkrpI";
            string chatId = "-237548196";
            string text = conteudo.Nome + ": " + conteudo.MensagemCompra; 
            urlString = String.Format(urlString, apiToken, chatId, text);
            WebRequest request = WebRequest.Create(urlString);
            Stream rs = request.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(rs);
            string line = "";
            StringBuilder sb = new StringBuilder();
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                    sb.Append(line);
            }
            //string response = sb.ToString();

            //var retorno = JsonConvert.DeserializeObject<Retorno>(response);
            //if (retorno.ok.Equals(true))
            //    return "Seu ingresso foi comprado com sucesso.";
            //else
            //    return "Erro ao efetuar sua compra";
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
