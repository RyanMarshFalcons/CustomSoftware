namespace Dvd.UI
{
    partial class DeleteDVDForm
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
            this.EnterDVDIDTextBox = new System.Windows.Forms.RichTextBox();
            this.EnterDVDIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Lime;
            this.EnterButton.Location = new System.Drawing.Point(692, 77);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(148, 42);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // EnterDVDIDTextBox
            // 
            this.EnterDVDIDTextBox.Location = new System.Drawing.Point(238, 77);
            this.EnterDVDIDTextBox.Name = "EnterDVDIDTextBox";
            this.EnterDVDIDTextBox.Size = new System.Drawing.Size(425, 33);
            this.EnterDVDIDTextBox.TabIndex = 7;
            this.EnterDVDIDTextBox.Text = "";
            // 
            // EnterDVDIDLabel
            // 
            this.EnterDVDIDLabel.AutoSize = true;
            this.EnterDVDIDLabel.Location = new System.Drawing.Point(119, 80);
            this.EnterDVDIDLabel.Name = "EnterDVDIDLabel";
            this.EnterDVDIDLabel.Size = new System.Drawing.Size(75, 13);
            this.EnterDVDIDLabel.TabIndex = 6;
            this.EnterDVDIDLabel.Text = "Enter DVD ID:";
            // 
            // DeleteDVDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(994, 287);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.EnterDVDIDTextBox);
            this.Controls.Add(this.EnterDVDIDLabel);
            this.Name = "DeleteDVDForm";
            this.Text = "Delete DVD Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.RichTextBox EnterDVDIDTextBox;
        private System.Windows.Forms.Label EnterDVDIDLabel;
    }
}