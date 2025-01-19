using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
