﻿using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components
{
    public class CategoriesMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public CategoriesMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public IViewComponentResult Invoke()
        {
            var catagories = _manager.categoryService.GetAllCategories(false);
            return View(catagories);
        }
    }
}
