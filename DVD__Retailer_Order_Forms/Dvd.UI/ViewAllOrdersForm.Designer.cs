namespace Dvd.UI
{
    partial class ViewAllOrdersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderHistoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrderHistoryLabel
            // 
            this.OrderHistoryLabel.AutoSize = true;
            this.OrderHistoryLabel.Location = new System.Drawing.Point(225, 67);
            this.OrderHistoryLabel.Name = "OrderHistoryLabel";
            this.OrderHistoryLabel.Size = new System.Drawing.Size(68, 13);
            this.OrderHistoryLabel.TabIndex = 1;
            this.OrderHistoryLabel.Text = "Order History";
            // 
            // ViewAllOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(726, 569);
            this.Controls.Add(this.OrderHistoryLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewAllOrdersForm";
            this.Text = "View All Orders Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label OrderHistoryLabel;
    }
}