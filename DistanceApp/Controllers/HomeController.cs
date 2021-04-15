using Microsoft.AspNetCore.Mvc;
using DistanceApp.Models;

namespace DistanceApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View("Index", new Measurement(){} );

        [HttpPost]
        public IActionResult Index(Measurement m) => View("Index", m.Calc(m));
    }
}
