namespace Human_Resources_Information
{
    partial class Department_Transfer_Request_Form
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
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.NameOFApproverLabel = new System.Windows.Forms.Label();
            this.NameOFApproverTextBox = new System.Windows.Forms.TextBox();
            this.NewDepartmentLabel = new System.Windows.Forms.Label();
            this.NewDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.NewJobTitleLabel = new System.Windows.Forms.Label();
            this.NewJobTitleTextBox = new System.Windows.Forms.TextBox();
            this.ReasonForTransferLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(13, 23);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIDLabel.TabIndex = 0;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(16, 40);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(432, 20);
            this.EmployeeIDTextBox.TabIndex = 1;
            // 
            // NameOFApproverLabel
            // 
            this.NameOFApproverLabel.AutoSize = true;
            this.NameOFApproverLabel.Location = new System.Drawing.Point(16, 76);
            this.NameOFApproverLabel.Name = "NameOFApproverLabel";
            this.NameOFApproverLabel.Size = new System.Drawing.Size(95, 13);
            this.NameOFApproverLabel.TabIndex = 2;
            this.NameOFApproverLabel.Text = "Name Of Approver";
            // 
            // NameOFApproverTextBox
            // 
            this.NameOFApproverTextBox.Location = new System.Drawing.Point(16, 92);
            this.NameOFApproverTextBox.Name = "NameOFApproverTextBox";
            this.NameOFApproverTextBox.Size = new System.Drawing.Size(432, 20);
            this.NameOFApproverTextBox.TabIndex = 3;
            // 
            // NewDepartmentLabel
            // 
            this.NewDepartmentLabel.AutoSize = true;
            this.NewDepartmentLabel.Location = new System.Drawing.Point(16, 128);
            this.NewDepartmentLabel.Name = "NewDepartmentLabel";
            this.NewDepartmentLabel.Size = new System.Drawing.Size(87, 13);
            this.NewDepartmentLabel.TabIndex = 4;
            this.NewDepartmentLabel.Text = "New Department";
            // 
            // NewDepartmentComboBox
            // 
            this.NewDepartmentComboBox.FormattingEnabled = true;
            this.NewDepartmentComboBox.Location = new System.Drawing.Point(19, 145);
            this.NewDepartmentComboBox.Name = "NewDepartmentComboBox";
            this.NewDepartmentComboBox.Size = new System.Drawing.Size(429, 21);
            this.NewDepartmentComboBox.TabIndex = 5;
            // 
            // NewJobTitleLabel
            // 
            this.NewJobTitleLabel.AutoSize = true;
            this.NewJobTitleLabel.Location = new System.Drawing.Point(19, 305);
            this.NewJobTitleLabel.Name = "NewJobTitleLabel";
            this.NewJobTitleLabel.Size = new System.Drawing.Size(72, 13);
            this.NewJobTitleLabel.TabIndex = 6;
            this.NewJobTitleLabel.Text = "New Job Title";
            // 
            // NewJobTitleTextBox
            // 
            this.NewJobTitleTextBox.Location = new System.Drawing.Point(16, 322);
            this.NewJobTitleTextBox.Name = "NewJobTitleTextBox";
            this.NewJobTitleTextBox.Size = new System.Drawing.Size(432, 20);
            this.NewJobTitleTextBox.TabIndex = 7;
            // 
            // ReasonForTransferLabel
            // 
            this.ReasonForTransferLabel.AutoSize = true;
            this.ReasonForTransferLabel.Location = new System.Drawing.Point(465, 23);
            this.ReasonForTransferLabel.Name = "ReasonForTransferLabel";
            this.ReasonForTransferLabel.Size = new System.Drawing.Size(104, 13);
            this.ReasonForTransferLabel.TabIndex = 8;
            this.ReasonForTransferLabel.Text = "Reason For Transfer";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(468, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(411, 254);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Lime;
            this.SubmitButton.Location = new System.Drawing.Point(739, 323);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(140, 34);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // Department_Transfer_Request_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(891, 358);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ReasonForTransferLabel);
            this.Controls.Add(this.NewJobTitleTextBox);
            this.Controls.Add(this.NewJobTitleLabel);
            this.Controls.Add(this.NewDepartmentComboBox);
            this.Controls.Add(this.NewDepartmentLabel);
            this.Controls.Add(this.NameOFApproverTextBox);
            this.Controls.Add(this.NameOFApproverLabel);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Name = "Department_Transfer_Request_Form";
            this.Text = "Department_Transfer_Request_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label NameOFApproverLabel;
        private System.Windows.Forms.TextBox NameOFApproverTextBox;
        private System.Windows.Forms.Label NewDepartmentLabel;
        private System.Windows.Forms.ComboBox NewDepartmentComboBox;
        private System.Windows.Forms.Label NewJobTitleLabel;
        private System.Windows.Forms.TextBox NewJobTitleTextBox;
        private System.Windows.Forms.Label ReasonForTransferLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SubmitButton;
    }
}