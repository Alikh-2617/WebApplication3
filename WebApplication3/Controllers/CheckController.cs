using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CheckAge()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckAge(int input) // input name i view 
        {
            ViewBag.Result = Check.CheckAge(input);
            return View();
        }

        //--- Sessetion delen och Cookies --------------------------------------
        public IActionResult SetSession() // skicka infö () 
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetSession(string input)
        {
            if(input != null)
            {
                // skapa instans 
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddMinutes(5);  // expires efter 5 min
                HttpContext.Response.Cookies.Append("Cookie" , input , options); // sett cookies

                HttpContext.Session.SetString("Session", input);
                ViewBag.Message = "Sesstionand Cookies has been set !";
            }

            return View();
        }

        public IActionResult GetSession()
        {   // få både cookie o session
            ViewBag.Cookie = HttpContext.Request.Cookies["Cookie"];
            ViewBag.Session = HttpContext.Session.GetString("Session");
            return View();
        }


    }
}
