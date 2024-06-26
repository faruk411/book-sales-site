﻿using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Controllers
{
    public class OrderController:Controller
    {
        private readonly IServiceManager _manager;
        private readonly Cart _cart;

        public OrderController(IServiceManager manager, Cart cart)
        {
            _manager = manager;
            _cart = cart;
        }

        public ViewResult CheckOut() => View(new Order());
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Checkout([FromForm] Order order)
        {
            if(_cart.Lines.Count == 0)
            {
                ModelState.AddModelError("", "Üzgünüz sepetiniz boş!!!");
            }
            if(ModelState.IsValid)
            {
                order.Lines = _cart.Lines.ToArray();
                _manager.orderService.SaveOrder(order);
                _cart.Clear();
                return RedirectToPage("/Complete",new {OrderId = order.OrderId});
            }
            else
            {
                return View();
            }
        }
    }
}
