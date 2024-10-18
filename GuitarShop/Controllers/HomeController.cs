using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/ContactUs")]
        public IActionResult ContactUs()
        {
            var contact = new Dictionary<string, string>
            {
                { "Phone: ", "555-123-4567" },
                { "Email: ", "info@myguitarshop.com" },
                { "Cell: ", "555-234-5678" }
            };
            return View(contact);
        }
    }
}
