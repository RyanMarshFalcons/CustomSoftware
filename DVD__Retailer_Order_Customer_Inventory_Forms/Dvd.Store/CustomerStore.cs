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
    public class CustomerStore : ICustomerStore
    {
        #region Constant Strings
        private const string SQL_SELECT =
            "SELECT CustomerId, FirstName, LastName, PhoneNumber, EmailAddress, MailingAddress, "
        + "BillingAddress, CardIssuerId, CreditCardNumber, SecurityCode "
        + "FROM [dbo].[Customer] ";

        private const string SQL_SELECT_ROW =
            SQL_SELECT + "WHERE CustomerID = @CustomerId ";

        private const string SQL_INSERT = "INSERT INTO [dbo].[Customer] "
            + "([FirstName],[LastName],[PhoneNumber],[EmailAddress],[MailingAddress],[BillingAddress], "
            + "[CardIssuerId],[CreditCardNumber],[SecurityCode]) "
            + "VALUES "
            + "(@FirstName, @LastName, @PhoneNumber, @EmailAddress, @MailingAddress, @BillingAddress, "
            + "@CardIssuerId, @CreditCardNumber, @SecurityCode); "
            + "SELECT @@IDENTITY ";

        private const string SQL_UPDATE = 
                "UPDATE [dbo].[Customer] "
                + "SET FirstName = @FirstName, "
                + "LastName = @LastName, "
                + "PhoneNumber = @PhoneNumber, "
                + "EmailAddress = @EmailAddress, "
                + "MailingAddress = @MailingAddress, "
                + "BillingAddress = @BillingAddress, "
                + "CardIssuerId = @CardIssuerId, "
                + "CreditCardNumber = @CreditCardNumber, "
                + "SecurityCode = @SecurityCode "
                + "WHERE CustomerID = @CustomerID ";

        private const string SQL_DELETE =
                "UPDATE [dbo].[Customer] "
                + "SET IsDeleted = 1 "
                + "WHERE CustomerId = @CustomerId ";
        #endregion

        public int AddCustomer(Customer customer)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = customer.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = customer.LastName;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 50).Value = customer.PhoneNumber;
                    cmd.Parameters.Add("@EmailAddress", SqlDbType.VarChar, 50).Value = customer.EmailAddress;
                    cmd.Parameters.Add("@MailingAddress", SqlDbType.VarChar, 50).Value = customer.MailingAddress;
                    cmd.Parameters.Add("@BillingAddress", SqlDbType.VarChar, 50).Value = customer.BillingAddress;
                    cmd.Parameters.Add("@CardIssuerId", SqlDbType.Int).Value = (int)customer.CardIssuer;
                    cmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar, 50).Value = customer.CreditCardNumber;
                    cmd.Parameters.Add("@SecurityCode", SqlDbType.Int).Value = customer.SecurityCode;

                    conn.Open();
                    var id = cmd.ExecuteScalar();
                    return Convert.ToInt32(id);                
                }
            }
        }

        public int DeleteCustomer(int customerNumber)
        {
            var rowsAffected = 0;
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(SQL_DELETE, conn))
                    {
                        cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerNumber;
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            return rowsAffected;
        }

        public Customer GetCustomer(int customerNumber)
        {
            var customer = new Customer();
            using (var conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(SQL_SELECT_ROW, conn);
                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerNumber;

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    AssignColumnValues(rdr, customer);
                }
            }
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            var items = new List<Customer>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(SQL_SELECT, conn);

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var item = new Customer();
                    AssignColumnValues(rdr, item);
                    items.Add(item);
                }
            }
            return items;
        }

        private static void AssignColumnValues(SqlDataReader rdr, Customer item)
        {
            item.CustomerId = (!rdr.IsDBNull(0)) ? rdr.GetInt32(0) : 0;
            item.FirstName = (!rdr.IsDBNull(1)) ? rdr.GetString(1) : String.Empty;
            item.LastName = (!rdr.IsDBNull(2)) ? rdr.GetString(2) : String.Empty;
            item.PhoneNumber = (!rdr.IsDBNull(3)) ? rdr.GetString(3) : String.Empty;
            item.EmailAddress = (!rdr.IsDBNull(4)) ? rdr.GetString(4) : String.Empty;
            item.MailingAddress = (!rdr.IsDBNull(5)) ? rdr.GetString(5) : String.Empty;
            item.BillingAddress = (!rdr.IsDBNull(6)) ? rdr.GetString(6) : String.Empty;
            item.CardIssuer = (!rdr.IsDBNull(7)) ? (CreditCardCompany)rdr.GetInt32(7) : 0;
            item.CreditCardNumber = (!rdr.IsDBNull(8)) ? rdr.GetString(8) : String.Empty;
            item.SecurityCode = (!rdr.IsDBNull(9)) ? rdr.GetInt32(9) : 0;
        }

        public int UdpateCustomer(Customer customer)
        {
            var rowsAffected = 0;
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_UPDATE, conn))
                {
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customer.CustomerId;
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = customer.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = customer.LastName;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 50).Value = customer.PhoneNumber;
                    cmd.Parameters.Add("@EmailAddress", SqlDbType.VarChar, 50).Value = customer.EmailAddress;
                    cmd.Parameters.Add("@MailingAddress", SqlDbType.VarChar, 50).Value = customer.MailingAddress;
                    cmd.Parameters.Add("@BillingAddress", SqlDbType.VarChar, 50).Value = customer.BillingAddress;
                    cmd.Parameters.Add("@CardIssuerId", SqlDbType.Int).Value = (int)customer.CardIssuer;
                    cmd.Parameters.Add("@CreditCardNumber", SqlDbType.VarChar, 50).Value = customer.CreditCardNumber;
                    cmd.Parameters.Add("@SecurityCode", SqlDbType.Int).Value = customer.SecurityCode;

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
