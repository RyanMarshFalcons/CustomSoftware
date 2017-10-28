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
            OrderNumberLabel = new System.Windows.Forms.Label();
            OrderNumberTextBox = new System.Windows.Forms.RichTextBox();
            CustomerNameLabel = new System.Windows.Forms.Label();
            CustomerNameTextBox = new System.Windows.Forms.RichTextBox();
            OrderStatusLabel = new System.Windows.Forms.Label();
            OrderStatusTextBox = new System.Windows.Forms.RichTextBox();
            ShippingAddressLabel = new System.Windows.Forms.Label();
            ShippingAddressTextBox = new System.Windows.Forms.RichTextBox();
            CreditCardIssurerLabel = new System.Windows.Forms.Label();
            CreditCardIssuerTextBox = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // OrderNumberLabel
            // 
            OrderNumberLabel.AutoSize = true;
            OrderNumberLabel.Location = new System.Drawing.Point(0, 13);
            OrderNumberLabel.Name = "OrderNumberLabel";
            OrderNumberLabel.Size = new System.Drawing.Size(73, 13);
            OrderNumberLabel.TabIndex = 0;
            OrderNumberLabel.Text = "Order Number";
            // 
            // OrderNumberTextBox
            // 
            OrderNumberTextBox.Location = new System.Drawing.Point(3, 30);
            OrderNumberTextBox.Name = "OrderNumberTextBox";
            OrderNumberTextBox.Size = new System.Drawing.Size(151, 20);
            OrderNumberTextBox.TabIndex = 1;
            OrderNumberTextBox.Text = "";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new System.Drawing.Point(0, 123);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new System.Drawing.Size(82, 13);
            CustomerNameLabel.TabIndex = 2;
            CustomerNameLabel.Text = "Customer Name";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new System.Drawing.Point(3, 139);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new System.Drawing.Size(151, 22);
            CustomerNameTextBox.TabIndex = 3;
            CustomerNameTextBox.Text = "";
            // 
            // OrderStatusLabel
            // 
            OrderStatusLabel.AutoSize = true;
            OrderStatusLabel.Location = new System.Drawing.Point(3, 67);
            OrderStatusLabel.Name = "OrderStatusLabel";
            OrderStatusLabel.Size = new System.Drawing.Size(66, 13);
            OrderStatusLabel.TabIndex = 4;
            OrderStatusLabel.Text = "Order Status";
            // 
            // OrderStatusTextBox
            // 
            OrderStatusTextBox.Location = new System.Drawing.Point(3, 84);
            OrderStatusTextBox.Name = "OrderStatusTextBox";
            OrderStatusTextBox.Size = new System.Drawing.Size(151, 22);
            OrderStatusTextBox.TabIndex = 5;
            OrderStatusTextBox.Text = "";
            // 
            // ShippingAddressLabel
            // 
            ShippingAddressLabel.AutoSize = true;
            ShippingAddressLabel.Location = new System.Drawing.Point(3, 181);
            ShippingAddressLabel.Name = "ShippingAddressLabel";
            ShippingAddressLabel.Size = new System.Drawing.Size(89, 13);
            ShippingAddressLabel.TabIndex = 6;
            ShippingAddressLabel.Text = "Shipping Address";
            // 
            // ShippingAddressTextBox
            // 
            ShippingAddressTextBox.Location = new System.Drawing.Point(3, 198);
            ShippingAddressTextBox.Name = "ShippingAddressTextBox";
            ShippingAddressTextBox.Size = new System.Drawing.Size(151, 23);
            ShippingAddressTextBox.TabIndex = 7;
            ShippingAddressTextBox.Text = "";
            // 
            // CreditCardIssurerLabel
            // 
            CreditCardIssurerLabel.AutoSize = true;
            CreditCardIssurerLabel.Location = new System.Drawing.Point(3, 244);
            CreditCardIssurerLabel.Name = "CreditCardIssurerLabel";
            CreditCardIssurerLabel.Size = new System.Drawing.Size(90, 13);
            CreditCardIssurerLabel.TabIndex = 8;
            CreditCardIssurerLabel.Text = "Credit Card Issuer";
            // 
            // CreditCardIssuerTextBox
            // 
            CreditCardIssuerTextBox.Location = new System.Drawing.Point(3, 261);
            CreditCardIssuerTextBox.Name = "CreditCardIssuerTextBox";
            CreditCardIssuerTextBox.Size = new System.Drawing.Size(151, 23);
            CreditCardIssuerTextBox.TabIndex = 9;
            CreditCardIssuerTextBox.Text = "";
            // 
            // OrderStatusForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gray;
            ClientSize = new System.Drawing.Size(526, 446);
            Controls.Add(CreditCardIssuerTextBox);
            Controls.Add(CreditCardIssurerLabel);
            Controls.Add(ShippingAddressTextBox);
            Controls.Add(ShippingAddressLabel);
            Controls.Add(OrderStatusTextBox);
            Controls.Add(OrderStatusLabel);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(CustomerNameLabel);
            Controls.Add(OrderNumberTextBox);
            Controls.Add(OrderNumberLabel);
            Name = "OrderStatusForm";
            Text = "OrderStatusForm";
            ResumeLayout(false);
            PerformLayout();

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