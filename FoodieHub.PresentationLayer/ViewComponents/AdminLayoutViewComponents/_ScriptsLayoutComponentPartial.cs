using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _ScriptsLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}