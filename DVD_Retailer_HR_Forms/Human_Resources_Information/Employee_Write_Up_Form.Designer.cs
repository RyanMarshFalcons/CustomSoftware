namespace Human_Resources_Information
{
    partial class Employee_Write_Up_Form
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
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.SupervisorNameLabel = new System.Windows.Forms.Label();
            this.SupervisorNameTextBox = new System.Windows.Forms.TextBox();
            this.ReasonForWriteUpLabel = new System.Windows.Forms.Label();
            this.ReasonForWriteUpComboBox = new System.Windows.Forms.ComboBox();
            this.DetailsOfIncidentLabel = new System.Windows.Forms.Label();
            this.DetailsOfIncidentTextBox = new System.Windows.Forms.RichTextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(4, 13);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.EmployeeNameLabel.TabIndex = 0;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(7, 30);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(321, 20);
            this.EmployeeNameTextBox.TabIndex = 1;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(4, 70);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIDLabel.TabIndex = 2;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(7, 87);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(321, 20);
            this.EmployeeIDTextBox.TabIndex = 3;
            // 
            // SupervisorNameLabel
            // 
            this.SupervisorNameLabel.AutoSize = true;
            this.SupervisorNameLabel.Location = new System.Drawing.Point(4, 128);
            this.SupervisorNameLabel.Name = "SupervisorNameLabel";
            this.SupervisorNameLabel.Size = new System.Drawing.Size(88, 13);
            this.SupervisorNameLabel.TabIndex = 4;
            this.SupervisorNameLabel.Text = "Supervisor Name";
            // 
            // SupervisorNameTextBox
            // 
            this.SupervisorNameTextBox.Location = new System.Drawing.Point(7, 144);
            this.SupervisorNameTextBox.Name = "SupervisorNameTextBox";
            this.SupervisorNameTextBox.Size = new System.Drawing.Size(321, 20);
            this.SupervisorNameTextBox.TabIndex = 5;
            // 
            // ReasonForWriteUpLabel
            // 
            this.ReasonForWriteUpLabel.AutoSize = true;
            this.ReasonForWriteUpLabel.Location = new System.Drawing.Point(7, 183);
            this.ReasonForWriteUpLabel.Name = "ReasonForWriteUpLabel";
            this.ReasonForWriteUpLabel.Size = new System.Drawing.Size(107, 13);
            this.ReasonForWriteUpLabel.TabIndex = 6;
            this.ReasonForWriteUpLabel.Text = "Reason For Write Up";
            // 
            // ReasonForWriteUpComboBox
            // 
            this.ReasonForWriteUpComboBox.FormattingEnabled = true;
            this.ReasonForWriteUpComboBox.Location = new System.Drawing.Point(10, 200);
            this.ReasonForWriteUpComboBox.Name = "ReasonForWriteUpComboBox";
            this.ReasonForWriteUpComboBox.Size = new System.Drawing.Size(318, 21);
            this.ReasonForWriteUpComboBox.TabIndex = 7;
            // 
            // DetailsOfIncidentLabel
            // 
            this.DetailsOfIncidentLabel.AutoSize = true;
            this.DetailsOfIncidentLabel.Location = new System.Drawing.Point(388, 13);
            this.DetailsOfIncidentLabel.Name = "DetailsOfIncidentLabel";
            this.DetailsOfIncidentLabel.Size = new System.Drawing.Size(94, 13);
            this.DetailsOfIncidentLabel.TabIndex = 8;
            this.DetailsOfIncidentLabel.Text = "Details Of Incident";
            // 
            // DetailsOfIncidentTextBox
            // 
            this.DetailsOfIncidentTextBox.Location = new System.Drawing.Point(391, 30);
            this.DetailsOfIncidentTextBox.Name = "DetailsOfIncidentTextBox";
            this.DetailsOfIncidentTextBox.Size = new System.Drawing.Size(388, 311);
            this.DetailsOfIncidentTextBox.TabIndex = 9;
            this.DetailsOfIncidentTextBox.Text = "";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Lime;
            this.SubmitButton.Location = new System.Drawing.Point(640, 359);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(139, 35);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Employee_Write_Up_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(792, 405);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DetailsOfIncidentTextBox);
            this.Controls.Add(this.DetailsOfIncidentLabel);
            this.Controls.Add(this.ReasonForWriteUpComboBox);
            this.Controls.Add(this.ReasonForWriteUpLabel);
            this.Controls.Add(this.SupervisorNameTextBox);
            this.Controls.Add(this.SupervisorNameLabel);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Name = "Employee_Write_Up_Form";
            this.Text = "Employee_Write_Up_Form";
            this.Load += new System.EventHandler(this.Employee_Evaluation_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label SupervisorNameLabel;
        private System.Windows.Forms.TextBox SupervisorNameTextBox;
        private System.Windows.Forms.Label ReasonForWriteUpLabel;
        private System.Windows.Forms.ComboBox ReasonForWriteUpComboBox;
        private System.Windows.Forms.Label DetailsOfIncidentLabel;
        private System.Windows.Forms.RichTextBox DetailsOfIncidentTextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}