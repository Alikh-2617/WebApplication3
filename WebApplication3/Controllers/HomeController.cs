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
            ViewBag.Message = "message från Controller ";
            return View();
        }

        [HttpGet]
        public IActionResult Game()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Game(int id)
        {
            ViewBag.Result = GameModel.Game(id);
            ViewBag.Counter = GameModel.counter;
            HttpContext.Session.SetInt32("Session", GameModel.genericNumber);
            return View();
        }


    }
}