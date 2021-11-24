using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index(int? id)
    {
        var movies = MovieRepository.Movies;

        if (id != null)
        {
            movies = movies.Where(i => i.CategoryId == id).ToList();
        }
        return View(movies);
    }

    public IActionResult Contact()
    {
        return View();
    }
}
