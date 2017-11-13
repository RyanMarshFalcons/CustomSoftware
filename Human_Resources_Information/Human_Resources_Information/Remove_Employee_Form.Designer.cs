namespace Human_Resources_Information
{
    partial class Remove_Employee_Form
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
            this.EnterEmployeeIDLabel = new System.Windows.Forms.Label();
            this.EnterEmployeeIDTextBox = new System.Windows.Forms.RichTextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterEmployeeIDLabel
            // 
            this.EnterEmployeeIDLabel.AutoSize = true;
            this.EnterEmployeeIDLabel.Location = new System.Drawing.Point(21, 40);
            this.EnterEmployeeIDLabel.Name = "EnterEmployeeIDLabel";
            this.EnterEmployeeIDLabel.Size = new System.Drawing.Size(98, 13);
            this.EnterEmployeeIDLabel.TabIndex = 0;
            this.EnterEmployeeIDLabel.Text = "Enter Employee ID:";
            // 
            // EnterEmployeeIDTextBox
            // 
            this.EnterEmployeeIDTextBox.Location = new System.Drawing.Point(125, 37);
            this.EnterEmployeeIDTextBox.Name = "EnterEmployeeIDTextBox";
            this.EnterEmployeeIDTextBox.Size = new System.Drawing.Size(464, 34);
            this.EnterEmployeeIDTextBox.TabIndex = 1;
            this.EnterEmployeeIDTextBox.Text = "";
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Lime;
            this.EnterButton.Location = new System.Drawing.Point(607, 40);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(155, 31);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Remove_Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(774, 179);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.EnterEmployeeIDTextBox);
            this.Controls.Add(this.EnterEmployeeIDLabel);
            this.Name = "Remove_Employee_Form";
            this.Text = "Remove Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterEmployeeIDLabel;
        private System.Windows.Forms.RichTextBox EnterEmployeeIDTextBox;
        private System.Windows.Forms.Button EnterButton;
    }
}