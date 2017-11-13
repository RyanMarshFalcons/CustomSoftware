using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Information.Data
{
    public enum Department { Accounting, Customer_Service, Human_Resources, Information_Technology, Manufacturing, Marketing, Product_Development, Sales}
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public string JobTitle { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsDeleted { get; set; }
    }
}
