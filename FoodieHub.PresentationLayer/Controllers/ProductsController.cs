using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
