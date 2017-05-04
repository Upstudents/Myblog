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

        [HttpGet]
          public IActionResult AddPost()
        {  
          return View();
        }   
        
        [HttpPost]
        public IActionResult AddPost(Post post)
        { 
            if (!ModelState.IsValid)
                return View("AddPost", post);
            else
                return RedirectToAction("ShowPost", post);  
          
        }       

        [ValidateAntiForgeryToken]
        [HttpPost] //oczekujemy żądania typy post - do tej akcji nie dostaniemy się wpisując odpowiednio jej nazwę w adresie przegladarki
        
        public ActionResult AddUser(User user)//w argumetach funckji znajduje się odpowiednia klasa z modelu
        {
            
            // walidacja - odwolujemy sie do poszczegolnych wlasciwosci funckji
            if (user.NIP.ToString().Length!=9)
                ModelState.AddModelError("NIP", "NIP powienien zawierać 9 liczb"); // ustawiamy tekst bledu jaki ma sie pojawic jak i nazwe zmiennej ktrorej ma dotyczyc
 
            if (user.Password!=user.ConfirmPassword)
                ModelState.AddModelError("ConfirmPassword", "Hasła powinny być identyczne");
 
            if (!ModelState.IsValid) // jezeli wystapil blad, zwracamy aktualna  strone do ktorej przekazujemy obiekt klasy, dzieki temu, uzupelnione przez nas pola nie zostana skasowane - po zaistnialym bledzie
                return View("Index", user);
            else
            {
                // Kod zapisujący lub wysyłający pytanie do właściciela strony
 
                return RedirectToAction("UserAdded",user); // jeszeli wszystko jest ok zwracamy widok i przekazujemy do niego obiekt
            }
            
        }
 
        public ActionResult UserAdded(User user) // akcja  do ktorej uzytkownik zostanie przekierowany po prawidlowym wypelnieniu formularza
        {
          
            
            
            return View(user);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
