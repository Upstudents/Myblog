using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using Projekt.Databases;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Projekt.Controllers
{
    public class HomeController : Controller
    {   
        private readonly BloggingContext _context;
        public HomeController(BloggingContext context)
        {
            _context=context;
        }
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
          //Post post = new Post("tytul", "opis", "tag", "tresc");
          return View();
        }   
        
        [HttpPost]
        public IActionResult AddPost(Post post)
        { 
            if (!ModelState.IsValid)
                return View("AddPost", post);
            else
            {
                post.PostedOn = DateTime.Now;
                post.Id = Guid.NewGuid();
                
                return RedirectToAction("ShowPost", post);  
            }
        }       

        
        [HttpGet] //oczekujemy żądania typy post - do tej akcji nie dostaniemy się wpisując odpowiednio jej nazwę w adresie przegladarki
        public IActionResult AddUser()//w argumetach funckji znajduje się odpowiednia klasa z modelu
        {
            return View();
            
        }

        [HttpPost]
        public IActionResult AddUser(User user) // akcja  do ktorej uzytkownik zostanie przekierowany po prawidlowym wypelnieniu formularza
        {
            
             if (user.Password!=user.ConfirmPassword)
                ModelState.AddModelError("ConfirmPassword", "Hasła powinny być identyczne");
            
            if (!ModelState.IsValid) // jezeli wystapil blad, zwracamy aktualna  strone do ktorej przekazujemy obiekt klasy, dzieki temu, uzupelnione przez nas pola nie zostana skasowane - po zaistnialym bledzie
                return View("AddUser", user);
            else
            {   
             Encrypter encrypter = new Encrypter();
                user.Salt = encrypter.GetHash(user.Password,user.Salt=encrypter.GetSalt("1dojutrek"));
                
                _context.Add(user);
                _context.SaveChangesAsync();
                //db.Users.Add(user);
                //db.SaveChanges();

                
                // Kod zapisujący lub wysyłający pytanie do właściciela strony
 
                return RedirectToAction("UserAdded",user); // jeszeli wszystko jest ok zwracamy widok i przekazujemy do niego obiekt
            }
         
            
        }

        public IActionResult UserAdded(User user)
        {
            return View(user);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
