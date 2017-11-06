using Dvd.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dvd.Data.Model;
using Dvd.Data.Interfaces.Store;
using Dvd.Store;

namespace Dvd.Business
{
    public class OrderDomain : IOrderDomain
    {
        private IOrderStore _orderStore;
        private ICustomerStore _customerStore;

        public OrderDomain(IOrderStore orderStore, ICustomerStore customerStore)
        {
            _orderStore = orderStore;
            _customerStore = customerStore;
        }

        public OrderDomain()
        {
            _orderStore = new OrderStore();
            _customerStore = new CustomerStore();
        }

        public void CreateOrder(Order order)
        {
            // Validate that Order info is correct
            // Validate that Customer info is correct

            // Check to see if customer is already in database
            // Add Customer if not in database
            order.CustomerId = _customerStore.AddCustomer(order.Customer);
            // OR Update Customer if already in database

            // Add the Order
            _orderStore.AddOrder(order);

        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderlist()
        {
            throw new NotImplementedException();
        }
    }
}
