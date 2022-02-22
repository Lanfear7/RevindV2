using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rolesDemoSSD.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Home/getContent")]
        public async Task<ActionResult> getContent()
        {
            string url = "https://api.themoviedb.org/3/movie/76324?api_key=";

            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            var response = await client.ExecuteAsync(request);
            string content = response.Content;

            string[] unwantedCharacters = { "\\", "\"", "{", "[", "}", "}" };

            // remove unwanted characters
            foreach (var unwantedCharacter in unwantedCharacters)
            {
                content = content.Replace(unwantedCharacter, "");
            }

            var contentArray = content.Split(",");

            List<string> names = new List<string>();
            List<string> values = new List<string>();
            foreach (var contentItem in contentArray)
            {
                string[] nameValuePair = contentItem.Split(":");

                names.Add(nameValuePair[0]);
                values.Add(nameValuePair[1]);
            }

            return View();
        }

    }
}
