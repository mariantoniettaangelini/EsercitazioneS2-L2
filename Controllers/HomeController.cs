using Es_Console;
using Es_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Es_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var cv = new CV
            {
                InfoPersonali = new InfoPersonali
                {
                    Nome = "Mario",
                    Cognome = "Rossi",
                    Tel = "321654987",
                    Email = "mario@email.it"
                },
                StudiEffettuati = new List<Studi>
                {
                    new Studi
                    {
                        Qualifica = "Laurea in Informatica",
                        Istituto = "Università",
                        Tipo = "Universitario",
                        Dal = new DateTime(2020, 10, 01), Al = new DateTime(2023, 07, 10)
                    }
                },


            };
            
            return View(cv);
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
