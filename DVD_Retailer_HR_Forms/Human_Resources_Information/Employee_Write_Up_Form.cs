using Human_Resources_Information.Data;
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
    public partial class Employee_Write_Up_Form : Form
    {
        Employee FormEmployee = new Employee();
        public Employee_Write_Up_Form()
        {
            InitializeComponent();
        }

        private void Employee_Evaluation_Form_Load(object sender, System.EventArgs e)
        {
            LoadReasons();
        }

        private void LoadReasons()
        {
            ReasonForWriteUpComboBox.Items.AddRange(new object[] {
            "Attendance",
            "Conduct",
            "Failure To Follow Instructions",
            "Insubordiantion",
            "Performance",
            "Quality Of Work",
            "Safety",
            "Tardiness",
            "-Select Reason For WriteUp-"
            });

            ReasonForWriteUpComboBox.SelectedIndex = 8;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ProcessEmployeeWriteUpForm();
        }

        private void ProcessEmployeeWriteUpForm()
        {
            var allFormFieldsValid = true;

            if (IsEmptyString(EmployeeNameTextBox.Text))
            {
                EmployeeNameLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                EmployeeNameLabel.ForeColor = Color.Black;
            }

            if (IsValidEmployeeID(EmployeeIDTextBox.Text))
            {
                EmployeeIDLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                EmployeeIDLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(SupervisorNameTextBox.Text))
            {
                SupervisorNameLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                SupervisorNameLabel.ForeColor = Color.Black;
            }

            if (ReasonForWriteUpComboBox.SelectedIndex >= 0 && ReasonForWriteUpComboBox.SelectedIndex <= 7)
            {
                ReasonForWriteUpLabel.ForeColor = Color.Black;
            }
            else
            {
                ReasonForWriteUpLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (IsEmptyString(DetailsOfIncidentTextBox.Text))
            {
                DetailsOfIncidentLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                DetailsOfIncidentLabel.ForeColor = Color.Black;
            }

            if (!allFormFieldsValid)
            {
                var message = "Not all of the required fields were filled out correctly";
                var caption = "Unable To Submit Transfer Request";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    var employeeStore = new EmployeeStore();
                    FormEmployee = employeeStore.GetEmployee(int.Parse(EmployeeIDTextBox.Text));
                    FormEmployee.NumberOfWriteups++;
                    employeeStore.UpdateWriteUp(FormEmployee);
                }
                catch (Exception ex)
                {
                    var message = $"A problem happened when submitting the write up {ex.Message}";
                    var caption = "Processing Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidEmployeeID(string userInput)
        {
            if (CheckIfInt(userInput) == false)
            {
                return false;
            }
            else
            {
                var employeeID = int.Parse(userInput);
                var employeeStore = new EmployeeStore();
                return employeeStore.VerifyEmployeeExists(employeeID);
            }
        }

        private bool CheckIfInt(string userInput)
        {
            var result = 0;
            return int.TryParse(userInput, out result);
        }

        private bool IsEmptyString(string userInput)
        {
            return userInput.Length == 0;
        }
    }
}
