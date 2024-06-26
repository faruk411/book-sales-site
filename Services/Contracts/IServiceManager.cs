﻿using Services.Contratc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IServiceManager
    {
        IProductService productService { get; }

        ICategoryService categoryService { get; }
        IOrderService orderService { get; }
        IAuthService AuthService { get; }

    }
}
