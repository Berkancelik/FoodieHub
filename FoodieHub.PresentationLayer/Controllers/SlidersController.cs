using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.Controllers
{
    public class SlidersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
