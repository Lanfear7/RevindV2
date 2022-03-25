using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rolesDemoSSD.Data;
using rolesDemoSSD.Repositories;
using rolesDemoSSD.ViewModels;

namespace rolesDemoSSD.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILogger<LibraryController> _logger;
        private readonly ApplicationDbContext _context;

        public LibraryController(ILogger<LibraryController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Library()
        {
            return View();
        }
        public IActionResult GetAllMovies()
        {
            MovieRepo movieRepo = new MovieRepo(_context);
            var query = movieRepo.GetAllMovies();
            return View(query);
        }

        public IActionResult GetMovieById(int id)
        {
            //_logger.LogInformation("movieid= " + typeof(MovieID));
            /* _logger.LogInformation("movieid= " + typeof(movie.MovieID));*/
            MovieRepo movieRepo = new MovieRepo(_context);
            MovieVM movieVM = movieRepo.GetMovieById(id);
            return View(movieVM);
        }

    }
}
