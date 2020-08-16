using Calla.ActionFilters;
using Calla.Models;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System.Diagnostics;

namespace Calla.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IWebHostEnvironment env;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            this.logger = logger;
            this.env = env;
        }

        [Route("/")]
        [ServiceFilter(typeof(LogHitsAttribute))]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Basic")]
        [ServiceFilter(typeof(LogHitsAttribute))]
        public IActionResult Basic()
        {
            return View();
        }

        [Route("/Privacy")]
        [ServiceFilter(typeof(LogHitsAttribute))]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/ToS")]
        [ServiceFilter(typeof(LogHitsAttribute))]
        public IActionResult ToS()
        {
            return View();
        }

        [Route("/About")]
        [ServiceFilter(typeof(LogHitsAttribute))]
        public IActionResult About()
        {
            return View();
        }

        [Route("/Tests")]
        public IActionResult Tests()
        {
            if (!env.IsDevelopment())
            {
                return NotFound();
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
