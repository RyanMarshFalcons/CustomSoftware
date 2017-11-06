namespace Dvd.UI
{
    partial class DeleteCustomerForm
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.EnterCustomerIDTextBox = new System.Windows.Forms.RichTextBox();
            this.EnterCustomerIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Lime;
            this.EnterButton.Location = new System.Drawing.Point(666, 66);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(148, 42);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            // 
            // EnterCustomerIDTextBox
            // 
            this.EnterCustomerIDTextBox.Location = new System.Drawing.Point(212, 66);
            this.EnterCustomerIDTextBox.Name = "EnterCustomerIDTextBox";
            this.EnterCustomerIDTextBox.Size = new System.Drawing.Size(425, 33);
            this.EnterCustomerIDTextBox.TabIndex = 4;
            this.EnterCustomerIDTextBox.Text = "";
            // 
            // EnterCustomerIDLabel
            // 
            this.EnterCustomerIDLabel.AutoSize = true;
            this.EnterCustomerIDLabel.Location = new System.Drawing.Point(93, 69);
            this.EnterCustomerIDLabel.Name = "EnterCustomerIDLabel";
            this.EnterCustomerIDLabel.Size = new System.Drawing.Size(96, 13);
            this.EnterCustomerIDLabel.TabIndex = 3;
            this.EnterCustomerIDLabel.Text = "Enter Customer ID:";
            // 
            // DeleteCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(953, 271);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.EnterCustomerIDTextBox);
            this.Controls.Add(this.EnterCustomerIDLabel);
            this.Name = "DeleteCustomerForm";
            this.Text = "Delete Customer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.RichTextBox EnterCustomerIDTextBox;
        private System.Windows.Forms.Label EnterCustomerIDLabel;
    }
}