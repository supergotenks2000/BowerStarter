using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using BowerStarter.Models;

namespace BowerStarter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Knockout()
        {
            return View();
        }

        public IActionResult KnockoutControlFlow()
        {
            return View();
        }

        public IActionResult Theme()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 100); //random number between 1 and 100
            ViewData["Badge"] = random;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save([FromBody]GameResult gameResult)
        {
            var message = string.Format($"Saved {gameResult.Opponent}");
            message += string.Format($" with {gameResult.Result}");
            message += string.Format($" on Twitter {gameResult.IsOnTwitter}");

            if ( gameResult.IsOnTwitter && !String.IsNullOrWhiteSpace(gameResult.TwitterName))
                message += string.Format($" with name {gameResult.TwitterName}");

            return Json(new { message });
        }
    }
}
