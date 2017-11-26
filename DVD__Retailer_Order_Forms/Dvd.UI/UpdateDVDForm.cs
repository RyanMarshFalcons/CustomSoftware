using Dvd.Data.Interfaces;
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
    public partial class UpdateDVDForm : Form
    {
        private DVD FormDVD = new DVD();
        IDvdDomain DVDDomain;
        public UpdateDVDForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            LookUpDvdID();
        }

        private void LookUpDvdID()
        {
            if (!IsValidDVD_ID(EnterDVDIDTextBox.Text))
            {
                var message = "A valid DVD ID was not entered";
                var caption = "Unable To View DVD You Want To Update";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var dvdStore = new DvdStore();
                FormDVD = dvdStore.GetDVD(int.Parse(EnterDVDIDTextBox.Text));
                DisplayDVDInformation();
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

        private void DisplayDVDInformation()
        {
            TitleTextBox.Text = FormDVD.Title;
            QuantityTextBox.Text = FormDVD.QuantityInStock.ToString();
            SalesPriceTextBox.Text = FormDVD.SalesPrice.ToString();
            PurchasePriceTextBox.Text = FormDVD.PurchasePrice.ToString();
            LoadGenres();
            UpdateDVDInformation();
        }

        private void LoadGenres()
        {
            GenreComboBox.Items.AddRange(new object[] {
            MovieGenre.Action.ToString(),
            MovieGenre.Comedy.ToString(),
            MovieGenre.Documentary.ToString(),
            MovieGenre.Drama.ToString(),
            MovieGenre.Family.ToString(),
            MovieGenre.Horror.ToString(),
            MovieGenre.Mystery.ToString(),
            MovieGenre.Thriller.ToString(),
            MovieGenre.War.ToString(),
            MovieGenre.Western.ToString(),
            });

            GenreComboBox.SelectedIndex = (int)FormDVD.Genre;
        }

        private void UpdateDVDInformation()
        {
            var allFormFieldsValid = true;

            if (IsEmptyString(TitleTextBox.Text))
            {
                TitleLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                TitleLabel.ForeColor = Color.Black;
            }

            if (!IsInt(QuantityTextBox.Text))
            {
                QuantityLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                QuantityLabel.ForeColor = Color.Black;
            }

            if (!IsPositiveDecimal(SalesPriceTextBox.Text))
            {
                SalesPriceLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                SalesPriceLabel.ForeColor = Color.Black;
            }

            if (!IsPositiveDecimal(PurchasePriceTextBox.Text))
            {
                PurchasePriceLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                PurchasePriceLabel.ForeColor = Color.Black;
            }

            if (GenreComboBox.SelectedIndex >= 0 && GenreComboBox.SelectedIndex <= 9)
            {
                GenreLabel.ForeColor = Color.Black;
            }
            else
            {
                GenreLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (!allFormFieldsValid)
            {
                var message = "Not all of the required fields were filled out correctly";
                var caption = "Unable To Update DVD";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                LoadDVDData();

                try
                {
                    DVDDomain.UpdateDVD(FormDVD);
                }
                catch (Exception ex)
                {
                    var message = $"A problem happened when updateing the customer. {ex.Message}";
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

        private bool IsInt(string userInput)
        {
            var result = 0;
            return int.TryParse(userInput, out result);
        }

        private bool IsPositiveDecimal(string userInput)
        {
            var result = 0.0M;
            if (decimal.TryParse(userInput, out result))
            {
                return result > 0.0M;
            }
            else
            {
                return false;
            }
        }

        private void LoadDVDData()
        {
            FormDVD.Title = TitleTextBox.Text;
            FormDVD.Genre = (MovieGenre)GenreComboBox.SelectedIndex;
            FormDVD.QuantityInStock = int.Parse(QuantityTextBox.Text);
            FormDVD.SalesPrice = decimal.Parse(SalesPriceTextBox.Text);
            FormDVD.PurchasePrice = decimal.Parse(PurchasePriceTextBox.Text);
            FormDVD.IsDeleted = false;
        }
    }
}

