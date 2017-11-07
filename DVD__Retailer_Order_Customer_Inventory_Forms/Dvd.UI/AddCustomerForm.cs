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

namespace Dvd.UI
{
    public partial class AddCustomerForm : Form
    {
        private Customer FormCustomer = new Customer();
        ICustomerDomain CustomerDomain;

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, System.EventArgs e)
        {
            LoadCreditCards();
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

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            ProcessAddCustomerForm();
        }

        private void ProcessAddCustomerForm()
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

                try
                {
                    CustomerDomain.AddCustomer(FormCustomer);
                }
                catch (Exception ex)
                {
                    var message = $"A problem happened when adding the customer. {ex.Message}";
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
            if (int.TryParse(userInput, out result))
            {
                return result > 0;
            }
            else
            {
                return false;
            }
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
    }
}
