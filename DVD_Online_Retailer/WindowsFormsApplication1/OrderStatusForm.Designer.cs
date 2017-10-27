namespace WindowsFormsApplication1
{
    partial class OrderStatusForm
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
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.OrderNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.RichTextBox();
            this.OrderStatusLabel = new System.Windows.Forms.Label();
            this.OrderStatusTextBox = new System.Windows.Forms.RichTextBox();
            this.ShippingAddressLabel = new System.Windows.Forms.Label();
            this.ShippingAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.CreditCardIssurerLabel = new System.Windows.Forms.Label();
            this.CreditCardIssuerTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Location = new System.Drawing.Point(0, 13);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.OrderNumberLabel.TabIndex = 0;
            this.OrderNumberLabel.Text = "Order Number";
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(3, 30);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.Size = new System.Drawing.Size(151, 20);
            this.OrderNumberTextBox.TabIndex = 1;
            this.OrderNumberTextBox.Text = "";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(0, 123);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CustomerNameLabel.TabIndex = 2;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(3, 139);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(151, 22);
            this.CustomerNameTextBox.TabIndex = 3;
            this.CustomerNameTextBox.Text = "";
            // 
            // OrderStatusLabel
            // 
            this.OrderStatusLabel.AutoSize = true;
            this.OrderStatusLabel.Location = new System.Drawing.Point(3, 67);
            this.OrderStatusLabel.Name = "OrderStatusLabel";
            this.OrderStatusLabel.Size = new System.Drawing.Size(66, 13);
            this.OrderStatusLabel.TabIndex = 4;
            this.OrderStatusLabel.Text = "Order Status";
            // 
            // OrderStatusTextBox
            // 
            this.OrderStatusTextBox.Location = new System.Drawing.Point(3, 84);
            this.OrderStatusTextBox.Name = "OrderStatusTextBox";
            this.OrderStatusTextBox.Size = new System.Drawing.Size(151, 22);
            this.OrderStatusTextBox.TabIndex = 5;
            this.OrderStatusTextBox.Text = "";
            // 
            // ShippingAddressLabel
            // 
            this.ShippingAddressLabel.AutoSize = true;
            this.ShippingAddressLabel.Location = new System.Drawing.Point(3, 181);
            this.ShippingAddressLabel.Name = "ShippingAddressLabel";
            this.ShippingAddressLabel.Size = new System.Drawing.Size(89, 13);
            this.ShippingAddressLabel.TabIndex = 6;
            this.ShippingAddressLabel.Text = "Shipping Address";
            // 
            // ShippingAddressTextBox
            // 
            this.ShippingAddressTextBox.Location = new System.Drawing.Point(3, 198);
            this.ShippingAddressTextBox.Name = "ShippingAddressTextBox";
            this.ShippingAddressTextBox.Size = new System.Drawing.Size(151, 23);
            this.ShippingAddressTextBox.TabIndex = 7;
            this.ShippingAddressTextBox.Text = "";
            // 
            // CreditCardIssurerLabel
            // 
            this.CreditCardIssurerLabel.AutoSize = true;
            this.CreditCardIssurerLabel.Location = new System.Drawing.Point(3, 244);
            this.CreditCardIssurerLabel.Name = "CreditCardIssurerLabel";
            this.CreditCardIssurerLabel.Size = new System.Drawing.Size(90, 13);
            this.CreditCardIssurerLabel.TabIndex = 8;
            this.CreditCardIssurerLabel.Text = "Credit Card Issuer";
            // 
            // CreditCardIssuerTextBox
            // 
            this.CreditCardIssuerTextBox.Location = new System.Drawing.Point(3, 261);
            this.CreditCardIssuerTextBox.Name = "CreditCardIssuerTextBox";
            this.CreditCardIssuerTextBox.Size = new System.Drawing.Size(151, 23);
            this.CreditCardIssuerTextBox.TabIndex = 9;
            this.CreditCardIssuerTextBox.Text = "";
            // 
            // OrderStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(526, 446);
            this.Controls.Add(this.CreditCardIssuerTextBox);
            this.Controls.Add(this.CreditCardIssurerLabel);
            this.Controls.Add(this.ShippingAddressTextBox);
            this.Controls.Add(this.ShippingAddressLabel);
            this.Controls.Add(this.OrderStatusTextBox);
            this.Controls.Add(this.OrderStatusLabel);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.OrderNumberTextBox);
            this.Controls.Add(this.OrderNumberLabel);
            this.Name = "OrderStatusForm";
            this.Text = "OrderStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.RichTextBox OrderNumberTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.RichTextBox CustomerNameTextBox;
        private System.Windows.Forms.Label OrderStatusLabel;
        private System.Windows.Forms.RichTextBox OrderStatusTextBox;
        private System.Windows.Forms.Label ShippingAddressLabel;
        private System.Windows.Forms.RichTextBox ShippingAddressTextBox;
        private System.Windows.Forms.Label CreditCardIssurerLabel;
        private System.Windows.Forms.RichTextBox CreditCardIssuerTextBox;
    }
}