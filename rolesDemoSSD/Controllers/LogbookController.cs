using Microsoft.AspNetCore.Mvc;

namespace rolesDemoSSD.Controllers
{
    public class LogbookController : Controller
    {
        public IActionResult Logbook()
        {
            return View();
        }
    }
}
