using Services.Contracts;
using Services.Contratc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IOrderService _orderService;
        private readonly IAuthService _authService;

        public ServiceManager(IProductService productService, ICategoryService categoryService, IOrderService orderService, IAuthService authService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _orderService = orderService;
            _authService = authService;
        }

        public IProductService productService => _productService;

        public ICategoryService categoryService => _categoryService;

        public IOrderService orderService => _orderService;

        public IAuthService AuthService => _authService;
    }
}
