using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.Data.ViewModels;

namespace MobileShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/OrderManagement")]
    public class OrderManagementController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderManagementController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [Route("")]
        [Route("Index")]
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

        [Route("Complete/{id}")]
        [HttpPost]
        public IActionResult Complete(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                Order order = _orderRepository.GetOrderById(id);

                _orderRepository.Complete(id);
                TempData["CompleteSuccess"] = "Hoàn thành đơn hàng: Mã đơn hàng - " + order.Order_Id + " thành công.";
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [Route("Detail/{id}")]
        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                OrderListViewModel vm = new OrderListViewModel();
                vm.Orders = _orderRepository.Orders;
                //vm.OrderDetails = _orderRepository.Orders.
                
                //_orderRepository.Complete(id);
                
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}