using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventsList.Web.Models;
using System.Net.Http;
using Newtonsoft.Json;
using EventsListMicroservices.Domain.Model;

namespace EventsList.Web.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {

            //----------------------- Log Inicio --------------------------------
            HttpClient clientLog = new HttpClient();
            var log = new Log("Events/Home", "Pesquisa Eventos");
            clientLog.BaseAddress = new Uri("http://logger.api/");
            HttpResponseMessage responseLog = clientLog.PostAsJsonAsync("api/Log/PostLog", log).Result;
            responseLog.EnsureSuccessStatusCode();

            //----------------------- Log Fim --------------------------------



            //----------------------- Atualiza Tela Inicio --------------------------------
            HttpClient clientGet = new HttpClient();
            clientGet.BaseAddress = new Uri("http://localhost:8082/api/values");
            HttpResponseMessage response = clientGet.GetAsync("/api/events/GetAll").Result;

            if (response.IsSuccessStatusCode)
            {
                string serializedPost = response.Content.ReadAsStringAsync().Result;
                var model = JsonConvert.DeserializeObject<IEnumerable<Eventos>>(serializedPost);

                return View(model);
            }

            //----------------------- Atualiza Tela Fim --------------------------------

           return null;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


    class Log
    {

        public Log(string Tela, string Log)
        {
            sTela = Tela;
            sLog = Log;
        }

        public string sTela;
        public string sLog;

        //public Log GetLog()
        //{
        //    return null;


        //}
    }

}
