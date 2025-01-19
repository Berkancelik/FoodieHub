using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
