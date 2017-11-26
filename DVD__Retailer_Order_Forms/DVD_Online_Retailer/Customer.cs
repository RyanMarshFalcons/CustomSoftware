using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Online_Retailer
{
    public enum CreditCardCompany {Visa, MasterCard, Chase, AmericanExpress, Discover };
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string MailingAddress { get; set; }
        public string BillingAddress { get; set; }
        public CreditCardCompany CardIssuer { get; set; }
        public string CreditCardNumber { get; set; }
        public int SecurityCode { get; set; }
    }
}
