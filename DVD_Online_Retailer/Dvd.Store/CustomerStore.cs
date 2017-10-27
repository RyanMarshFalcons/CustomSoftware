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
        private const string SQL_INSERT = "INSERT INTO [dbo].[Customer] "
            + "([FirstName],[LastName],[PhoneNumber],[EmailAddress],[MailingAddress],[BillingAddress], "
            + "[CardIssuerId],[CreditCardNumber],[SecurityCode]) "
            + "VALUES "
            + "(@FirstName, @LastName, @PhoneNumber, @EmailAddress, @MailingAddress, @BillingAddress, "
            + "@CardIssuerId, @CreditCardNumber, @SecurityCode); "
            + "SELECT @@IDENTITY ";

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

        public void DeleteCustomer(int CustomerNumber)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int CustomerNumber)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void UdpateCustomer(Customer Customer)
        {
            throw new NotImplementedException();
        }
    }
}
