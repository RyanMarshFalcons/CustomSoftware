using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dvd.Data.Model;

namespace Dvd.Data.Interfaces.Store
{
    public interface ICustomerStore
    {
        int AddCustomer(Customer customer);
        int UdpateCustomer(Customer customer);

        Customer GetCustomer(int customerNumber);

        int DeleteCustomer(int customerNumber);

        List<Customer> GetCustomers();
    }
}
