using MobileShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Data.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }

        Order GetOrderById(int id);

        Order Complete(int id);

        void CreateOrder(Order order);
    }
}
