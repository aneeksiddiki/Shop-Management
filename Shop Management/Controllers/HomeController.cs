using Microsoft.AspNetCore.Mvc;

namespace Shop_Management.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
