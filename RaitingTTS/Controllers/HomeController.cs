using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaitingTTS.Models;

namespace RaitingTTS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var context = new IRBIDSContext();
            return View(context);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetAttempt(int Id) {
            ViewData["UserId"] = Id;
            var context = new IRBIDSContext();
            return View(context);
        }

    }
}
