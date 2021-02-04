using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Movies()
        {
            return View(TempModel.Movies);
        }

        public IActionResult My_Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies_Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies_Form(MovieFormModel movieFormModel)
        {
            if (movieFormModel.Title != "Independence Day")
            {
                TempModel.AddMovie(movieFormModel);
            }

            return View();
        }

    }
}
