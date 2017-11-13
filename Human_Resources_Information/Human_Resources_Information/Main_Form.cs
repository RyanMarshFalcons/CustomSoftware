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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void OpenEmployeeProfilesForm()
        {
            var employeeProfilesForm = new Employee_Profiles_Form();
            employeeProfilesForm.MdiParent = this;
            employeeProfilesForm.Show();
        }

        private void OpenAddEmployeeForm()
        {
            var addEmployeeForm = new Add_Employee_Form();
            addEmployeeForm.MdiParent = this;
            addEmployeeForm.Show();
        }

        private void OpenRemoveEmployeeForm()
        {
            var removeEmployeeForm = new Remove_Employee_Form();
            removeEmployeeForm.MdiParent = this;
            removeEmployeeForm.Show();
        }

        private void employeeProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEmployeeProfilesForm();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddEmployeeForm();
        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRemoveEmployeeForm();
        }
    }
}
