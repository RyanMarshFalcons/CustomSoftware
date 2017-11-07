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
    public partial class DeleteDVDForm : Form
    {
        private DVD FormDVD = new DVD();
        public DeleteDVDForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            ProcessDeleteDVDForm();
        }

        private void ProcessDeleteDVDForm()
        {
            if (!IsValidDVDID(EnterDVDIDTextBox.Text))
            {
                const string message = "A valid DVD ID was not entered";
                const string caption = "Unable To Delete DVD";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var dvdStore = new DvdStore();
                var formDVD = dvdStore.DeleteDVD(int.Parse(EnterDVDIDTextBox.Text));

                var message = $"DVD ID {EnterDVDIDTextBox.Text} has been deleted";
                var caption = "DVD Successfully Deleted";
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

        private bool IsValidDVDID(string input)
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
    }
}
