using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using aspnet_state.Models;

namespace aspnet_state.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.GetString("car-data");
            return View();
        }

        public IActionResult Cookies()
        {
            ViewBag.Message = "Cookies";

            HttpContext.Response.Cookies.Append("user-name", "vasya");

            return View();
        }

        public IActionResult Session()
        {
            ViewData["Message"] = "Session";

            HttpContext.Session.SetString("car-data", "Ferrari");
            HttpContext.Session.SetInt32("car-year-data", 2018);

            return View();
        }

        public IActionResult Application()
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
