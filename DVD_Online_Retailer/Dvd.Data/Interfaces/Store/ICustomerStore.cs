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
        int AddCustomer(Customer Customer);
        void UdpateCustomer(Customer Customer);

        Customer GetCustomer(int CustomerNumber);

        void DeleteCustomer(int CustomerNumber);

        List<Customer> GetCustomers();
    }
}
