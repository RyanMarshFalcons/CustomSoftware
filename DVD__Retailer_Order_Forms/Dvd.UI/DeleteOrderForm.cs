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
    public partial class DeleteOrderForm : Form
    {
        private Order FormOrder = new Order();

        public DeleteOrderForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            ProcessDeleteOrderForm();
        }

        private void ProcessDeleteOrderForm()
        {
            if (!IsValidOrderNumber(EnterOrderNumberTextBox.Text))
            {
                const string message = "A valid order number was not entered";
                const string caption = "Unable To Delete Order";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var orderStore = new OrderStore();
                var formOrder = orderStore.DeleteOrder(int.Parse(EnterOrderNumberTextBox.Text));

                var message = $"Order number {EnterOrderNumberTextBox.Text} has been deleted";
                var caption = "Order Successfully Deleted";
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
    }
}
