namespace Dvd.UI
{
    partial class AddDVDForm
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
            this.TitleTextBox = new System.Windows.Forms.RichTextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SalesPriceLabel = new System.Windows.Forms.Label();
            this.SalesPriceTextBox = new System.Windows.Forms.RichTextBox();
            this.PurchasePriceLabel = new System.Windows.Forms.Label();
            this.PurchasePriceTextBox = new System.Windows.Forms.RichTextBox();
            this.EnterButton = new System.Windows.Forms.Button();
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
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(13, 44);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(511, 30);
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.Text = "";
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
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(617, 44);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(219, 21);
            this.GenreComboBox.TabIndex = 3;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(16, 98);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(119, 13);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Initial Quantity In Stock:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(508, 33);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // SalesPriceLabel
            // 
            this.SalesPriceLabel.AutoSize = true;
            this.SalesPriceLabel.Location = new System.Drawing.Point(16, 175);
            this.SalesPriceLabel.Name = "SalesPriceLabel";
            this.SalesPriceLabel.Size = new System.Drawing.Size(100, 13);
            this.SalesPriceLabel.TabIndex = 6;
            this.SalesPriceLabel.Text = "Current Sales Price:";
            // 
            // SalesPriceTextBox
            // 
            this.SalesPriceTextBox.Location = new System.Drawing.Point(16, 192);
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.Size = new System.Drawing.Size(508, 38);
            this.SalesPriceTextBox.TabIndex = 7;
            this.SalesPriceTextBox.Text = "";
            // 
            // PurchasePriceLabel
            // 
            this.PurchasePriceLabel.AutoSize = true;
            this.PurchasePriceLabel.Location = new System.Drawing.Point(19, 263);
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.Size = new System.Drawing.Size(119, 13);
            this.PurchasePriceLabel.TabIndex = 8;
            this.PurchasePriceLabel.Text = "Current Purchase Price:";
            // 
            // PurchasePriceTextBox
            // 
            this.PurchasePriceTextBox.Location = new System.Drawing.Point(19, 280);
            this.PurchasePriceTextBox.Name = "PurchasePriceTextBox";
            this.PurchasePriceTextBox.Size = new System.Drawing.Size(505, 36);
            this.PurchasePriceTextBox.TabIndex = 9;
            this.PurchasePriceTextBox.Text = "";
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Lime;
            this.EnterButton.Location = new System.Drawing.Point(706, 364);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(130, 35);
            this.EnterButton.TabIndex = 10;
            this.EnterButton.Text = "Add To Database";
            this.EnterButton.UseVisualStyleBackColor = false;
            // 
            // AddDVDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(854, 657);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PurchasePriceTextBox);
            this.Controls.Add(this.PurchasePriceLabel);
            this.Controls.Add(this.SalesPriceTextBox);
            this.Controls.Add(this.SalesPriceLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AddDVDForm";
            this.Text = "Add DVD Form";
            this.Load += new System.EventHandler(this.AddInventoryForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox TitleTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label SalesPriceLabel;
        private System.Windows.Forms.RichTextBox SalesPriceTextBox;
        private System.Windows.Forms.Label PurchasePriceLabel;
        private System.Windows.Forms.RichTextBox PurchasePriceTextBox;
        private System.Windows.Forms.Button EnterButton;
    }
}