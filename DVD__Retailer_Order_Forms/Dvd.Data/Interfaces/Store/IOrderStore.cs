using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dvd.Data.Model;

namespace Dvd.Data.Interfaces.Store
{
    public interface IOrderStore
    {
        int AddOrder(Order order);
        int UdpateOrder(Order order);

        Order GetOrder(int orderNumber);

        int DeleteOrder(int orderNumber);

        List<Order> GetOrders();
    }
}
