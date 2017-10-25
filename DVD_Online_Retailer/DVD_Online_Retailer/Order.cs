using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Online_Retailer
{
    public enum ShippingMethod { Ground, FirstClass, TwoDay, Overnight};
    public enum ShippingStatus { BackOrdered, NotYetShipped, Shipped, Delivered, Lost};
    public class Order
    {
        public int OrderNumber { get; set; }
        public Customer Customer { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
