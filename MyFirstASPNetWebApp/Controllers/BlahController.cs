using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstASPNetWebApp.Models;
using System.Threading.Tasks;

namespace MyFirstASPNetWebApp.controllers
{
    public class blahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator(CalculatorModel calcNum)
        {
            if (ModelState.IsValid)
            {
                ViewBag.corrent = ("Your Final Grade Is: ");
            }
            return View(calcNum);
        }
    }
}
