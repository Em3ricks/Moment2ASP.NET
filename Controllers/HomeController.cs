using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Moment2.Models;
using Newtonsoft.Json;

namespace Moment2.Controllers
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
            ViewData["Message"] = "Denna text flyttas med ViewData";
            ViewBag.text = "Detta är text via ViewBag.";
            
            string s = "Now you see me...";
            HttpContext.Session.SetString("test", s);

            return View();
        }

        public IActionResult Index2()
        {
            // Sessionsvariabel
            string s2 = HttpContext.Session.GetString("test");
            ViewBag.text = s2; 

            return View();
        }

        public IActionResult Index3()
        {

            Item myitem = new Item();
            myitem.Name = "John Emericks";
            // Sessionsvariabel med JSON
            string s1 = JsonConvert.SerializeObject(myitem);
            HttpContext.Session.SetString("test 1", s1);
            ViewBag.jsonsträng = s1;

            return View(myitem);
        }

        public IActionResult Index5()
        {
            // Utskrift av lista med ViewData
            List<Person> personer = new List<Person>
               {
            new Person { Id =1, Namn = "Sofie Oxlin"},
            new Person { Id = 2, Namn = "Fadi Hanna" },
            new Person { Id = 3, Namn = "Vanja Wiklund" },
            new Person { Id = 4, Namn = "Adnreas Selguson" }
               };

            ViewData["personer_i_lista"] = personer;

            // Utskrift av lista med ViewBag
            List<Person> personer2 = new List<Person>
               {
            new Person { Id =1, Namn = "Malin Larsson"},
            new Person { Id = 2, Namn = "Lova Unger" },
            new Person { Id = 3, Namn = "Erik Björkholm" },
            new Person { Id = 4, Namn = "Rebecka Högström" }
               };

            ViewBag.personer = personer2;

            // Utskrift av lista med modell
            List<Person> personer3 = new List<Person>
               {
            new Person { Id =1, Namn = "Joakim Stork"},
            new Person { Id = 2, Namn = "William Wara" },
            new Person { Id = 3, Namn = "Malin Hemmingson" },
            new Person { Id = 4, Namn = "Therese Eriksson" }
               };

            ViewModeln vm = new ViewModeln
            {
                PersonDetaljLista = personer3
            };

            return View(vm);
        }

        public IActionResult Index6()
        {
            List<Person> personer = new List<Person>
            {
            new Person { Id =1, Namn = "Moa Hjemdal"},
            new Person { Id = 2, Namn = "Mimmi Nordquist" },
            new Person { Id = 3, Namn = "Sandra Wara" },
            new Person { Id = 4, Namn = "Susanne Wolter" }
            };

            return View(personer);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
