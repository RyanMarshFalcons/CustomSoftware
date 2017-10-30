namespace Dvd.UI
{
    partial class AddInventoryForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(13, 27);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(76, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title Of Movie:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(511, 30);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(679, 27);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(68, 13);
            this.GenreLabel.TabIndex = 2;
            this.GenreLabel.Text = "Movie Genre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(617, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // AddInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(854, 657);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AddInventoryForm";
            this.Text = "Add Inventory Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}