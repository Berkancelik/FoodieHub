using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _MainPanelLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}