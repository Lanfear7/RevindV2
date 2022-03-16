using Microsoft.AspNetCore.Mvc;
using rolesDemoSSD.Data;
using rolesDemoSSD.Repositories;

namespace rolesDemoSSD.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Library()
        {
            return View();
        }
        public IActionResult GetAllMovies()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            MovieRepo movieRepo = new MovieRepo(context);
            var query = movieRepo.GetAllMovies();
            return View(query);
        }
    }
}
