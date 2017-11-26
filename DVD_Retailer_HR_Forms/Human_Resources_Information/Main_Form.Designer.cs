namespace Human_Resources_Information
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeWriteUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentTransferRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeProfilesToolStripMenuItem,
            this.addEmployeeToolStripMenuItem,
            this.removeEmployeeToolStripMenuItem,
            this.employeeWriteUpToolStripMenuItem,
            this.departmentTransferRequestToolStripMenuItem,
            this.employeeEvaluationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // employeeProfilesToolStripMenuItem
            // 
            this.employeeProfilesToolStripMenuItem.Name = "employeeProfilesToolStripMenuItem";
            this.employeeProfilesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.employeeProfilesToolStripMenuItem.Text = "View Employee Profiles";
            this.employeeProfilesToolStripMenuItem.Click += new System.EventHandler(this.employeeProfilesToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            this.removeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.removeEmployeeToolStripMenuItem_Click);
            // 
            // employeeWriteUpToolStripMenuItem
            // 
            this.employeeWriteUpToolStripMenuItem.Name = "employeeWriteUpToolStripMenuItem";
            this.employeeWriteUpToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.employeeWriteUpToolStripMenuItem.Text = "Employee Write Up";
            this.employeeWriteUpToolStripMenuItem.Click += new System.EventHandler(this.employeeWriteUpToolStripMenuItem_Click);
            // 
            // departmentTransferRequestToolStripMenuItem
            // 
            this.departmentTransferRequestToolStripMenuItem.Name = "departmentTransferRequestToolStripMenuItem";
            this.departmentTransferRequestToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.departmentTransferRequestToolStripMenuItem.Text = "Department Transfer Request";
            this.departmentTransferRequestToolStripMenuItem.Click += new System.EventHandler(this.departmentTransferRequestToolStripMenuItem_Click);
            // 
            // employeeEvaluationToolStripMenuItem
            // 
            this.employeeEvaluationToolStripMenuItem.Name = "employeeEvaluationToolStripMenuItem";
            this.employeeEvaluationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.employeeEvaluationToolStripMenuItem.Text = "Employee Evaluation";
            this.employeeEvaluationToolStripMenuItem.Click += new System.EventHandler(this.employeeEvaluationToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(894, 563);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeWriteUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentTransferRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeEvaluationToolStripMenuItem;
    }
}

