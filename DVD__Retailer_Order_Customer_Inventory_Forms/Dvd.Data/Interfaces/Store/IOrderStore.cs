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
        void AddOrder(Order order);
        void UdpateOrder(Order order);

        Order GetOrder(int orderNumber);

        void DeleteOrder(int orderNumber);

        List<Order> GetOrders();
    }
}
