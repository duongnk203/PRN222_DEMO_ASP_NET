using System.Diagnostics;
using DemoASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoASPNETCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel message = new HomeModel();
            return View(message);
        }
    }
}
