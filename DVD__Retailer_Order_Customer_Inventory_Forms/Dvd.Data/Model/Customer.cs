using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvd.Data.Model
{
    public enum CreditCardCompany {Visa = 0, MasterCard = 1, Chase = 2, AmericanExpress = 3, Discover = 4 };
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string MailingAddress { get; set; }
        public string BillingAddress { get; set; }
        public CreditCardCompany CardIssuer { get; set; }
        public string CreditCardNumber { get; set; }
        public int SecurityCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
