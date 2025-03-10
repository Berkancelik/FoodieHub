﻿using FoodieHub.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodieHub.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultProductSectionComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductSectionComponentPartial(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _productService.TProductListWithCategoryAndLast12Items();
            return View(values);
        }
    }
}