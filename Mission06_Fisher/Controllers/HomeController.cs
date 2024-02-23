using Microsoft.AspNetCore.Mvc;
using Mission06_Fisher.Models;
using System.Diagnostics;

namespace Mission06_Fisher.Controllers
{
    public class HomeController : Controller
    {
        private JoelHiltonMovieCollectionContext _context;
        public HomeController(JoelHiltonMovieCollectionContext FormName)
        {
            _context = FormName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KnowJoel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(Form response)
        {
            _context.Movies.Add(response); //Adding the record
            _context.SaveChanges();

            return View("Confirmation", response);
        }
        public IActionResult Collection()
        {
            var movieslist = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movieslist);
        }
    }
}
//var movies = _context.Movies.Include("Category")
//    .ToList();