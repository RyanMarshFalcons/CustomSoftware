using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Dvd.Data.Model;
using Dvd.Business;
using Dvd.Data.Interfaces;

namespace Dvd.UI
{
    public partial class NewOrderForm : Form
    {
        private Customer FormCustomer = new Customer();
        private Order FormOrder = new Order();
        IOrderDomain OrderDomain;
        private List<OrderItem> dvdsOrdered = new List<OrderItem>();

        public NewOrderForm()
        {
            InitializeComponent();
            OrderDomain = new OrderDomain();
        }

        private void OrderEntryForm_Load(object sender, System.EventArgs e)
        {
            LoadCreditCards();
            LoadShippingMethods();
        }

        private void LoadCreditCards()
        {
            CreditCardIssuerComboBox.Items.AddRange(new object[] {
            CreditCardCompany.Visa.ToString(),
            CreditCardCompany.MasterCard.ToString(),
            CreditCardCompany.Chase.ToString(),
            CreditCardCompany.AmericanExpress.ToString(),
            CreditCardCompany.Discover.ToString(),
            "-Select Credit Card Issuer-"
            });

            CreditCardIssuerComboBox.SelectedIndex = 5;
        }

        private void LoadShippingMethods()
        {
            ShippingMethodComboBox.Items.AddRange(new object[] {
            ShippingMethod.Ground.ToString(),
            ShippingMethod.FirstClass.ToString(),
            ShippingMethod.TwoDay.ToString(),
            ShippingMethod.Overnight.ToString(),
            "-Select Shipping Method-"
            });

            ShippingMethodComboBox.SelectedIndex = 4;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ProcessNewOrderForm();
        }

        private void ProcessNewOrderForm()
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

            if (IsEmptyString(PhoneNumberTextBox.Text))
            {
                PhoneNumberLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                PhoneNumberLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(EmailAddressTextBox.Text))
            {
                EmailAddressLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                EmailAddressLabel.ForeColor = Color.Black;
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

            if (IsEmptyString(BillingAddressTextBox.Text))
            {
                BillingAddressLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                BillingAddressLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(CreditCardNumberTextBox.Text))
            {
                CreditCardNumberLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                CreditCardNumberLabel.ForeColor = Color.Black;
            }

            if (!IsThreeDigitInt(SecurityCodeTextBox.Text))
            {
                SecurityCodeLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                SecurityCodeLabel.ForeColor = Color.Black;
            }

            if (CreditCardIssuerComboBox.SelectedIndex >= 0 && CreditCardIssuerComboBox.SelectedIndex <= 4)
            {
                CreditCardIssuerLabel.ForeColor = Color.Black;
            }
            else
            {
                CreditCardIssuerLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
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

            if (dvdsOrdered.Count == 0)
            {
                DVDIDLabel.ForeColor = Color.Red;
                QuantityLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                DVDIDLabel.ForeColor = Color.Black;
                QuantityLabel.ForeColor = Color.Black;
            }

            if (!allFormFieldsValid)
            {
                var message = "Not all of the required fields were filled out correctly";
                var caption = "Unable To Submit Order";
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
                    var message = $"A problem happened when submitting the order. {ex.Message}";
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

        private bool IsThreeDigitInt(string userInput)
        {
            return IsThreeDigits(userInput) && IsPositiveInt(userInput);
        }

        private bool IsThreeDigits(string userInput)
        {
            return userInput.Length == 3;
        }

        private bool IsPositiveInt(string userInput)
        {
            var result = 0;
            if(int.TryParse(userInput, out result))
            {
                return result > 0;
            }
            else
            {
                return false;
            }
        }
        
        private void LoadOrder()
        {
            FormOrder = new Order()
            {
                Customer = FormCustomer,
                ShippingMethod = (ShippingMethod)ShippingMethodComboBox.SelectedIndex,
                ShippingStatus = ShippingStatus.NotYetShipped,
                OrderDate = DateTime.Today,
                IsDeleted = false
            };
        }

        private void LoadCustomerData()
        {
            FormCustomer.FirstName = FirstNameTextBox.Text;
            FormCustomer.LastName = LastNameTextBox.Text;
            FormCustomer.PhoneNumber = PhoneNumberTextBox.Text;
            FormCustomer.EmailAddress = EmailAddressTextBox.Text;
            FormCustomer.MailingAddress = MailingAddressTextBox.Text;
            FormCustomer.BillingAddress = BillingAddressTextBox.Text;
            FormCustomer.CardIssuer = (CreditCardCompany)CreditCardIssuerComboBox.SelectedIndex;
            FormCustomer.CreditCardNumber = CreditCardNumberTextBox.Text;
            FormCustomer.SecurityCode = int.Parse(SecurityCodeTextBox.Text);
            FormCustomer.IsDeleted = false;
        }

        private void AddDVDButton_Click(object sender, EventArgs e)
        {
            ProcessAddingDVDToOrder();
        }

        private void ProcessAddingDVDToOrder()
        {
            if (IsValidDVDId(DVDIDTextBox.Text) && IsPositiveInt(QuantityTextBox.Text))
            {
                var dvdOrdered = new OrderItem() { DVD_ID = int.Parse(DVDIDTextBox.Text), Quantity = int.Parse(QuantityTextBox.Text) };
                dvdsOrdered.Add(dvdOrdered);
                DVDIDLabel.ForeColor = Color.Black;
                QuantityLabel.ForeColor = Color.Black;
                DVDIDTextBox.Text = "";
                QuantityTextBox.Text = "";
                //Add logic in that adds the price * quantity of dvds to total order price displayed on form
            }
            else
            {
                var message = "Invalid DVD ID and Quantity input";
                var caption = "Unable To Add DVD To Order";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                DVDIDLabel.ForeColor = Color.Red;
                QuantityLabel.ForeColor = Color.Red;

            }
        }

        //Need to create a table of DVDs with ID numbers and check that it exists
        private bool IsValidDVDId(string dvdIDtextboxtext)
        {
            return true;
        }
    }
}
