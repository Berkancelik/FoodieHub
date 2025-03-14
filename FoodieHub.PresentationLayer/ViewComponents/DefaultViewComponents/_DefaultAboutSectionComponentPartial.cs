﻿using FoodieHub.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutSectionComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _DefaultAboutSectionComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetAll();
            return View(values);
        }
    }
}