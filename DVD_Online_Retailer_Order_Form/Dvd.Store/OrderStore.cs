using Dvd.Data.Interfaces.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dvd.Data.Model;
using System.Data.SqlClient;
using System.Data;

namespace Dvd.Store
{
    public class OrderStore : IOrderStore
    {
        private const string SQL_INSERT = "INSERT INTO [dbo].[Order] "
            + "([CustomerId], [ShippingMethodId], [ShippingStatusId], [OrderDate]) "
            + "VALUES "
            + "(@CustomerId, @ShippingMethodId, @ShippingStatusId, @OrderDate)";

        public void AddOrder(Order order)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = order.CustomerId;
                    cmd.Parameters.Add("@ShippingMethodId", SqlDbType.Int).Value = (int)order.ShippingMethod;
                    cmd.Parameters.Add("@ShippingStatusId", SqlDbType.Int).Value = (int)order.ShippingStatus;
                    cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = order.OrderDate;
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void DeleteOrder(int orderNumber)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int orderNumber)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void UdpateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
