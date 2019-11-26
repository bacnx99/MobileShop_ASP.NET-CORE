using Microsoft.AspNetCore.Http;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> PreferredProducts();
        IEnumerable<Product> ProductsBestSelling();
        IEnumerable<Product> OtherProducts();
        Product GetProductById(int productId);
        IEnumerable<Product> Search(string keyword);
        IEnumerable<Product> OrderByPriceASC(string keyword);
        IEnumerable<Product> OrderByPriceDESC(string keyword);
        IEnumerable<Product> OrderByPriceOption(decimal val1, decimal val2, string keyword);
        Product Add(Product product, IFormFile photo);
        Product Edit(Product product, int id, IFormFile photo);
        Product Delete(int id);

        void AddPhoto(Product product, IFormFile photo);
    }
}
