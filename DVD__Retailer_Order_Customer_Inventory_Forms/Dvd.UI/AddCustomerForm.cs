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

        private void CreditCardIssuerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
