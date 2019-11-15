using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;

namespace MobileShop.Areas.Admin.Controllers
{
    public class OrderManagementController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderManagementController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        [Area("Admin")]
        [Route("Admin/OrderManagement")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                return View(_orderRepository.Orders);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}