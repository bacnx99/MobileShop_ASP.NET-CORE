using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public IEnumerable<Order> Orders => _appDbContext.Orders;

        public void CreateOrder(Order order)
        {
            order.Order_Placed = DateTime.Now;

            order.Order_Total = _shoppingCart.GetShoppingCartTotal();

            _appDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    OrderDetail_Amount = shoppingCartItem.ShoppingCartItem_Amount,
                    Product_Id = shoppingCartItem.Product.Product_Id,
                    Order_Id = order.Order_Id,
                    OrderDetail_Price = shoppingCartItem.Product.Product_Price
                };

                _appDbContext.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
