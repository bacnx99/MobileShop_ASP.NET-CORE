using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.ViewModels;

namespace MobileShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/ProductManagement")]
    public class ProductManagementController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductManagementController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {   
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                ProductListViewModel vm = new ProductListViewModel();
                vm.Products = _productRepository.Products;
                vm.Categories = _categoryRepository.Categories;
                return View(vm);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("Add")]
        [HttpGet]
        public IActionResult Add()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                ViewBag.categories = _categoryRepository.Categories.ToList();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }   
        }
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Product product, IFormFile Product_ImageThumbnail)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                if (ModelState.IsValid)
                {
                    _productRepository.Add(product, Product_ImageThumbnail);
                    return RedirectToAction("Index");
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [Route("Edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                ViewBag.categories = _categoryRepository.Categories.ToList();
                Product product = _productRepository.GetProductById(id);
                if (product != null)
                {
                    return View(product);
                }
                return RedirectToAction("Index"); ///////////////// ERROR PAGE
            }
            else
            {
                return RedirectToAction("Index", "Login");
            } 
        }
        [Route("Edit/{id}")]
        [HttpPost]
        public IActionResult Edit(Product product, int id, IFormFile Product_ImageThumbnail)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.FullName = HttpContext.Session.GetString("FullName");
                if (ModelState.IsValid)
                {
                    _productRepository.Edit(product, id, Product_ImageThumbnail);
                    return Redirect("Index");
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }    
        }
        [Route("Delete/{id}")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            ViewBag.FullName = HttpContext.Session.GetString("FullName");
            if (HttpContext.Session.GetString("UserID") != null)
            {
                _productRepository.Delete(id);
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
            ViewBag.FullName = HttpContext.Session.GetString("FullName");
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return View(_productRepository.GetProductById(id));
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}