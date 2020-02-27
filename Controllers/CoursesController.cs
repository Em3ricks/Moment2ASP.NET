using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Moment2.Controllers
{
    public class CoursesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {



            return View();
        }

        [HttpPost]
        public IActionResult Courses(IFormCollection col)
        {
            Courses c = new Courses();
            c.Namn = col["Namn"];
            c.Kurskod = col["Kurskod"];


            return View(c);
        }






    }
}