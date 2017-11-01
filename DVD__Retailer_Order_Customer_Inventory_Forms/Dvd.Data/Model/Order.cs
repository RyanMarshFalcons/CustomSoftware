using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvd.Data.Model
{
    public enum ShippingMethod { Ground, FirstClass, TwoDay, Overnight};
    public enum ShippingStatus { NotYetShipped, Shipped, Delivered, Lost, BackOrdered};
    public class Order
    {
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> DVDs_Ordered { get; set; }
        public decimal OrderTotal { get; set; }
        public bool IsDeleted { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
