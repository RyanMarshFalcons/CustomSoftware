using Dvd.Data.Interfaces;
using Dvd.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dvd.Business;
using Dvd.Data;
using Dvd.Store;

namespace Dvd.UI
{
    public partial class ViewOrderForm : Form
    {
        public ViewOrderForm()
        {
            InitializeComponent();
        }

        private void OrderStatusForm_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            ProcessViewOrderForm();
        }

        private void ProcessViewOrderForm()
        {
            if (!IsValidOrderNumber(EnterOrderNumberTextBox.Text))
            {
                var message = "A valid order number was not entered";
                var caption = "Unable To View Order";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var orderStore = new OrderStore();
                var customerStore = new CustomerStore();
                var formOrder = orderStore.GetOrder(int.Parse(EnterOrderNumberTextBox.Text));
                var formCustomer = customerStore.GetCustomer(formOrder.CustomerId);
                DisplayOrderInformation(formOrder, formCustomer);
            }
        }

        private bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        private bool IsValidOrderNumber(string input)
        {
            if (CheckIfInt(input) == false)
            {
                return false;
            }
            else
            {
                var orderNumber = int.Parse(input);
                var orderStore = new OrderStore();
                return orderStore.VerifyOrderExists(orderNumber);
            }
        }

        private void DisplayOrderInformation(Order formOrder, Customer formCustomer)
        {
            CustomerNameTextBox.Text = formCustomer.FirstName + " " + formCustomer.LastName;
            CustomerIDTextbox.Text = formCustomer.CustomerId.ToString();
            MailingAddressTextBox.Text = formCustomer.MailingAddress;
            ShippingMethodTextBox.Text = formOrder.ShippingMethod.ToString();
            ShippingStatusTextBox.Text = formOrder.ShippingStatus.ToString();
            OrderDateTextBox.Text = formOrder.OrderDate.ToString();
            OrderTotalTextBox.Text = formOrder.OrderTotal.ToString();
        }
    }
}
