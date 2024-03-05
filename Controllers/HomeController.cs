using demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demo.Controllers
{

    //HomeController inhert Controller
    public class HomeController : Controller
    {
        //constractour
        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

        //localhost:7277/home/privacy
        public IActionResult Privacy()
        {
            return View();
        }

        
    }




}
