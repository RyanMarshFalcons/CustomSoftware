namespace WindowsFormsApplication1
{
    partial class OrderEntryForm
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.RichTextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.EmailAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.MailingAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.MailingAddressLabel = new System.Windows.Forms.Label();
            this.BillingAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.BillingAddressLabel = new System.Windows.Forms.Label();
            this.CreditCardListBox = new System.Windows.Forms.ListBox();
            this.CreditCardNumberLabel = new System.Windows.Forms.Label();
            this.SecurityCodeLabel = new System.Windows.Forms.Label();
            this.CreditCardCompnayLabel = new System.Windows.Forms.Label();
            this.ShippingMethodListBox = new System.Windows.Forms.ListBox();
            this.ShippingMethodLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.RichTextBox();
            this.DVDIDNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.QuantityTextBox = new System.Windows.Forms.RichTextBox();
            this.DVDIDLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.AddDVDButton = new System.Windows.Forms.Button();
            this.CreditCardNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.SecurityCodeTextBox = new System.Windows.Forms.RichTextBox();
            this.comboBoxCreditCard = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Lime;
            this.SubmitButton.Location = new System.Drawing.Point(648, 452);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(104, 35);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 21);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(15, 93);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.Text = "";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(13, 74);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(15, 148);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(226, 20);
            this.PhoneNumberTextBox.TabIndex = 5;
            this.PhoneNumberTextBox.Text = "";
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(16, 211);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(225, 24);
            this.EmailAddressTextBox.TabIndex = 6;
            this.EmailAddressTextBox.Text = "";
            // 
            // MailingAddressTextBox
            // 
            this.MailingAddressTextBox.Location = new System.Drawing.Point(16, 272);
            this.MailingAddressTextBox.Name = "MailingAddressTextBox";
            this.MailingAddressTextBox.Size = new System.Drawing.Size(225, 22);
            this.MailingAddressTextBox.TabIndex = 7;
            this.MailingAddressTextBox.Text = "";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(16, 129);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 8;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(16, 192);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(73, 13);
            this.EmailAddressLabel.TabIndex = 9;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // MailingAddressLabel
            // 
            this.MailingAddressLabel.AutoSize = true;
            this.MailingAddressLabel.Location = new System.Drawing.Point(15, 253);
            this.MailingAddressLabel.Name = "MailingAddressLabel";
            this.MailingAddressLabel.Size = new System.Drawing.Size(81, 13);
            this.MailingAddressLabel.TabIndex = 10;
            this.MailingAddressLabel.Text = "Mailing Address";
            // 
            // BillingAddressTextBox
            // 
            this.BillingAddressTextBox.Location = new System.Drawing.Point(16, 325);
            this.BillingAddressTextBox.Name = "BillingAddressTextBox";
            this.BillingAddressTextBox.Size = new System.Drawing.Size(225, 25);
            this.BillingAddressTextBox.TabIndex = 11;
            this.BillingAddressTextBox.Text = "";
            // 
            // BillingAddressLabel
            // 
            this.BillingAddressLabel.AutoSize = true;
            this.BillingAddressLabel.Location = new System.Drawing.Point(19, 309);
            this.BillingAddressLabel.Name = "BillingAddressLabel";
            this.BillingAddressLabel.Size = new System.Drawing.Size(75, 13);
            this.BillingAddressLabel.TabIndex = 12;
            this.BillingAddressLabel.Text = "Billing Address";
            // 
            // CreditCardListBox
            // 
            this.CreditCardListBox.FormattingEnabled = true;
            this.CreditCardListBox.Location = new System.Drawing.Point(508, 37);
            this.CreditCardListBox.Name = "CreditCardListBox";
            this.CreditCardListBox.Size = new System.Drawing.Size(244, 82);
            this.CreditCardListBox.TabIndex = 13;
            this.CreditCardListBox.Tag = "";
            // 
            // CreditCardNumberLabel
            // 
            this.CreditCardNumberLabel.AutoSize = true;
            this.CreditCardNumberLabel.Location = new System.Drawing.Point(508, 129);
            this.CreditCardNumberLabel.Name = "CreditCardNumberLabel";
            this.CreditCardNumberLabel.Size = new System.Drawing.Size(99, 13);
            this.CreditCardNumberLabel.TabIndex = 16;
            this.CreditCardNumberLabel.Text = "Credit Card Number";
            // 
            // SecurityCodeLabel
            // 
            this.SecurityCodeLabel.AutoSize = true;
            this.SecurityCodeLabel.Location = new System.Drawing.Point(508, 183);
            this.SecurityCodeLabel.Name = "SecurityCodeLabel";
            this.SecurityCodeLabel.Size = new System.Drawing.Size(106, 13);
            this.SecurityCodeLabel.TabIndex = 17;
            this.SecurityCodeLabel.Text = "3 Digit Security Code";
            // 
            // CreditCardCompnayLabel
            // 
            this.CreditCardCompnayLabel.AutoSize = true;
            this.CreditCardCompnayLabel.Location = new System.Drawing.Point(508, 21);
            this.CreditCardCompnayLabel.Name = "CreditCardCompnayLabel";
            this.CreditCardCompnayLabel.Size = new System.Drawing.Size(106, 13);
            this.CreditCardCompnayLabel.TabIndex = 18;
            this.CreditCardCompnayLabel.Text = "Credit Card Company";
            // 
            // ShippingMethodListBox
            // 
            this.ShippingMethodListBox.FormattingEnabled = true;
            this.ShippingMethodListBox.Location = new System.Drawing.Point(508, 253);
            this.ShippingMethodListBox.Name = "ShippingMethodListBox";
            this.ShippingMethodListBox.Size = new System.Drawing.Size(244, 69);
            this.ShippingMethodListBox.TabIndex = 19;
            // 
            // ShippingMethodLabel
            // 
            this.ShippingMethodLabel.AutoSize = true;
            this.ShippingMethodLabel.Location = new System.Drawing.Point(508, 234);
            this.ShippingMethodLabel.Name = "ShippingMethodLabel";
            this.ShippingMethodLabel.Size = new System.Drawing.Size(87, 13);
            this.ShippingMethodLabel.TabIndex = 20;
            this.ShippingMethodLabel.Text = "Shipping Method";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(13, 38);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(228, 24);
            this.FirstNameTextBox.TabIndex = 21;
            this.FirstNameTextBox.Text = "";
            // 
            // DVDIDNumberTextBox
            // 
            this.DVDIDNumberTextBox.Location = new System.Drawing.Point(15, 452);
            this.DVDIDNumberTextBox.Name = "DVDIDNumberTextBox";
            this.DVDIDNumberTextBox.Size = new System.Drawing.Size(173, 23);
            this.DVDIDNumberTextBox.TabIndex = 22;
            this.DVDIDNumberTextBox.Text = "";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(195, 452);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(46, 23);
            this.QuantityTextBox.TabIndex = 23;
            this.QuantityTextBox.Text = "";
            // 
            // DVDIDLabel
            // 
            this.DVDIDLabel.AutoSize = true;
            this.DVDIDLabel.Location = new System.Drawing.Point(16, 436);
            this.DVDIDLabel.Name = "DVDIDLabel";
            this.DVDIDLabel.Size = new System.Drawing.Size(84, 13);
            this.DVDIDLabel.TabIndex = 24;
            this.DVDIDLabel.Text = "DVD ID Number";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(192, 436);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 25;
            this.QuantityLabel.Text = "Quantity";
            // 
            // AddDVDButton
            // 
            this.AddDVDButton.BackColor = System.Drawing.Color.DarkOrange;
            this.AddDVDButton.Location = new System.Drawing.Point(258, 452);
            this.AddDVDButton.Name = "AddDVDButton";
            this.AddDVDButton.Size = new System.Drawing.Size(104, 35);
            this.AddDVDButton.TabIndex = 26;
            this.AddDVDButton.Text = "Add DVD";
            this.AddDVDButton.UseVisualStyleBackColor = false;
            // 
            // CreditCardNumberTextBox
            // 
            this.CreditCardNumberTextBox.Location = new System.Drawing.Point(511, 145);
            this.CreditCardNumberTextBox.Name = "CreditCardNumberTextBox";
            this.CreditCardNumberTextBox.Size = new System.Drawing.Size(241, 23);
            this.CreditCardNumberTextBox.TabIndex = 27;
            this.CreditCardNumberTextBox.Text = "";
            // 
            // SecurityCodeTextBox
            // 
            this.SecurityCodeTextBox.Location = new System.Drawing.Point(511, 200);
            this.SecurityCodeTextBox.Name = "SecurityCodeTextBox";
            this.SecurityCodeTextBox.Size = new System.Drawing.Size(241, 21);
            this.SecurityCodeTextBox.TabIndex = 28;
            this.SecurityCodeTextBox.Text = "";
            // 
            // comboBoxCreditCard
            // 
            this.comboBoxCreditCard.FormattingEnabled = true;
            this.comboBoxCreditCard.Location = new System.Drawing.Point(508, 345);
            this.comboBoxCreditCard.Name = "comboBoxCreditCard";
            this.comboBoxCreditCard.Size = new System.Drawing.Size(244, 21);
            this.comboBoxCreditCard.TabIndex = 29;
            this.comboBoxCreditCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxCreditCard_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Show Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(792, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCreditCard);
            this.Controls.Add(this.SecurityCodeTextBox);
            this.Controls.Add(this.CreditCardNumberTextBox);
            this.Controls.Add(this.AddDVDButton);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.DVDIDLabel);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.DVDIDNumberTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.ShippingMethodLabel);
            this.Controls.Add(this.ShippingMethodListBox);
            this.Controls.Add(this.CreditCardCompnayLabel);
            this.Controls.Add(this.SecurityCodeLabel);
            this.Controls.Add(this.CreditCardNumberLabel);
            this.Controls.Add(this.CreditCardListBox);
            this.Controls.Add(this.BillingAddressLabel);
            this.Controls.Add(this.BillingAddressTextBox);
            this.Controls.Add(this.MailingAddressLabel);
            this.Controls.Add(this.EmailAddressLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.MailingAddressTextBox);
            this.Controls.Add(this.EmailAddressTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.SubmitButton);
            this.Name = "OrderEntryForm";
            this.Text = "Order Entry Form";
            this.Load += new System.EventHandler(this.OrderEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.RichTextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.RichTextBox PhoneNumberTextBox;
        private System.Windows.Forms.RichTextBox EmailAddressTextBox;
        private System.Windows.Forms.RichTextBox MailingAddressTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.Label MailingAddressLabel;
        private System.Windows.Forms.RichTextBox BillingAddressTextBox;
        private System.Windows.Forms.Label BillingAddressLabel;
        private System.Windows.Forms.ListBox CreditCardListBox;
        private System.Windows.Forms.Label CreditCardNumberLabel;
        private System.Windows.Forms.Label SecurityCodeLabel;
        private System.Windows.Forms.Label CreditCardCompnayLabel;
        private System.Windows.Forms.ListBox ShippingMethodListBox;
        private System.Windows.Forms.Label ShippingMethodLabel;
        private System.Windows.Forms.RichTextBox FirstNameTextBox;
        private System.Windows.Forms.RichTextBox DVDIDNumberTextBox;
        private System.Windows.Forms.RichTextBox QuantityTextBox;
        private System.Windows.Forms.Label DVDIDLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button AddDVDButton;
        private System.Windows.Forms.RichTextBox CreditCardNumberTextBox;
        private System.Windows.Forms.RichTextBox SecurityCodeTextBox;
        private System.Windows.Forms.ComboBox comboBoxCreditCard;
        private System.Windows.Forms.Button button1;
    }
}

