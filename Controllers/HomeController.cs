using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VIA3_Online_School.Models;

namespace VIA3_Online_School.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet("student")]
        public IActionResult Student()
        {
            return View("student");
        }

        [HttpGet("CSharpChat")]
        public IActionResult CSharpChat()
        {
            return View("CSharpChat");
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
