using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dvd.Store;
using Dvd.Data;
using Dvd.Data.Model;
using System.Data.SqlClient;

namespace TestDataLayer
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your selection: \n1) Delete Customer\n2) Get Customer\n3) Get Customers\n4) Update Customer\n5) Delete Order\n6) Get Order\n7) Get Orders\n8) Update Order");
            var selection = Console.ReadLine();
            var customerNumber = 0;
            switch (selection)
            {
                case "1":
                    Console.Write("Enter the customer number of the customer you want to delete: ");
                    customerNumber = int.Parse(Console.ReadLine());
                    DeleteCustomer(customerNumber);
                    break;
                case "2":
                    Console.Write("Enter the customer number of the customer you want to get: ");
                    customerNumber = int.Parse(Console.ReadLine());
                    var customer = GetCustomer(customerNumber);
                    Console.WriteLine($"Customer ID: {customer.CustomerId}");
                    Console.WriteLine($"First name: {customer.FirstName}");
                    Console.WriteLine($"Last name: {customer.LastName}");
                    Console.WriteLine($"Phone Number: {customer.PhoneNumber}");
                    Console.WriteLine($"Email Address: {customer.EmailAddress}");
                    Console.WriteLine($"Mailing Address: {customer.MailingAddress}");
                    Console.WriteLine($"Billing Address: {customer.BillingAddress}");
                    Console.WriteLine($"Credit Card Company: {customer.CardIssuer.ToString()}");
                    Console.WriteLine($"Credit Card Number: {customer.CreditCardNumber}");
                    Console.WriteLine($"Security Code: {customer.SecurityCode}");
                    break;
                default:
                    break;
                case "3":
                    var customers = GetCustomers();
                    foreach (var cust in customers)
                    {
                        Console.WriteLine($"\nCustomer ID: {cust.CustomerId}");
                        Console.WriteLine($"First name: {cust.FirstName}");
                        Console.WriteLine($"Last name: {cust.LastName}");
                        Console.WriteLine($"Phone Number: {cust.PhoneNumber}");
                        Console.WriteLine($"Email Address: {cust.EmailAddress}");
                        Console.WriteLine($"Mailing Address: {cust.MailingAddress}");
                        Console.WriteLine($"Billing Address: {cust.BillingAddress}");
                        Console.WriteLine($"Credit Card Company: {cust.CardIssuer.ToString()}");
                        Console.WriteLine($"Credit Card Number: {cust.CreditCardNumber}");
                        Console.WriteLine($"Security Code: {cust.SecurityCode}");
                    }
                    break;
                case "4":
                    var custUpdate = new Customer();
                    Console.Write("What is the customer ID of the customer you want to update: ");
                    custUpdate.CustomerId = int.Parse(Console.ReadLine());
                    Console.Write("What is the first name of the customer you want to update: ");
                    custUpdate.FirstName = Console.ReadLine();
                    Console.Write("What is the last name of the customer you want to update: ");
                    custUpdate.FirstName = Console.ReadLine();
                    Console.Write("What is the phone number of the customer you want to update: ");
                    custUpdate.FirstName = Console.ReadLine();
                    Console.Write("What is the email address of the customer you want to update: ");
                    custUpdate.FirstName = Console.ReadLine();
                    Console.Write("What is the first name of the customer you want to update: ");
                    custUpdate.FirstName = Console.ReadLine();
                    Console.Write("What is the first name of the customer you want to update: ");
                    custUpdate.FirstName = Console.ReadLine();






                    break;
            }

            Console.ReadLine();
        }
        public static void DeleteCustomer(int customerNumber)
        {
            var SQL_DELETE = $"DELETE FROM [dbo].[Customer] WHERE CustomerID = {customerNumber} ";
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_DELETE, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static Customer GetCustomer(int CustomerNumber)
        {
            var customer = new Customer();
            var SQL_SELECT = $"SELECT CustomerId, FirstName, LastName, PhoneNumber, EmailAddress, MailingAddress, "
            + "BillingAddress, CardIssuerId, CreditCardNumber, SecurityCode FROM [dbo].[Customer] WHERE CustomerID = {customerNumber} ";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL_SELECT, conn);
                cmd.Parameters.Add(new SqlParameter("@CustomerId", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@FirstName", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@LastName", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@EmailAddress", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@MailingAddress", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@BillingAddress", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@CardIssuerId", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@CreditCardNumber", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@SecurityCode", System.Data.SqlDbType.Int));
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                customer.CustomerId = rdr.GetInt32(0);
                customer.FirstName = rdr.GetString(1);
                customer.LastName = rdr.GetString(2);
                customer.PhoneNumber = rdr.GetString(3);
                customer.EmailAddress = rdr.GetString(4);
                customer.MailingAddress = rdr.GetString(5);
                customer.BillingAddress = rdr.GetString(6);
                customer.CardIssuer = (CreditCardCompany)rdr.GetInt32(7);
                customer.CreditCardNumber = rdr.GetString(8);
                customer.SecurityCode = rdr.GetInt32(9); 
            }
            return customer;
        }

        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            var customer = new Customer();
            var SQL_SELECT = "SELECT CustomerId, FirstName, LastName, PhoneNumber, EmailAddress, MailingAddress, "
            + "BillingAddress, CardIssuerId, CreditCardNumber, SecurityCode FROM [dbo].[Customer]";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL_SELECT, conn);
                cmd.Parameters.Add(new SqlParameter("@CustomerId", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@FirstName", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@LastName", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@EmailAddress", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@MailingAddress", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@BillingAddress", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@CardIssuerId", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@CreditCardNumber", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@SecurityCode", System.Data.SqlDbType.Int));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    customer.CustomerId = rdr.GetInt32(0);
                    customer.FirstName = rdr.GetString(1);
                    customer.LastName = rdr.GetString(2);
                    customer.PhoneNumber = rdr.GetString(3);
                    customer.EmailAddress = rdr.GetString(4);
                    customer.MailingAddress = rdr.GetString(5);
                    customer.BillingAddress = rdr.GetString(6);
                    customer.CardIssuer = (CreditCardCompany)rdr.GetInt32(7);
                    customer.CreditCardNumber = rdr.GetString(8);
                    customer.SecurityCode = rdr.GetInt32(9);
                    customers.Add(customer);
                }
            }
            return customers;
        }

        public static void UdpateCustomer(Customer Customer)
        {
            var SQL_UPDATE = "UPDATE [dbo].[Customer] "
            + "SET FirstName = Customer.FirstName, LastName = Customer.LastName, PhoneNumber = Customer.PhoneNumber, "
            + "EmailAddress = Customer.EmailAddress, MailingAddress = Customer.MailingAddress, BillingAddress = Customer.BillingAddress, "
            + "CardIssuerId = Customer.CardIssuerId, CreditCardNumber = Customer.CreditCardNumber, SecurityCode = Customer.SecurityCode "
            + "WHERE CustomerID = Customer.CustomerID";
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_UPDATE, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static void DeleteOrder(int orderNumber)
        {
            var SQL_DELETE = $"DELETE FROM [dbo].[Order] WHERE OrderNumber = {orderNumber} ";
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_DELETE, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static Order GetOrder(int orderNumber)
        {
            var order = new Order();
            var SQL_SELECT = $"SELECT OrderNumber, CustomerId, ShippingMethod, ShippingStatusId, OrderDate FROM [dbo].[Order] WHERE OrderNumber = {orderNumber} ";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL_SELECT, conn);
                cmd.Parameters.Add(new SqlParameter("@OrderNumber", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@CustomerId", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ShippingMethod", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ShippingStatusId", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime));
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                order.OrderNumber = rdr.GetInt32(0);
                order.CustomerId = rdr.GetInt32(1);
                order.ShippingMethod =  (ShippingMethod)rdr.GetInt32(2);
                order.ShippingStatus = (ShippingStatus)rdr.GetInt32(3);
            }
            return order;
        }

        public static List<Order> GetOrders()
        {
            var order = new Order();
            var orders = new List<Order>();
            var SQL_SELECT = $"SELECT OrderNumber, CustomerId, ShippingMethod, ShippingStatusId, OrderDate FROM [dbo].[Order] ";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL_SELECT, conn);
                cmd.Parameters.Add(new SqlParameter("@OrderNumber", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@CustomerId", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ShippingMethod", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ShippingStatusId", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    order.OrderNumber = rdr.GetInt32(0);
                    order.CustomerId = rdr.GetInt32(1);
                    order.ShippingMethod = (ShippingMethod)rdr.GetInt32(2);
                    order.ShippingStatus = (ShippingStatus)rdr.GetInt32(3);
                    orders.Add(order);
                }
            }
            return orders;
        }

        public static void UdpateOrder(Order order)
        {
            var SQL_UPDATE = "UPDATE [dbo].[Order] "
            + "SET ShippingMethodId = order.ShippingMethodId, ShippingStatusId = order.ShippingStatudId, "
            + "OrderDate = order.OrderDate "
            + "WHERE OrderNumber = order.OrderNumber";
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_UPDATE, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}


