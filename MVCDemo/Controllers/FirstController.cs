using Microsoft.AspNetCore.Mvc;

using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "Hello, World!";
        }

        public IActionResult Hello()
        {
            ViewBag.Message = "Hej på dig, hur är läget?";
            return View();
        }

        public IActionResult Info()
        {
            var person = new Person();
            person.Name = "Claes";
            person.Age = 65;
            person.Location = "Göteborg";

            return View(person);
        }
    }
}
