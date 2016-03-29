using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using BowerStarter.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BowerStarter.Controllers
{
    public class PersonController : Controller
    {
        [Route("/api/people")]
        public JsonResult GetPeople()
        {
            var people = new List<Person>()
            {
                new Person { Id = 1, FirstName = "John", LastName = "Doe" },
                new Person { Id = 2, FirstName = "Mary", LastName = "Jane" },
                new Person { Id = 3, FirstName = "Bob", LastName = "Parker" }
            };
            return Json(people);
        }
    }
}
