namespace Dvd.UI
{
    partial class UpdateOrderForm
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
            this.DvdsOrderedDataGrid = new System.Windows.Forms.DataGridView();
            this.DvdsOrderedLabel = new System.Windows.Forms.Label();
            this.OrderTotalTextBox = new System.Windows.Forms.RichTextBox();
            this.OrderTotalLabel = new System.Windows.Forms.Label();
            this.OrderDateTextBox = new System.Windows.Forms.RichTextBox();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.ShippingStatusLabel = new System.Windows.Forms.Label();
            this.ShippingMethodLabel = new System.Windows.Forms.Label();
            this.MailingAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.MailingAddressLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.RichTextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EnterOrderNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.EnterOrderNumberLabel = new System.Windows.Forms.Label();
            this.UpdateDatabaseButton = new System.Windows.Forms.Button();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.RichTextBox();
            this.ShippingMethodComboBox = new System.Windows.Forms.ComboBox();
            this.ShippingStatusComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DvdsOrderedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DvdsOrderedDataGrid
            // 
            this.DvdsOrderedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvdsOrderedDataGrid.Location = new System.Drawing.Point(63, 417);
            this.DvdsOrderedDataGrid.Name = "DvdsOrderedDataGrid";
            this.DvdsOrderedDataGrid.Size = new System.Drawing.Size(365, 195);
            this.DvdsOrderedDataGrid.TabIndex = 38;
            // 
            // DvdsOrderedLabel
            // 
            this.DvdsOrderedLabel.AutoSize = true;
            this.DvdsOrderedLabel.Location = new System.Drawing.Point(202, 401);
            this.DvdsOrderedLabel.Name = "DvdsOrderedLabel";
            this.DvdsOrderedLabel.Size = new System.Drawing.Size(76, 13);
            this.DvdsOrderedLabel.TabIndex = 37;
            this.DvdsOrderedLabel.Text = "Dvds Ordered:";
            // 
            // OrderTotalTextBox
            // 
            this.OrderTotalTextBox.Location = new System.Drawing.Point(113, 353);
            this.OrderTotalTextBox.Name = "OrderTotalTextBox";
            this.OrderTotalTextBox.ReadOnly = true;
            this.OrderTotalTextBox.Size = new System.Drawing.Size(315, 29);
            this.OrderTotalTextBox.TabIndex = 36;
            this.OrderTotalTextBox.Text = "";
            // 
            // OrderTotalLabel
            // 
            this.OrderTotalLabel.AutoSize = true;
            this.OrderTotalLabel.Location = new System.Drawing.Point(43, 356);
            this.OrderTotalLabel.Name = "OrderTotalLabel";
            this.OrderTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.OrderTotalLabel.TabIndex = 35;
            this.OrderTotalLabel.Text = "Order Total:";
            // 
            // OrderDateTextBox
            // 
            this.OrderDateTextBox.Location = new System.Drawing.Point(115, 307);
            this.OrderDateTextBox.Name = "OrderDateTextBox";
            this.OrderDateTextBox.ReadOnly = true;
            this.OrderDateTextBox.Size = new System.Drawing.Size(313, 28);
            this.OrderDateTextBox.TabIndex = 32;
            this.OrderDateTextBox.Text = "";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(44, 307);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(62, 13);
            this.OrderDateLabel.TabIndex = 31;
            this.OrderDateLabel.Text = "Order Date:";
            // 
            // ShippingStatusLabel
            // 
            this.ShippingStatusLabel.AutoSize = true;
            this.ShippingStatusLabel.Location = new System.Drawing.Point(561, 310);
            this.ShippingStatusLabel.Name = "ShippingStatusLabel";
            this.ShippingStatusLabel.Size = new System.Drawing.Size(84, 13);
            this.ShippingStatusLabel.TabIndex = 29;
            this.ShippingStatusLabel.Text = "Shipping Status:";
            // 
            // ShippingMethodLabel
            // 
            this.ShippingMethodLabel.AutoSize = true;
            this.ShippingMethodLabel.Location = new System.Drawing.Point(555, 128);
            this.ShippingMethodLabel.Name = "ShippingMethodLabel";
            this.ShippingMethodLabel.Size = new System.Drawing.Size(90, 13);
            this.ShippingMethodLabel.TabIndex = 27;
            this.ShippingMethodLabel.Text = "Shipping Method:";
            // 
            // MailingAddressTextBox
            // 
            this.MailingAddressTextBox.Location = new System.Drawing.Point(115, 264);
            this.MailingAddressTextBox.Name = "MailingAddressTextBox";
            this.MailingAddressTextBox.Size = new System.Drawing.Size(313, 26);
            this.MailingAddressTextBox.TabIndex = 26;
            this.MailingAddressTextBox.Text = "";
            // 
            // MailingAddressLabel
            // 
            this.MailingAddressLabel.AutoSize = true;
            this.MailingAddressLabel.Location = new System.Drawing.Point(22, 264);
            this.MailingAddressLabel.Name = "MailingAddressLabel";
            this.MailingAddressLabel.Size = new System.Drawing.Size(84, 13);
            this.MailingAddressLabel.TabIndex = 25;
            this.MailingAddressLabel.Text = "Mailing Address:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(115, 125);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(313, 26);
            this.FirstNameTextBox.TabIndex = 24;
            this.FirstNameTextBox.Text = "";
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EnterButton.Location = new System.Drawing.Point(525, 59);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(120, 31);
            this.EnterButton.TabIndex = 23;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(46, 125);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 22;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // EnterOrderNumberTextBox
            // 
            this.EnterOrderNumberTextBox.Location = new System.Drawing.Point(170, 59);
            this.EnterOrderNumberTextBox.Name = "EnterOrderNumberTextBox";
            this.EnterOrderNumberTextBox.Size = new System.Drawing.Size(323, 24);
            this.EnterOrderNumberTextBox.TabIndex = 21;
            this.EnterOrderNumberTextBox.Text = "";
            // 
            // EnterOrderNumberLabel
            // 
            this.EnterOrderNumberLabel.AutoSize = true;
            this.EnterOrderNumberLabel.Location = new System.Drawing.Point(60, 59);
            this.EnterOrderNumberLabel.Name = "EnterOrderNumberLabel";
            this.EnterOrderNumberLabel.Size = new System.Drawing.Size(104, 13);
            this.EnterOrderNumberLabel.TabIndex = 20;
            this.EnterOrderNumberLabel.Text = "Enter Order Number:";
            // 
            // UpdateDatabaseButton
            // 
            this.UpdateDatabaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateDatabaseButton.Location = new System.Drawing.Point(537, 570);
            this.UpdateDatabaseButton.Name = "UpdateDatabaseButton";
            this.UpdateDatabaseButton.Size = new System.Drawing.Size(149, 42);
            this.UpdateDatabaseButton.TabIndex = 39;
            this.UpdateDatabaseButton.Text = "Update Database";
            this.UpdateDatabaseButton.UseVisualStyleBackColor = false;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(45, 168);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 40;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(115, 168);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(313, 27);
            this.LastNameTextBox.TabIndex = 41;
            this.LastNameTextBox.Text = "";
            // 
            // ShippingMethodComboBox
            // 
            this.ShippingMethodComboBox.FormattingEnabled = true;
            this.ShippingMethodComboBox.Location = new System.Drawing.Point(479, 144);
            this.ShippingMethodComboBox.Name = "ShippingMethodComboBox";
            this.ShippingMethodComboBox.Size = new System.Drawing.Size(250, 21);
            this.ShippingMethodComboBox.TabIndex = 42;
            // 
            // ShippingStatusComboBox
            // 
            this.ShippingStatusComboBox.FormattingEnabled = true;
            this.ShippingStatusComboBox.Location = new System.Drawing.Point(479, 326);
            this.ShippingStatusComboBox.Name = "ShippingStatusComboBox";
            this.ShippingStatusComboBox.Size = new System.Drawing.Size(250, 21);
            this.ShippingStatusComboBox.TabIndex = 43;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(38, 213);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(68, 13);
            this.CustomerIDLabel.TabIndex = 33;
            this.CustomerIDLabel.Text = "Customer ID:";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(115, 213);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.ReadOnly = true;
            this.CustomerIDTextBox.Size = new System.Drawing.Size(313, 31);
            this.CustomerIDTextBox.TabIndex = 34;
            this.CustomerIDTextBox.Text = "";
            // 
            // UpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(772, 624);
            this.Controls.Add(this.ShippingStatusComboBox);
            this.Controls.Add(this.ShippingMethodComboBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.UpdateDatabaseButton);
            this.Controls.Add(this.DvdsOrderedDataGrid);
            this.Controls.Add(this.DvdsOrderedLabel);
            this.Controls.Add(this.OrderTotalTextBox);
            this.Controls.Add(this.OrderTotalLabel);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.OrderDateTextBox);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.ShippingStatusLabel);
            this.Controls.Add(this.ShippingMethodLabel);
            this.Controls.Add(this.MailingAddressTextBox);
            this.Controls.Add(this.MailingAddressLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.EnterOrderNumberTextBox);
            this.Controls.Add(this.EnterOrderNumberLabel);
            this.Name = "UpdateOrderForm";
            this.Text = "Update Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.DvdsOrderedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DvdsOrderedDataGrid;
        private System.Windows.Forms.Label DvdsOrderedLabel;
        private System.Windows.Forms.RichTextBox OrderTotalTextBox;
        private System.Windows.Forms.Label OrderTotalLabel;
        private System.Windows.Forms.RichTextBox OrderDateTextBox;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label ShippingStatusLabel;
        private System.Windows.Forms.Label ShippingMethodLabel;
        private System.Windows.Forms.RichTextBox MailingAddressTextBox;
        private System.Windows.Forms.Label MailingAddressLabel;
        private System.Windows.Forms.RichTextBox FirstNameTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.RichTextBox EnterOrderNumberTextBox;
        private System.Windows.Forms.Label EnterOrderNumberLabel;
        private System.Windows.Forms.Button UpdateDatabaseButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.RichTextBox LastNameTextBox;
        private System.Windows.Forms.ComboBox ShippingMethodComboBox;
        private System.Windows.Forms.ComboBox ShippingStatusComboBox;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.RichTextBox CustomerIDTextBox;
    }
}