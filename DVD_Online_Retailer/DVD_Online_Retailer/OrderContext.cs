using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DVD_Online_Retailer
{
    public class OrderContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DVD> DVDs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
