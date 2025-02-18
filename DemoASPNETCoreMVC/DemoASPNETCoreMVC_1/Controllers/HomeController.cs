using DemoASPNETCoreMVC_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoASPNETCoreMVC_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int Code, string Name, string Department)
        {
            //HomeModel message = new HomeModel();

            //HttpContext.Session.SetString("Product", "Laptop");

            //return View(message);

            string strResult = $"Id = {Code}, Name = {Name}, Department = {Department}";
            return Content(strResult);
        }

        public string Hello() => "Hello, ASP.NET Core MVC";

        [Route("Home/DemoSession")]
        public IActionResult DemoSession()
        {
            ViewBag.Data = HttpContext.Session.GetString("Product");
            return View();
        }

        [Route("Home/DemoCookie")]
        public IActionResult DemoCookie()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(30);
            options.Path = "/";
            options.Secure = true;
            options.SameSite = SameSiteMode.Lax; // Hoặc SameSiteMode.None
            Response.Cookies.Append("MyKey", "David", options);

            return View();
        }
    }
}
