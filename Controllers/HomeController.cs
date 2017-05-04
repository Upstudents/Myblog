using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;

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

        public IActionResult ShowPost(Post post)
        {
            return View(post);
        }

        [HttpPost]
        public IActionResult AddPost(Post post)
        {
            return RedirectToAction("ShowPost",post);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
