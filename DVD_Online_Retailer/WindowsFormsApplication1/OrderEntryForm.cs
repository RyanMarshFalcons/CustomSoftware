using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVD_Online_Retailer;

namespace WindowsFormsApplication1
{
    public partial class OrderEntryForm : Form
    {
        public OrderEntryForm()
        {
            InitializeComponent();
        }

        private void OrderEntryForm_Load(object sender, System.EventArgs e)
        {
            var creditCardCompanies = new string[] { "Visa", "MasterCard", "Chase", "American Express", "Discover" };
            CreditCardListBox.Items.AddRange(creditCardCompanies);

            var shippingMethods = new string[] { "Ground", "First Class", "Two Day", "Overnight"};
            ShippingMethodListBox.Items.AddRange(shippingMethods);

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //I need to verify that strings are long enough, security code is an int, and that a card issuer is selected
            //I also need to make sure that at least one DVD is being ordered
            var customer = new Customer()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                EmailAddress = EmailAddressTextBox.Text,
                MailingAddress = MailingAddressTextBox.Text,
                BillingAddress = BillingAddressTextBox.Text,
                CardIssuer = (CreditCardCompany)CreditCardListBox.SelectedIndex,
                CreditCardNumber = CreditCardNumberTextBox.Text,
                SecurityCode = int.Parse(SecurityCodeTextBox.Text)
            };

            var order = new Order()
            {
                //Figure out how to get current highest row number in the orders table to determine order number
                //OrderNumber = currentHighestOrderNumber + 1;
                Customer = customer,
                ShippingMethod = (ShippingMethod)ShippingMethodListBox.SelectedIndex,
                ShippingStatus = ShippingStatus.NotYetShipped,
                OrderDate = DateTime.Today
            };

        }
    }
}
