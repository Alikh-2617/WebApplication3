using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(int input)
        {
            ViewBag.Result = FeverVM.FeverCheck(input);
            return View();
        }
    }
}
