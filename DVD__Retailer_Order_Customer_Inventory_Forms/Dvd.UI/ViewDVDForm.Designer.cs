namespace Dvd.UI
{
    partial class ViewDVDForm
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
            this.EnterDVDIDLabel = new System.Windows.Forms.Label();
            this.EnterDVDIDTextBox = new System.Windows.Forms.RichTextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.RichTextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.RichTextBox();
            this.QuantityInStockLabel = new System.Windows.Forms.Label();
            this.QuantityInStockTextBox = new System.Windows.Forms.RichTextBox();
            this.SalesPriceLabel = new System.Windows.Forms.Label();
            this.SalesPriceTextBox = new System.Windows.Forms.RichTextBox();
            this.PurchasePriceLabel = new System.Windows.Forms.Label();
            this.PurchasePriceTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // EnterDVDIDLabel
            // 
            this.EnterDVDIDLabel.AutoSize = true;
            this.EnterDVDIDLabel.Location = new System.Drawing.Point(177, 31);
            this.EnterDVDIDLabel.Name = "EnterDVDIDLabel";
            this.EnterDVDIDLabel.Size = new System.Drawing.Size(75, 13);
            this.EnterDVDIDLabel.TabIndex = 0;
            this.EnterDVDIDLabel.Text = "Enter DVD ID:";
            // 
            // EnterDVDIDTextBox
            // 
            this.EnterDVDIDTextBox.Location = new System.Drawing.Point(258, 28);
            this.EnterDVDIDTextBox.Name = "EnterDVDIDTextBox";
            this.EnterDVDIDTextBox.Size = new System.Drawing.Size(374, 30);
            this.EnterDVDIDTextBox.TabIndex = 1;
            this.EnterDVDIDTextBox.Text = "";
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Lime;
            this.EnterButton.Location = new System.Drawing.Point(655, 28);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(132, 40);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(79, 105);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(115, 102);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(488, 34);
            this.TitleTextBox.TabIndex = 4;
            this.TitleTextBox.Text = "";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(70, 180);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 5;
            this.GenreLabel.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(115, 165);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(488, 37);
            this.GenreTextBox.TabIndex = 6;
            this.GenreTextBox.Text = "";
            // 
            // QuantityInStockLabel
            // 
            this.QuantityInStockLabel.AutoSize = true;
            this.QuantityInStockLabel.Location = new System.Drawing.Point(17, 248);
            this.QuantityInStockLabel.Name = "QuantityInStockLabel";
            this.QuantityInStockLabel.Size = new System.Drawing.Size(92, 13);
            this.QuantityInStockLabel.TabIndex = 7;
            this.QuantityInStockLabel.Text = "Quantity In Stock:";
            // 
            // QuantityInStockTextBox
            // 
            this.QuantityInStockTextBox.Location = new System.Drawing.Point(115, 232);
            this.QuantityInStockTextBox.Name = "QuantityInStockTextBox";
            this.QuantityInStockTextBox.Size = new System.Drawing.Size(488, 42);
            this.QuantityInStockTextBox.TabIndex = 8;
            this.QuantityInStockTextBox.Text = "";
            // 
            // SalesPriceLabel
            // 
            this.SalesPriceLabel.AutoSize = true;
            this.SalesPriceLabel.Location = new System.Drawing.Point(46, 319);
            this.SalesPriceLabel.Name = "SalesPriceLabel";
            this.SalesPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.SalesPriceLabel.TabIndex = 9;
            this.SalesPriceLabel.Text = "Sales Price:";
            // 
            // SalesPriceTextBox
            // 
            this.SalesPriceTextBox.Location = new System.Drawing.Point(115, 299);
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.Size = new System.Drawing.Size(488, 44);
            this.SalesPriceTextBox.TabIndex = 10;
            this.SalesPriceTextBox.Text = "";
            // 
            // PurchasePriceLabel
            // 
            this.PurchasePriceLabel.AutoSize = true;
            this.PurchasePriceLabel.Location = new System.Drawing.Point(27, 380);
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.Size = new System.Drawing.Size(82, 13);
            this.PurchasePriceLabel.TabIndex = 11;
            this.PurchasePriceLabel.Text = "Purchase Price:";
            // 
            // PurchasePriceTextBox
            // 
            this.PurchasePriceTextBox.Location = new System.Drawing.Point(115, 368);
            this.PurchasePriceTextBox.Name = "PurchasePriceTextBox";
            this.PurchasePriceTextBox.Size = new System.Drawing.Size(488, 46);
            this.PurchasePriceTextBox.TabIndex = 12;
            this.PurchasePriceTextBox.Text = "";
            // 
            // ViewDVDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(861, 455);
            this.Controls.Add(this.PurchasePriceTextBox);
            this.Controls.Add(this.PurchasePriceLabel);
            this.Controls.Add(this.SalesPriceTextBox);
            this.Controls.Add(this.SalesPriceLabel);
            this.Controls.Add(this.QuantityInStockTextBox);
            this.Controls.Add(this.QuantityInStockLabel);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.EnterDVDIDTextBox);
            this.Controls.Add(this.EnterDVDIDLabel);
            this.Name = "ViewDVDForm";
            this.Text = "View DVD Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterDVDIDLabel;
        private System.Windows.Forms.RichTextBox EnterDVDIDTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox TitleTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.RichTextBox GenreTextBox;
        private System.Windows.Forms.Label QuantityInStockLabel;
        private System.Windows.Forms.RichTextBox QuantityInStockTextBox;
        private System.Windows.Forms.Label SalesPriceLabel;
        private System.Windows.Forms.RichTextBox SalesPriceTextBox;
        private System.Windows.Forms.Label PurchasePriceLabel;
        private System.Windows.Forms.RichTextBox PurchasePriceTextBox;
    }
}