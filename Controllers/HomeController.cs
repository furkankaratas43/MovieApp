using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {

        return View(MovieRepository.Movies);
    }

    public IActionResult Contact()
    {
        return View();
    }
}
