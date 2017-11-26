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
    public partial class Department_Transfer_Request_Form : Form
    {
        Employee FormEmployee = new Employee();
        public Department_Transfer_Request_Form()
        {
            InitializeComponent();
        }

        private void Employee_Evaluation_Form_Load(object sender, System.EventArgs e)
        {
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            NewDepartmentComboBox.Items.AddRange(new object[] {
            Department.Accounting.ToString(),
            Department.Customer_Service.ToString(),
            Department.Human_Resources.ToString(),
            Department.Information_Technology.ToString(),
            Department.Manufacturing.ToString(),
            Department.Marketing.ToString(),
            Department.Product_Development.ToString(),
            Department.Sales.ToString(),
            "-Select New Department-"
            });

            NewDepartmentComboBox.SelectedIndex = 8;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ProcessDepartmentTransferRequestForm();
        }

        private void ProcessDepartmentTransferRequestForm()
        {
            var allFormFieldsValid = true;

            if (IsValidEmployeeID(EmployeeIDTextBox.Text))
            {
                EmployeeIDLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                EmployeeIDLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(NameOFApproverTextBox.Text))
            {
                NameOFApproverLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                NameOFApproverLabel.ForeColor = Color.Black;
            }

            if (NewDepartmentComboBox.SelectedIndex >= 0 && NewDepartmentComboBox.SelectedIndex <= 7)
            {
                NewDepartmentLabel.ForeColor = Color.Black;
            }
            else
            {
                NewDepartmentLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (IsEmptyString(NewJobTitleTextBox.Text))
            {
                NewJobTitleLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                NewJobTitleLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(ReasonForTransferTextBox.Text))
            {
                ReasonForTransferLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                ReasonForTransferLabel.ForeColor = Color.Black;
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
                    FormEmployee.Department = (Department)NewDepartmentComboBox.SelectedIndex;
                    FormEmployee.JobTitle = NewJobTitleTextBox.Text;
                    employeeStore.UpdateDepartmentTransfer(FormEmployee);
                }
                catch (Exception ex)
                {
                    var message = $"A problem happened when submitting the transfer {ex.Message}";
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
