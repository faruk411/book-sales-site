using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;
using Entities.RequestParameters;
using StoreApp.Models;


namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(ProductRequestParameters p)
        {
            var products = _manager.productService.GetAllProductsWithDetails(p);
            var pagination = new Pagination()
            {
                CurrenPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _manager.productService.GetAllProducts(false).Count()
            };
           return View(new ProductListViewModel()
           {
               Products = products,
               Pagination = pagination
           });
        }
        public IActionResult Get([FromRoute(Name ="id")] int id)
        {
            var model = _manager.productService.GetOneProduct(id,false);
            return View(model);
        }
    }
}