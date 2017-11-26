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
    public partial class UpdateCustomerForm : Form
    {
        private Customer FormCustomer = new Customer();
        ICustomerDomain CustomerDomain;
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            LookUpCustomerID();
        }

        private void LookUpCustomerID()
        {
            if (!IsValidCustomerID(EnterCustomerIDTextBox.Text))
            {
                var message = "A valid Customer ID was not entered";
                var caption = "Unable To View Customer You Want To Update";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var customerStore = new CustomerStore();
                FormCustomer = customerStore.GetCustomer(int.Parse(EnterCustomerIDTextBox.Text));
                DisplayCustomerInformation();
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

        private void DisplayCustomerInformation()
        {
            FirstNameTextBox.Text = FormCustomer.FirstName;
            LastNameTextBox.Text = FormCustomer.LastName;
            PhoneNumberTextBox.Text = FormCustomer.PhoneNumber;
            EmailAddressTextBox.Text = FormCustomer.EmailAddress;
            MailingAddressTextBox.Text = FormCustomer.MailingAddress;
            BillingAddressTextBox.Text = FormCustomer.BillingAddress;
            CreditCardNumberTextBox.Text = FormCustomer.CreditCardNumber;
            SecurityCodeTextBox.Text = FormCustomer.SecurityCode.ToString();
            LoadCreditCardCompanies();

        }

        private void LoadCreditCardCompanies()
        {
            CardIssuerComboBox.Items.AddRange(new object[] {
            CreditCardCompany.Visa.ToString(),
            CreditCardCompany.MasterCard.ToString(),
            CreditCardCompany.Chase.ToString(),
            CreditCardCompany.AmericanExpress.ToString(),
            CreditCardCompany.Discover.ToString(),
            });

            CardIssuerComboBox.SelectedIndex = (int)FormCustomer.CardIssuer;
        }

        private void UpdateCustomerInformation()
        {
            var allFormFieldsValid = true;

            if (IsEmptyString(FirstNameTextBox.Text))
            {
                FirstName_Label.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                FirstName_Label.ForeColor = Color.Black;
            }

            if (IsEmptyString(LastNameTextBox.Text))
            {
                LastName_Label.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                LastName_Label.ForeColor = Color.Black;
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

            if (CardIssuerComboBox.SelectedIndex >= 0 && CardIssuerComboBox.SelectedIndex <= 4)
            {
                CardIssuerLabel.ForeColor = Color.Black;
            }
            else
            {
                CardIssuerLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (!allFormFieldsValid)
            {
                var message = "Not all of the required fields were filled out correctly";
                var caption = "Unable To Update Customer";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                LoadCustomerData();

                try
                {
                    CustomerDomain.UpdateCustomer(FormCustomer);
                }
                catch (Exception ex)
                {
                    var message = $"A problem happened when updating the customer. {ex.Message}";
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
            FormCustomer.CardIssuer = (CreditCardCompany)CardIssuerComboBox.SelectedIndex;
            FormCustomer.CreditCardNumber = CreditCardNumberTextBox.Text;
            FormCustomer.SecurityCode = int.Parse(SecurityCodeTextBox.Text);
            FormCustomer.IsDeleted = false;
        }
    }
}
