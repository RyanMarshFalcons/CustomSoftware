using Dvd.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvd.Data.Interfaces
{
    public interface ICustomerDomain
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);

        Customer GetCustomer(int custId);

        List<Customer> GetCustomerlist();
    }
}
