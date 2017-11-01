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
        #region Constant Strings
        

        private const string SQL_SELECT =
            "SELECT OrderNumber, CustomerId, ShippingMethodId, ShippingStatusId, OrderDate "
            + "FROM [dbo].[Order] "
            + "WHERE IsDeleted = 0 ";

        private const string SQL_SELECT_ROW =
            SQL_SELECT + "AND OrderNumber = @OrderNumber ";

        private const string SQL_INSERT = "INSERT INTO [dbo].[Order] "
            + "([CustomerId], [ShippingMethodId], [ShippingStatusId], [OrderDate]) "
            + "VALUES "
            + "(@CustomerId, @ShippingMethodId, @ShippingStatusId, @OrderDate) ";

        private const string SQL_UPDATE =
                "UPDATE [dbo].[Order] "
                + "SET CustomerId = @CustomerId, "
                + "ShippingMethodId = @ShippingMethodId, "
                + "ShippingStatusId = @ShippingStatusId, "
                + "OrderDate = @OrderDate "
                + "WHERE OrderNumber = @OrderNumber ";

        private const string SQL_DELETE =
                "UPDATE [dbo].[Order] "
                + "SET IsDeleted = 1 "
                + "WHERE OrderNumber = @OrderNumber ";
        #endregion


        public int AddOrder(Order order)
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
                    var id = cmd.ExecuteScalar();
                    return Convert.ToInt32(id);
                }
            }
        }

        public int DeleteOrder(int orderNumber)
        {
            var rowsAffected = 0;
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_DELETE, conn))
                {
                    cmd.Parameters.Add("@OrderNumber", SqlDbType.Int).Value = orderNumber;
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public Order GetOrder(int orderNumber)
        {
            var order = new Order();
            using (var conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(SQL_SELECT_ROW, conn);
                cmd.Parameters.Add("@OrderNumber", SqlDbType.Int).Value = orderNumber;

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    AssignColumnValues(rdr, order);
                }
            }
            return order;
        }

        private static void AssignColumnValues(SqlDataReader rdr, Order item)
        {
            item.OrderNumber = (!rdr.IsDBNull(0)) ? rdr.GetInt32(0) : 0;
            item.CustomerId = (!rdr.IsDBNull(1)) ? rdr.GetInt32(1) : 0;
            item.ShippingMethod = (!rdr.IsDBNull(2)) ? (ShippingMethod)rdr.GetInt32(2) : 0;
            item.ShippingStatus = (!rdr.IsDBNull(3)) ? (ShippingStatus)rdr.GetInt32(3) : 0;
            item.OrderDate = (!rdr.IsDBNull(4)) ? (rdr.GetDateTime(4)) : DateTime.MinValue;
        }

        public List<Order> GetOrders()
        {
            var items = new List<Order>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(SQL_SELECT, conn);

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var item = new Order();
                    AssignColumnValues(rdr, item);
                    items.Add(item);
                }
            }
            return items;
        }

        public int UdpateOrder(Order order)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_UPDATE, conn))
                {
                    cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = order.CustomerId;
                    cmd.Parameters.Add("@ShippingMethodId", SqlDbType.Int).Value = (int)order.ShippingMethod;
                    cmd.Parameters.Add("@ShippingStatusId", SqlDbType.Int).Value = (int)order.ShippingStatus;
                    cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = order.OrderDate;
                    
                    conn.Open();
                    var id = cmd.ExecuteScalar();
                    return Convert.ToInt32(id);
                }
            }
        }
    }
}
