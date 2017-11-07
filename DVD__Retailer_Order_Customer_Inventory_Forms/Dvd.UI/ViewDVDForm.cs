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
    public partial class ViewDVDForm : Form
    {
        public ViewDVDForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessViewDVDForm();
        }

        private void ProcessViewDVDForm()
        {
            if (!IsValidDVD_ID(EnterDVDIDTextBox.Text))
            {
                var message = "A valid DVD ID was not entered";
                var caption = "Unable To View DVD";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var dvdStore = new DvdStore();
                var formDVD = dvdStore.GetDVD(int.Parse(EnterDVDIDTextBox.Text));
                DisplayDVDInformation(formDVD);
            }
        }

        private bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        private bool IsValidDVD_ID(string input)
        {
            if (CheckIfInt(input) == false)
            {
                return false;
            }
            else
            {
                var dvdID = int.Parse(input);
                var dvdStore = new DvdStore();
                return dvdStore.VerifDVDExists(dvdID);
            }
        }

        private void DisplayDVDInformation(DVD formDVD)
        {
            TitleTextBox.Text = formDVD.Title;
            GenreTextBox.Text = formDVD.Genre.ToString();
            QuantityInStockTextBox.Text = formDVD.QuantityInStock.ToString();
            SalesPriceTextBox.Text = formDVD.SalesPrice.ToString();
            PurchasePriceTextBox.Text = formDVD.PurchasePrice.ToString();
        }
    }
}
