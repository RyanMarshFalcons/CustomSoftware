using Dvd.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvd.Data.Interfaces
{
    public interface IOrderDomain
    {
        void CreateOrder(Order order);

        void UpdateOrder(Order order);

    }
}
