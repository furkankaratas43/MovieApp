using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        
        public IActionResult Details(){
            return View();
        }

        public IActionResult List(){
            return View();
        } 
    }
}