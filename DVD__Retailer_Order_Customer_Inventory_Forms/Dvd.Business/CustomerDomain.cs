using Dvd.Data.Interfaces;
using Dvd.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvd.Business
{
        public class CustomerDomain : ICustomerDomain
    {
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int custId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomerlist()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
