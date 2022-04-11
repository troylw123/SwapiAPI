using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SwapiMVC.Controllers
{
    [Route("[controller]")]
    public class PeopleController : Controller
    {
        private readonly HttpClient _httpClient;

        public PeopleController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("swapi");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}