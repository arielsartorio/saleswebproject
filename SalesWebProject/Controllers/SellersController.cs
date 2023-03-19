using Microsoft.AspNetCore.Mvc;

namespace SalesWebProject.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
