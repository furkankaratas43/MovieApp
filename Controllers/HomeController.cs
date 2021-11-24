using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        MovieCategoryModel model = new MovieCategoryModel();
        model.Movies = MovieRepository.Movies;
        model.Categories = CategoryRepository.Categories;
        return View(model);
    }

    public IActionResult Contact()
    {
        return View();
    }
}
