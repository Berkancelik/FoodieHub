using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _CustomTemplateLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}