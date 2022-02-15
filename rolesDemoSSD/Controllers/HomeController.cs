using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;
using rolesDemoSSD.Data;
using rolesDemoSSD.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace rolesDemoSSD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, 
                              ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [Authorize]
        public IActionResult SecureArea()
        {
            // Get user name of user who is logged in.
            // This line must be in the controller.
            string userName = User.Identity.Name;

            // Usually this section would be in a repository.
            var registeredUser = _context.MyRegisteredUsers.Where(ru => ru.Email == userName)
                                .FirstOrDefault();// Use FirstOrDefault() when getting one item


            return View(registeredUser);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // api test
        // Install-Package RestSharp
        [HttpGet]
        [Route("Home/getContent")]
        public async Task<ActionResult> getContent()
        {
            string url = "https://api.themoviedb.org/3/movie/76324?api_key=1fa26c8425e1e11c9424d0273f1e98f8";


            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            var response = await client.ExecuteAsync(request);
            string content = response.Content;

            string[] unwantedCharacters = { "\\", "\"", "{", "[", "}", "}" };

            // remove unwanted characters
            foreach (var unwantedCharacter in unwantedCharacters) {
                content = content.Replace(unwantedCharacter, "");
            }


            var contentArray = content.Split(",");

            List<string> names = new List<string>();
            List<string> values = new List<string>();
            foreach (var contentItem in contentArray) {
                string[] nameValuePair = contentItem.Split(":");
         
                names.Add(nameValuePair[0]);
                values.Add(nameValuePair[1]);
            }

            return View();
        }

    }
}
