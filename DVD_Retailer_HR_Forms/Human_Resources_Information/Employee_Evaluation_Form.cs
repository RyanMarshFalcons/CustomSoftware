using Human_Resources_Information.Business;
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
    public partial class Employee_Evaluation_Form : Form
    {
        EmployeeRating FormEmployeeRating = new EmployeeRating();
     
        public Employee_Evaluation_Form()
        {
            InitializeComponent();
        }

        private void Employee_Evaluation_Form_Load(object sender, System.EventArgs e)
        {
            LoadAttendance();
        }

        private void LoadAttendance()
        {
            AttendanceComboBox.Items.AddRange(new object[] {
            Rating.Poor.ToString(),
            Rating.Fair.ToString(),
            Rating.Satisfactory.ToString(),
            Rating.Good.ToString(),
            Rating.Excellent.ToString(),
            "-Select Attendance Rating-"
            });

            AttendanceComboBox.SelectedIndex = 5;
        }

        private void LoadAttitude()
        {
            AttitudeComboBox.Items.AddRange(new object[] {
            Rating.Poor.ToString(),
            Rating.Fair.ToString(),
            Rating.Satisfactory.ToString(),
            Rating.Good.ToString(),
            Rating.Excellent.ToString(),
            "-Select Attitude Rating-"
            });

            AttitudeComboBox.SelectedIndex = 5;
        }

        private void LoadJobKnowledge()
        {
            JobKnowledgeComboBox.Items.AddRange(new object[] {
            Rating.Poor.ToString(),
            Rating.Fair.ToString(),
            Rating.Satisfactory.ToString(),
            Rating.Good.ToString(),
            Rating.Excellent.ToString(),
            "-Select Job Knowledge Rating-"
            });

            JobKnowledgeComboBox.SelectedIndex = 5;
        }

        private void LoadProductivity()
        {
            ProductivityComboBox.Items.AddRange(new object[] {
            Rating.Poor.ToString(),
            Rating.Fair.ToString(),
            Rating.Satisfactory.ToString(),
            Rating.Good.ToString(),
            Rating.Excellent.ToString(),
            "-Select Productivity Rating-"
            });

            ProductivityComboBox.SelectedIndex = 5;
        }

        private void LoadCommunicationSkills()
        {
            CommunicationSkillsComboBox.Items.AddRange(new object[] {
            Rating.Poor.ToString(),
            Rating.Fair.ToString(),
            Rating.Satisfactory.ToString(),
            Rating.Good.ToString(),
            Rating.Excellent.ToString(),
            "-Select Communication Skills Rating-"
            });

            CommunicationSkillsComboBox.SelectedIndex = 5;
        }

        private void SumbitEvaluationButton_Click(object sender, EventArgs e)
        {
            ProcessEmployeeEvaluationForm();
        }

        private void ProcessEmployeeEvaluationForm()
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

            if (CheckIfDateTime(DateOfEvaluationTextBox.Text))
            {
                EvaluationDateLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                EvaluationDateLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(NameOfReviewerTextBox.Text))
            {
                ReviewerNameLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                ReviewerNameLabel.ForeColor = Color.Black;
            }

            if (IsEmptyString(ReviewersTitleTextBox.Text))
            {
                ReviewerTitleLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }
            else
            {
                ReviewerTitleLabel.ForeColor = Color.Black;
            }
            

            if (AttitudeComboBox.SelectedIndex >= 0 && AttitudeComboBox.SelectedIndex <= 4)
            {
                AttitudeLabel.ForeColor = Color.Black;
            }
            else
            {
                AttitudeLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (AttendanceComboBox.SelectedIndex >= 0 && AttendanceComboBox.SelectedIndex <= 4)
            {
                AttendanceLabel.ForeColor = Color.Black;
            }
            else
            {
                AttendanceLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (JobKnowledgeComboBox.SelectedIndex >= 0 && JobKnowledgeComboBox.SelectedIndex <= 4)
            {
                JobKnowledgeLabel.ForeColor = Color.Black;
            }
            else
            {
                JobKnowledgeLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (ProductivityComboBox.SelectedIndex >= 0 && ProductivityComboBox.SelectedIndex <= 4)
            {
                ProductivityLabel.ForeColor = Color.Black;
            }
            else
            {
                ProductivityLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (CommunicationSkillsComboBox.SelectedIndex >= 0 && CommunicationSkillsComboBox.SelectedIndex <= 4)
            {
                CommunicationSkillsLabel.ForeColor = Color.Black;
            }
            else
            {
                CommunicationSkillsLabel.ForeColor = Color.Red;
                allFormFieldsValid = false;
            }

            if (!allFormFieldsValid)
            {
                var message = "Not all of the required fields were filled out correctly";
                var caption = "Unable To Submit Evaluation";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                LoadEvaluationData();

                try
                {
                    var employeeStore = new EmployeeStore();
                    var FormEmployee = employeeStore.GetEmployee(int.Parse(EmployeeIDTextBox.Text));
                    FormEmployee.EmployeeRatingScore = FormEmployeeRating.TotalRating();
                    employeeStore.UpdateEmployeeReview(FormEmployee);
                }
                catch (Exception ex)
                {
                    var message = $"A problem happened when submitting the evaluation. {ex.Message}";
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

        private bool CheckIfDateTime(string userInput)
        {
            var result = DateTime.MinValue;
            return DateTime.TryParse(userInput, out result);
        }

        private void LoadEvaluationData()
        {
            FormEmployeeRating.Attendance = (Rating)AttendanceComboBox.SelectedIndex;
            FormEmployeeRating.Attitude = (Rating)AttitudeComboBox.SelectedIndex;
            FormEmployeeRating.JobKnowledge = (Rating)JobKnowledgeComboBox.SelectedIndex;
            FormEmployeeRating.Productivity = (Rating)ProductivityComboBox.SelectedIndex;
            FormEmployeeRating.CommunicationSkills = (Rating)CommunicationSkillsComboBox.SelectedIndex;
        }

    }
}
