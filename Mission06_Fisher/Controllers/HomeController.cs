using Microsoft.AspNetCore.Mvc;
using Mission06_Fisher.Models;
using System.Diagnostics;

namespace Mission06_Fisher.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;
        public HomeController(MovieFormContext FormName)
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
            _context.Forms.Add(response); //Adding the record
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
