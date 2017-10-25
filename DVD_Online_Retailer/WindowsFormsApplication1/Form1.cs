using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OrderEntryForm : Form
    {
        public OrderEntryForm()
        {
            InitializeComponent();
        }

        private void OrderEntryForm_Load(object sender, System.EventArgs e)
        {
            var creditCardCompanies = new string[] { "Visa", "MasterCard", "Chase", "American Express", "Discover" };
            CreditCardListBox.Items.AddRange(creditCardCompanies);

            var shippingMethods = new string[] { "Ground", "First Class", "Two Day", "Overnight"};
            ShippingMethodListBox.Items.AddRange(shippingMethods);

        }

        
    }
}
