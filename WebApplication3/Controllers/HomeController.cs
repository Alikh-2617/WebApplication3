﻿using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Game()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Game(int input)
        {
            ViewBag.Result = GameModel.Game(input);
            ViewBag.Counter = GameModel.counter;
            ViewBag.Gusset = input;
            ViewBag.generedNumber1 = GameModel.genericNumber;
            HttpContext.Session.SetInt32("Session", GameModel.genericNumber);

            return View();
        }


    }
}
