using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dvd.Data.Model;
using Dvd.Business;
using Dvd.Data.Interfaces;

namespace WindowsFormsApplication1
{
    
    public partial class OrderEntryForm : Form
    {
        private Customer FormCustomer = new Customer();
        private Order FormOrder;

        IOrderDomain OrderDomain;

        public OrderEntryForm()
        {
            InitializeComponent();
            OrderDomain = new OrderDomain();
        }

        private void LoadCreditCards()
        {
            this.comboBoxCreditCard.Items.AddRange(new object[] {
            CreditCardCompany.Visa.ToString(),
            CreditCardCompany.MasterCard.ToString(),
            CreditCardCompany.Chase.ToString(),
            CreditCardCompany.AmericanExpress.ToString(),
            CreditCardCompany.Discover.ToString(),
            "-Select Credit Card-"
            });

            this.comboBoxCreditCard.SelectedIndex = 5;
        }

        private void OrderEntryForm_Load(object sender, System.EventArgs e)
        {
            LoadCreditCards();
            FormCustomer = new Customer();
            // Default values for customer if desired.

            //{Visa = 0, MasterCard = 1, Chase = 2, AmericanExpress = 3, Discover = 4 }
            var creditCardCompanies = new string[] {
                CreditCardCompany.Visa.ToString(),
                CreditCardCompany.MasterCard.ToString(),
                CreditCardCompany.Chase.ToString(),
                CreditCardCompany.AmericanExpress.ToString(),
                CreditCardCompany.Discover.ToString()
            };
            CreditCardListBox.Items.AddRange(creditCardCompanies);

            var shippingMethods = new string[] { "Ground", "First Class", "Two Day", "Overnight"};
            ShippingMethodListBox.Items.AddRange(shippingMethods);

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ProcessOrderForm();
        }

        private void ProcessOrderForm()
        {
            //I need to verify that strings are long enough, security code is an int, and that a card issuer is selected
            //I also need to make sure that at least one DVD is being ordered
            LoadCustomerData();
            LoadOrder();

            try
            {
                OrderDomain.CreateOrder(FormOrder);
            }
            catch (Exception ex)
            {
                var message = $"A problem happened when submitting the order. {ex.Message}";
                var caption = "Processing Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }
        private void LoadOrder()
        {
            FormOrder = new Order()
            {
                //Figure out how to get current highest row number in the orders table to determine order number
                //OrderNumber = currentHighestOrderNumber + 1;
                Customer = this.FormCustomer,
                ShippingMethod = (ShippingMethod)ShippingMethodListBox.SelectedIndex,
                ShippingStatus = ShippingStatus.NotYetShipped,
                OrderDate = DateTime.Today
            };
        }

        private void LoadCustomerData()
        {
            this.FormCustomer.FirstName = FirstNameTextBox.Text;
            this.FormCustomer.LastName = LastNameTextBox.Text;
            this.FormCustomer.PhoneNumber = PhoneNumberTextBox.Text;
            this.FormCustomer.EmailAddress = EmailAddressTextBox.Text;
            this.FormCustomer.MailingAddress = MailingAddressTextBox.Text;
            this.FormCustomer.BillingAddress = BillingAddressTextBox.Text;
            this.FormCustomer.CardIssuer = (CreditCardCompany)this.comboBoxCreditCard.SelectedIndex;
            this.FormCustomer.CreditCardNumber = CreditCardNumberTextBox.Text;
            this.FormCustomer.SecurityCode = int.Parse(SecurityCodeTextBox.Text);
        }

        private void comboBoxCreditCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FormCustomer.CardIssuer = (CreditCardCompany)this.comboBoxCreditCard.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to close the form?";
            const string caption = "This is a MessageBox";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Information);

            
        }
    }
}
