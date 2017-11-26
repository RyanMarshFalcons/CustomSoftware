using Dvd.Data.Model;
using Dvd.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dvd.UI
{
    public partial class ViewAllCustomersForm : Form
    {
        public ViewAllCustomersForm()
        {
            InitializeComponent();
            ProcessViewAllCustomersForm();
        }

        private void ProcessViewAllCustomersForm()
        {
            var selectAllValidRows = "SELECT * FROM [dbo].[Customer] WHERE IsDeleted = 0 ";
            var dataAdapter = new SqlDataAdapter(selectAllValidRows, DatabaseHelper.GetConnection());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
