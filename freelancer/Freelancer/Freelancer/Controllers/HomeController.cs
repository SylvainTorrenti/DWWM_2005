using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
