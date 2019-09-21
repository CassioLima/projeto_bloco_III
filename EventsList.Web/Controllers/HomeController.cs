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
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://eventslistmicroservices.api/");

            HttpResponseMessage response = client.GetAsync("/api/events/GetAll").Result;

            if (response.IsSuccessStatusCode)
            {
                string serializedPost = response.Content.ReadAsStringAsync().Result;
                var model = JsonConvert.DeserializeObject<IEnumerable<Eventos>>(serializedPost);

                return View(model);
            }

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
}
