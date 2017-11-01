namespace Dvd.UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStatusFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDVDInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDVDInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDVDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1379, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderFormToolStripMenuItem,
            this.orderStatusFormToolStripMenuItem,
            this.addInventoryToolStripMenuItem,
            this.addCustomerToolStripMenuItem,
            this.viewCustomerToolStripMenuItem,
            this.viewDVDInformationToolStripMenuItem,
            this.updateOrderToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.updateDVDInformationToolStripMenuItem,
            this.deleteOrderToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem,
            this.deleteDVDToolStripMenuItem,
            this.viewAllOrdersToolStripMenuItem,
            this.viewAllCustomersToolStripMenuItem,
            this.viewAllDVDsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // orderFormToolStripMenuItem
            // 
            this.orderFormToolStripMenuItem.Name = "orderFormToolStripMenuItem";
            this.orderFormToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.orderFormToolStripMenuItem.Text = "New Order";
            this.orderFormToolStripMenuItem.Click += new System.EventHandler(this.orderFormToolStripMenuItem_Click);
            // 
            // orderStatusFormToolStripMenuItem
            // 
            this.orderStatusFormToolStripMenuItem.Name = "orderStatusFormToolStripMenuItem";
            this.orderStatusFormToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.orderStatusFormToolStripMenuItem.Text = "View Order";
            this.orderStatusFormToolStripMenuItem.Click += new System.EventHandler(this.orderStatusFormToolStripMenuItem_Click);
            // 
            // addInventoryToolStripMenuItem
            // 
            this.addInventoryToolStripMenuItem.Name = "addInventoryToolStripMenuItem";
            this.addInventoryToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addInventoryToolStripMenuItem.Text = "Add DVD";
            this.addInventoryToolStripMenuItem.Click += new System.EventHandler(this.addInventoryToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewCustomerToolStripMenuItem.Text = "View Customer";
            this.viewCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerToolStripMenuItem_Click);
            // 
            // viewDVDInformationToolStripMenuItem
            // 
            this.viewDVDInformationToolStripMenuItem.Name = "viewDVDInformationToolStripMenuItem";
            this.viewDVDInformationToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewDVDInformationToolStripMenuItem.Text = "View DVD";
            this.viewDVDInformationToolStripMenuItem.Click += new System.EventHandler(this.viewDVDInformationToolStripMenuItem_Click);
            // 
            // updateOrderToolStripMenuItem
            // 
            this.updateOrderToolStripMenuItem.Name = "updateOrderToolStripMenuItem";
            this.updateOrderToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.updateOrderToolStripMenuItem.Text = "Update Order";
            this.updateOrderToolStripMenuItem.Click += new System.EventHandler(this.updateOrderToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // updateDVDInformationToolStripMenuItem
            // 
            this.updateDVDInformationToolStripMenuItem.Name = "updateDVDInformationToolStripMenuItem";
            this.updateDVDInformationToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.updateDVDInformationToolStripMenuItem.Text = "Update DVD";
            this.updateDVDInformationToolStripMenuItem.Click += new System.EventHandler(this.updateDVDInformationToolStripMenuItem_Click);
            // 
            // deleteOrderToolStripMenuItem
            // 
            this.deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            this.deleteOrderToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deleteOrderToolStripMenuItem.Text = "Delete Order";
            this.deleteOrderToolStripMenuItem.Click += new System.EventHandler(this.deleteOrderToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            // 
            // deleteDVDToolStripMenuItem
            // 
            this.deleteDVDToolStripMenuItem.Name = "deleteDVDToolStripMenuItem";
            this.deleteDVDToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deleteDVDToolStripMenuItem.Text = "Delete DVD";
            // 
            // viewAllOrdersToolStripMenuItem
            // 
            this.viewAllOrdersToolStripMenuItem.Name = "viewAllOrdersToolStripMenuItem";
            this.viewAllOrdersToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewAllOrdersToolStripMenuItem.Text = "View All Orders";
            // 
            // viewAllCustomersToolStripMenuItem
            // 
            this.viewAllCustomersToolStripMenuItem.Name = "viewAllCustomersToolStripMenuItem";
            this.viewAllCustomersToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewAllCustomersToolStripMenuItem.Text = "View All Customers";
            // 
            // viewAllDVDsToolStripMenuItem
            // 
            this.viewAllDVDsToolStripMenuItem.Name = "viewAllDVDsToolStripMenuItem";
            this.viewAllDVDsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewAllDVDsToolStripMenuItem.Text = "View All DVDs";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 848);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderStatusFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDVDInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDVDInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllDVDsToolStripMenuItem;
    }
}