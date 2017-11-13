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
    public partial class Add_Employee_Form : Form
    {
        private Employee FormEmployee = new Employee();
        public Add_Employee_Form()
        {
            InitializeComponent();
        }

        private void Add_EmployeeForm_Load(object sender, System.EventArgs e)
        {
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            DepartmentComboBox.Items.AddRange(new object[] {
            Department.Accounting.ToString(),
            Department.Customer_Service.ToString(),
            Department.Human_Resources.ToString(),
            Department.Information_Technology.ToString(),
            Department.Manufacturing.ToString(),
            Department.Marketing.ToString(),
            Department.Product_Development.ToString(),
            Department.Sales.ToString(),
            "-Select Department-"
            });

            DepartmentComboBox.SelectedIndex = 8;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            ProcessAddEmployeeForm();
        }

        private void ProcessAddEmployeeForm()
        {
            var allFormFieldsValid = true;

            if (IsEmptyString(FirstNameTextBox.Text))
            {
                FirstNameLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                FirstNameLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(LastNameTextBox.Text))
            {
                LastNameLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                LastNameLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(JobTitleTextBox.Text))
            {
                JobTitleLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                JobTitleLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(AddressTextBox.Text))
            {
                AddressLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                AddressLabel.ForeColor = Color.Black;
            }

            if (!IsDateTime(HireDateTextBox.Text))
            {
                HireDateLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                HireDateLabel.ForeColor = Color.Black;
            }

            if (DepartmentComboBox.SelectedIndex >= 0 && DepartmentComboBox.SelectedIndex <= 7)
            {
                DepartmentLabel.ForeColor = Color.Black;
            }
            else
            {
                DepartmentLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (!IsPositiveDecimal(SalaryTextBox.Text))
            {
                SalaryLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                SalaryLabel.ForeColor = Color.Black;
            }

            if (!allFormFieldsValid)
            {
                var message = "Not all of the required fields were filled out correctly";
                var caption = "Unable To Submit Employee";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                LoadEmployeeData();

                try
                {
                    var employeeStore = new EmployeeStore();
                    employeeStore.AddEmployee(FormEmployee);
                }
                catch (Exception ex)
                {
                    var message = $"A problem happened when adding the employee. {ex.Message}";
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

        private bool IsPositiveDecimal(string userInput)
        {
            var result = 0M;
            if (decimal.TryParse(userInput, out result))
            {
                return result > 0M;
            }
            else
            {
                return false;
            }
        }

        private bool IsDateTime(string userInput)
        {
            var result = DateTime.MinValue;
            return DateTime.TryParse(userInput, out result);
        }

        private void LoadEmployeeData()
        {
            FormEmployee.FirstName = FirstNameTextBox.Text;
            FormEmployee.LastName = LastNameTextBox.Text;
            FormEmployee.Department = (Department)DepartmentComboBox.SelectedIndex;
            FormEmployee.JobTitle = JobTitleTextBox.Text;
            FormEmployee.HireDate = DateTime.Parse(HireDateTextBox.Text);
            FormEmployee.Address = AddressTextBox.Text;
            FormEmployee.Salary = decimal.Parse(SalaryTextBox.Text);
            FormEmployee.IsDeleted = false;
        }
    }
}
