using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dvd.Store;
using Dvd.Data;
using Dvd.Data.Model;
using System.Data.SqlClient;
using System.Data;

namespace TestDataLayer
{
    static class Program
    {
        private static CustomerStore _customerStore;
        private static OrderStore _orderStore;

        static void Main()
        {
            _customerStore = new CustomerStore();
            _orderStore = new OrderStore();

            Console.WriteLine("Enter your selection: \n1) Delete Customer\n2) Get Customer\n3) Get Customers\n4) Update Customer\n5) Delete Order\n6) Get Order\n7) Get Orders\n8) Update Order");
            var selection = Console.ReadLine();
            var customerID = 0;
            var orderNumber = 0;
            switch (selection)
            {
                case "1":
                    Console.Write("Enter the customer ID of the customer you want to delete: ");
                    customerID = int.Parse(Console.ReadLine());
                    DeleteCustomer(customerID);
                    break;
                case "2":
                    Console.Write("Enter the customer ID of the customer you want to get: ");
                    customerID = int.Parse(Console.ReadLine());
                    var customer = GetCustomer(customerID);
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
                    custUpdate.LastName = Console.ReadLine();
                    Console.Write("What is the phone number of the customer you want to update: ");
                    custUpdate.PhoneNumber = Console.ReadLine();
                    Console.Write("What is the email address of the customer you want to update: ");
                    custUpdate.EmailAddress = Console.ReadLine();
                    Console.Write("What is the mailing address of the customer you want to update: ");
                    custUpdate.MailingAddress = Console.ReadLine();
                    Console.Write("What is the billing address the customer you want to update: ");
                    custUpdate.BillingAddress = Console.ReadLine();
                    Console.Write("What is the ID number of the credit card issuer of the customer you want to update: ");
                    custUpdate.CardIssuer = (CreditCardCompany)int.Parse(Console.ReadLine());
                    Console.Write("What is the credit card number of the name of the customer you want to update: ");
                    custUpdate.CreditCardNumber = Console.ReadLine();
                    Console.Write("What is the security code of the customer you want to update: ");
                    custUpdate.SecurityCode = int.Parse(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Enter the order number of the order you want to delete: ");
                    orderNumber = int.Parse(Console.ReadLine());
                    DeleteOrder(orderNumber);
                    break;
                case "6":
                    Console.Write("Enter the order number of the order you want to get: ");
                    orderNumber = int.Parse(Console.ReadLine());
                    var order = GetOrder(orderNumber);
                    Console.WriteLine($"Order Number: {order.OrderNumber}");
                    Console.WriteLine($"Customer ID: {order.CustomerId}");
                    Console.WriteLine($"Shipping Method: {(ShippingMethod)(order.ShippingMethod)}");
                    Console.WriteLine($"Shipping Status: {(ShippingStatus)(order.ShippingStatus)}");
                    Console.WriteLine($"Order Date: {order.OrderDate}");
                    break;
                case "7":
                    var orders = GetOrders();
                    foreach (var ord in orders)
                    {
                        Console.WriteLine($"\nOrder Number: {ord.OrderNumber}");
                        Console.WriteLine($"Customer ID: {ord.CustomerId}");
                        Console.WriteLine($"Shipping Method: {(ShippingMethod)(ord.ShippingMethod)}");
                        Console.WriteLine($"Shipping Status: {(ShippingStatus)(ord.ShippingStatus)}");
                        Console.WriteLine($"Order Date: {ord.OrderDate}");
                    }
                    break;
                case "8":
                    var ordUpdate = new Order();
                    Console.Write("What is the order number of the order you want to update: ");
                    ordUpdate.OrderNumber = int.Parse(Console.ReadLine());
                    Console.Write("What is the customer ID of the order you want to update: ");
                    ordUpdate.CustomerId = int.Parse(Console.ReadLine());
                    Console.Write("What is the shipping method of the order you want to update: ");
                    ordUpdate.ShippingMethod = (ShippingMethod)(int.Parse(Console.ReadLine()));
                    Console.Write("What is the shipping status of the order you want to update: ");
                    ordUpdate.ShippingStatus = (ShippingStatus)(int.Parse(Console.ReadLine()));
                    Console.Write("What is the order date of the order you want to update: ");
                    ordUpdate.OrderDate = Convert.ToDateTime(Console.ReadLine());
                    break;
            }
            Console.ReadLine();
        }

        public static Customer GetCustomer(int customerNumber)
        {
            return _customerStore.GetCustomer(customerNumber);
        }

        public static List<Customer> GetCustomers()
        {
            return _customerStore.GetCustomers();
        }

        public static void UdpateCustomer(Customer customer)
        {
            _customerStore.UdpateCustomer(customer);
        }

        public static void DeleteCustomer(int customerId)
        {
            var rowsAffected = _customerStore.DeleteCustomer(customerId);
            Console.WriteLine($"There were {rowsAffected} rows deleted.");
        }

        public static void DeleteOrder(int orderNumber)
        {
            var rowsAffected = _orderStore.DeleteOrder(orderNumber);
            Console.WriteLine($"There were {rowsAffected} rows deleted.");
        }

        public static Order GetOrder(int orderNumber)
        {
            return _orderStore.GetOrder(orderNumber);
        }

        public static List<Order> GetOrders()
        {
            return _orderStore.GetOrders();
        }

        public static void UdpateOrder(Order order)
        {
            _orderStore.UdpateOrder(order);
        }
    }
}


