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
    public partial class AddDVDForm : Form
    {
        public AddDVDForm()
        {
            InitializeComponent();

        }

        private void AddInventoryForm_Load_1(object sender, EventArgs e)
        {
            LoadGenres();
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
            "-Select Movie Genre-"
            });

            GenreComboBox.SelectedIndex = 10;
        }
    }
}
