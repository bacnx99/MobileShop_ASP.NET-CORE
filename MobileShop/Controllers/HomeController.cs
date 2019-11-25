using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data.Interfaces;
using MobileShop.ViewModels;

namespace MobileShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            ProductListViewModel vm = new ProductListViewModel();
            vm.PreferredProducts = _productRepository.PreferredProducts();
            vm.Products = _productRepository.Products;
            vm.Categories = _categoryRepository.Categories;
            vm.ProductsBestSelling = _productRepository.ProductsBestSelling();
            return View(vm);
        }
    }
}