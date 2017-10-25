using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DVD_Online_Retailer;


namespace StartUp
{
    public class Program 
    {
        static void Main(string[] args)
        {
            using (var db = new OrderContext())
            {
                Console.Write("Enter the Order Number: ");
                var orderNumber = Console.ReadLine();
                Console.Write("Enter the Order Item Number: ");
                var orderItemNumber = Console.ReadLine();
                Console.Write("Enter the DVD ID Number: ");
                var DVD_ID_Number = Console.ReadLine();
                Console.Write("Enter the Quantity: ");
                var quantity = Console.ReadLine();

                var orderItem = new OrderItem
                                        {
                                            OrderNumber = int.Parse(orderNumber),
                                            OrderItemNumber = int.Parse(orderItemNumber),
                                            DVD_ID = int.Parse(DVD_ID_Number),
                                            Quantity = int.Parse(quantity)
                                        };
                db.OrderItems.Add(orderItem);
                db.SaveChanges();

                var query = from i in db.OrderItems
                            orderby i.OrderItemNumber
                            select i;

                Console.WriteLine("All order number items in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.OrderItemNumber);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
