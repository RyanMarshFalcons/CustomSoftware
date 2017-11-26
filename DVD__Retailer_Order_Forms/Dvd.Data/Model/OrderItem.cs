using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvd.Data.Model
{
    public class OrderItem
    {
        public int OrderItemNumber { get; set; }
        public int OrderNumber { get; set; }
        public int DVD_ID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
