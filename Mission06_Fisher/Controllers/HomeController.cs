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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            
            return View(new Movie());
        }
        [HttpPost]
        public IActionResult MovieForm(Movie response) //Form posts - adding a record
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(response);
            }
            
        }
        public IActionResult Collection() //Display Collection from any other view
        {
            var movieslist = _context.Movies.Include("Category")
                .OrderBy(x => x.Title).ToList();

            return View(movieslist);
        }
        [HttpGet]
        public IActionResult Edit(int id) //Edit (To form)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);
            
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MovieForm", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) //Edit (To Collection)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("Collection");
        }
        [HttpGet]
        public IActionResult Delete(int id) //Confirm Delete Request
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movie recordToDelete) //Delete (To Collection
        {
            _context.Movies.Remove(recordToDelete);
            _context.SaveChanges();

            return RedirectToAction("Collection");
        }
    }
}