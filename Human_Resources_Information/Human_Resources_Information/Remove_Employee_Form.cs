using Human_Resources_Information.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Resources_Information
{
    public partial class Remove_Employee_Form : Form
    {
        public Remove_Employee_Form()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            ProcessRemoveEmployeeForm();
        }

        private void ProcessRemoveEmployeeForm()
        {
            if (!IsValidEmployeeID(EnterEmployeeIDTextBox.Text))
            {
                const string message = "A valid Employee ID was not entered";
                const string caption = "Unable To Delete Employee";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                var employeeStore = new EmployeeStore();
                var formEmployee = employeeStore.DeleteEmployee(int.Parse(EnterEmployeeIDTextBox.Text));

                var message = $"Employee ID {EnterEmployeeIDTextBox.Text} has been deleted";
                var caption = "Employee Successfully Deleted";
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

        private bool IsValidEmployeeID(string input)
        {
            if (CheckIfInt(input) == false)
            {
                return false;
            }
            else
            {
                var employeeID = int.Parse(input);
                var employeeStore = new EmployeeStore();
                return employeeStore.VerifyEmployeeExists(employeeID);
            }
        }
    }
}
