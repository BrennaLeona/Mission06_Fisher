using Microsoft.AspNetCore.Mvc;
using Mission06_Fisher.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Fisher.Controllers
{
    public class HomeController : Controller
    {
        private JoelHiltonMovieCollectionContext _context;
        public HomeController(JoelHiltonMovieCollectionContext FormName)
        {
            _context = FormName;
        }
        //Regular displays and get requests
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
        public IActionResult MovieForm(Movie response) //Form posts - adding a record
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }
        public IActionResult Collection() //Display Collection from any other view
        {
            var movieslist = _context.Movies.Include("Category")
                .OrderBy(x => x.Title).ToList();

            return View(movieslist);
        }
    }
}