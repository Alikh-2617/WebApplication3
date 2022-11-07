using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult Index()
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
            if(GameModel.counter == 0)
            {
                HttpContext.Session.SetInt32("Session", GameModel.GenericNumber());
            }
            ViewBag.Result = GameModel.Game(input, (int)HttpContext.Session.GetInt32("Session"));
            ViewBag.Counter = GameModel.counter;
            ViewBag.Gusset = input;

//            ViewBag.generedNumber1 = (int)HttpContext.Session.GetInt32("Session");

            return View();
        }

    }
}
