using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultNavbarSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}