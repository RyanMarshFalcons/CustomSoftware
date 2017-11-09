using System;
using Dvd.Data.Interfaces;
using Dvd.Data.Model;
using Dvd.Store;
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
    public partial class UpdateOrderForm : Form
    {
        private Order FormOrder = new Order();
        private Customer FormCustomer = new Customer();
        ICustomerDomain CustomerDomain;
        IOrderDomain OrderDomain;

        public UpdateOrderForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            LookUpOrderNumber();
        }

        private void LookUpOrderNumber()
        {
            if (!IsValidOrderNumber(EnterOrderNumberTextBox.Text))
            {
                var message = "A valid Order Number was not entered";
                var caption = "Unable To View Order You Want To Update";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var orderStore = new OrderStore();
                var customerStore = new CustomerStore();
                FormOrder = orderStore.GetOrder(int.Parse(EnterOrderNumberTextBox.Text));
                FormCustomer = customerStore.GetCustomer(FormOrder.CustomerId);
                DisplayOrderInformation();
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

        private void DisplayOrderInformation()
        {
            FirstNameTextBox.Text = FormCustomer.FirstName;
            LastNameTextBox.Text = FormCustomer.LastName;
            CustomerIDTextBox.Text = FormOrder.CustomerId.ToString();
            MailingAddressTextBox.Text = FormCustomer.MailingAddress;
            OrderDateTextBox.Text = FormOrder.OrderDate.ToString();
            OrderTotalTextBox.Text = FormOrder.OrderTotal.ToString();

            LoadShippingMethods();
            LoadShippingStatuses();
        }

        private void LoadShippingMethods()
        {
            ShippingMethodComboBox.Items.AddRange(new object[] {
            ShippingMethod.Ground.ToString(),
            ShippingMethod.FirstClass.ToString(),
            ShippingMethod.TwoDay.ToString(),
            ShippingMethod.Overnight.ToString(),
            });

            ShippingMethodComboBox.SelectedIndex = (int)FormOrder.ShippingMethod;
        }

        private void LoadShippingStatuses()
        {
            ShippingStatusComboBox.Items.AddRange(new object[] {
            ShippingStatus.NotYetShipped.ToString(),
            ShippingStatus.Shipped.ToString(),
            ShippingStatus.Delivered.ToString(),
            ShippingStatus.Lost.ToString(),
            ShippingStatus.BackOrdered.ToString()
            });

            ShippingStatusComboBox.SelectedIndex = (int)FormOrder.ShippingStatus;
        }

        private void UpdateOrderInformation()
        {
            var allFormFieldsValid = true;

            if (IsEmptyString(FirstNameTextBox.Text))
            {
                FirstNameLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                FirstNameLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(LastNameTextBox.Text))
            {
                LastNameLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                LastNameLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(LastNameTextBox.Text))
            {
                LastNameLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                LastNameLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(MailingAddressTextBox.Text))
            {
                MailingAddressLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                MailingAddressLabel.ForeColor = Color.Black;
            }

            

            if (ShippingMethodComboBox.SelectedIndex >= 0 && ShippingMethodComboBox.SelectedIndex <= 3)
            {
                ShippingMethodLabel.ForeColor = Color.Black;
            }
            else
            {
                ShippingMethodLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (ShippingStatusComboBox.SelectedIndex >= 0 && ShippingStatusComboBox.SelectedIndex <= 4)
            {
                ShippingStatusLabel.ForeColor = Color.Black;
            }
            else
            {
                ShippingStatusLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (!allFormFieldsValid)
            {
                var message = "Not all of the required fields were filled out correctly";
                var caption = "Unable To Update Order";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                LoadCustomerData();
                LoadOrder();

                try
                {
                    OrderDomain.CreateOrder(FormOrder);
                }
                catch (Exception ex)
                {
                    var message = $"A problem happened when updating the order. {ex.Message}";
                    var caption = "Processing Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }
        }

        private bool IsEmptyString(string userInput)
        {
            return userInput.Length == 0;
        }

        private void LoadOrder()
        {
            FormOrder.ShippingMethod = (ShippingMethod)ShippingMethodComboBox.SelectedIndex;
            FormOrder.ShippingStatus = (ShippingStatus)ShippingStatusComboBox.SelectedIndex;
        }

        private void LoadCustomerData()
        {
            FormCustomer.FirstName = FirstNameTextBox.Text;
            FormCustomer.LastName = LastNameTextBox.Text;
            FormCustomer.MailingAddress = MailingAddressTextBox.Text;
        }
    }
}
