using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CinemaTicketer.Models;
using CinemaTicketer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace CinemaTicketer.Controllers
{
    public class HomeController : Controller
    {
        private readonly CinemaTicketerContext _dbContext;
        public HomeController(CinemaTicketerContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.Movies.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
