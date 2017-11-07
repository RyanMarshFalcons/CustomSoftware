using Dvd.Data.Model;
using Dvd.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dvd.UI
{
    public partial class ViewCustomerForm : Form
    {
        public ViewCustomerForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            ProcessViewCustomerForm();
        }

        private void ProcessViewCustomerForm()
        {
            if (!IsValidCustomerID(EnterCustomerIDTextBox.Text))
            {
                var message = "A valid customer ID was not entered";
                var caption = "Unable To View Customer";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var customerStore = new CustomerStore();
                var formCustomer = customerStore.GetCustomer(int.Parse(EnterCustomerIDTextBox.Text));
                DisplayCustomerInformation(formCustomer);
            }
        }

        private bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        private bool IsValidCustomerID(string input)
        {
            if (CheckIfInt(input) == false)
            {
                return false;
            }
            else
            {
                var customerID = int.Parse(input);
                var customerStore = new  CustomerStore();
                return customerStore.VerifyCustomerExists(customerID);
            }
        }

        private void DisplayCustomerInformation(Customer formCustomer)
        {
            CustomerNameTextBox.Text = formCustomer.FirstName + " " + formCustomer.LastName;
            PhoneNumberTextBox.Text = formCustomer.PhoneNumber;
            EmailAddressTextBox.Text = formCustomer.EmailAddress;
            MailingAddressTextBox.Text = formCustomer.MailingAddress;
            BillingAddressTextBox.Text = formCustomer.BillingAddress;
            CardIssuerTextBox.Text = formCustomer.CardIssuer.ToString();
            CreditCardNumberTextBox.Text = formCustomer.CreditCardNumber;
            SecurityCodeTextBox.Text = formCustomer.SecurityCode.ToString();
        }
    }
}
