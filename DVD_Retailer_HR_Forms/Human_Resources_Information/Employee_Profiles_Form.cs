using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Human_Resources_Information.Data;
using System.Data.SqlClient;
using Human_Resources_Information.Store;

namespace Human_Resources_Information
{
    public partial class Employee_Profiles_Form : Form
    {
        public Employee_Profiles_Form()
        {
            InitializeComponent();
            ProcessEmployeeProfilesForm();
        }

        private void ProcessEmployeeProfilesForm()
        {
            var employeeStore = new Store.EmployeeStore();
            var selectAllValidRows = "SELECT * FROM [dbo].[Employee] WHERE IsDeleted = 0 ";
            var dataAdapter = new SqlDataAdapter(selectAllValidRows, DatabaseHelper.GetConnection());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void SortByFirstNameButton_Click(object sender, EventArgs e)
        {
            var employeeStore = new Store.EmployeeStore();
            var selectAllValidRows = "SELECT * FROM [dbo].[Employee] WHERE IsDeleted = 0 ORDER BY FirstName ";
            var dataAdapter = new SqlDataAdapter(selectAllValidRows, DatabaseHelper.GetConnection());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void SortByLastNameButton_Click(object sender, EventArgs e)
        {
            var employeeStore = new Store.EmployeeStore();
            var selectAllValidRows = "SELECT * FROM [dbo].[Employee] WHERE IsDeleted = 0 ORDER BY LastName ";
            var dataAdapter = new SqlDataAdapter(selectAllValidRows, DatabaseHelper.GetConnection());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void SortByDepartmentButton_Click(object sender, EventArgs e)
        {
            var employeeStore = new Store.EmployeeStore();
            var selectAllValidRows = "SELECT * FROM [dbo].[Employee] WHERE IsDeleted = 0 ORDER BY Department ";
            var dataAdapter = new SqlDataAdapter(selectAllValidRows, DatabaseHelper.GetConnection());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void SortByHireDateButton_Click(object sender, EventArgs e)
        {
            var employeeStore = new Store.EmployeeStore();
            var selectAllValidRows = "SELECT * FROM [dbo].[Employee] WHERE IsDeleted = 0 ORDER BY HireDate ";
            var dataAdapter = new SqlDataAdapter(selectAllValidRows, DatabaseHelper.GetConnection());
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
