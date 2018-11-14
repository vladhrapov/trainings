using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnet_state_fe.Models;

namespace aspnet_state_fe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Segments(int id)
        {
            ViewBag.passedId = id;

            return View("Index");
        }

        public IActionResult SegmentsWithQueryString(int id, string data)
        {
            ViewBag.passedId = id;
            ViewBag.data = data;

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
