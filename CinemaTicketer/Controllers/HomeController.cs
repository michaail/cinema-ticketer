using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CinemaTicketer.Models;
using CinemaTicketer.Data;

namespace CinemaTicketer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public HomeController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Movies()
        {
            return View("../Movies/Index");
        }

        public IActionResult Screenings()
        {
            return View("../Screenings/Index");
        }

        public IActionResult Reservations()
        {
            return View("../Reservations/Index");
        }

        public IActionResult Users()
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
