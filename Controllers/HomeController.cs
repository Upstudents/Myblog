using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Projekt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Posts()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPost(string Title)
        {
            return Content(Title);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
