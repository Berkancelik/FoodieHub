using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
