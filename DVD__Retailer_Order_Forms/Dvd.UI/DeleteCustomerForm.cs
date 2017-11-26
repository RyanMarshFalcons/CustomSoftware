using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Dvd.Data.Model;
using Dvd.Business;
using Dvd.Data.Interfaces;
using Dvd.Store;

namespace Dvd.UI
{
    public partial class DeleteCustomerForm : Form
    {
        private Customer FormCustomer = new Customer();
        public DeleteCustomerForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            ProcessDeleteCustomerForm();
        }

        private void ProcessDeleteCustomerForm()
        {
            if (!IsValidCustomerID(EnterCustomerIDTextBox.Text))
            {
                const string message = "A valid customer ID was not entered";
                const string caption = "Unable To Delete Customer";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var customerStore = new CustomerStore();
                var formCustomer = customerStore.DeleteCustomer(int.Parse(EnterCustomerIDTextBox.Text));

                var message = $"Customer ID {EnterCustomerIDTextBox.Text} has been deleted";
                var caption = "Customer Successfully Deleted";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
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
                var customerStore = new CustomerStore();
                return customerStore.VerifyCustomerExists(customerID);
            }
        }
    }
}
