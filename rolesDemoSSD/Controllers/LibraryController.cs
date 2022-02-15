using Microsoft.AspNetCore.Mvc;

namespace rolesDemoSSD.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Library()
        {
            return View();
        }
    }
}
