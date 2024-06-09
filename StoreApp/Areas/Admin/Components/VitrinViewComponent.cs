using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components
{
    public class VitrinViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public VitrinViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public IViewComponentResult Invoke()
        {
            var products = _manager.productService.GetVitrinProducts(false);
            return View(products);
        }
    }
}
