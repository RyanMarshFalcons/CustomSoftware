namespace Dvd.UI
{
    partial class DeleteOrderForm
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
            this.EnterOrderNumberLabel = new System.Windows.Forms.Label();
            this.EnterOrderNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterOrderNumberLabel
            // 
            this.EnterOrderNumberLabel.AutoSize = true;
            this.EnterOrderNumberLabel.Location = new System.Drawing.Point(37, 53);
            this.EnterOrderNumberLabel.Name = "EnterOrderNumberLabel";
            this.EnterOrderNumberLabel.Size = new System.Drawing.Size(104, 13);
            this.EnterOrderNumberLabel.TabIndex = 0;
            this.EnterOrderNumberLabel.Text = "Enter Order Number:";
            // 
            // EnterOrderNumberTextBox
            // 
            this.EnterOrderNumberTextBox.Location = new System.Drawing.Point(147, 50);
            this.EnterOrderNumberTextBox.Name = "EnterOrderNumberTextBox";
            this.EnterOrderNumberTextBox.Size = new System.Drawing.Size(425, 33);
            this.EnterOrderNumberTextBox.TabIndex = 1;
            this.EnterOrderNumberTextBox.Text = "";
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Lime;
            this.EnterButton.Location = new System.Drawing.Point(601, 50);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(148, 42);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // DeleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(922, 229);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.EnterOrderNumberTextBox);
            this.Controls.Add(this.EnterOrderNumberLabel);
            this.Name = "DeleteOrderForm";
            this.Text = "Delete Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterOrderNumberLabel;
        private System.Windows.Forms.RichTextBox EnterOrderNumberTextBox;
        private System.Windows.Forms.Button EnterButton;
    }
}