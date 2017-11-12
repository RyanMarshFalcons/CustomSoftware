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

        private void employeeProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEmployeeProfilesForm();
        }
    }
}
