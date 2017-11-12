namespace Human_Resources_Information
{
    partial class Employee_Profiles_Form
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
            this.SortByFirstNameButton = new System.Windows.Forms.Button();
            this.SortByLastNameButton = new System.Windows.Forms.Button();
            this.SortByDepartmentButton = new System.Windows.Forms.Button();
            this.SortByHireDateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // SortByFirstNameButton
            // 
            this.SortByFirstNameButton.BackColor = System.Drawing.Color.Lime;
            this.SortByFirstNameButton.Location = new System.Drawing.Point(26, 12);
            this.SortByFirstNameButton.Name = "SortByFirstNameButton";
            this.SortByFirstNameButton.Size = new System.Drawing.Size(142, 39);
            this.SortByFirstNameButton.TabIndex = 1;
            this.SortByFirstNameButton.Text = "Sort By First Name";
            this.SortByFirstNameButton.UseVisualStyleBackColor = false;
            this.SortByFirstNameButton.Click += new System.EventHandler(this.SortByFirstNameButton_Click);
            // 
            // SortByLastNameButton
            // 
            this.SortByLastNameButton.BackColor = System.Drawing.Color.Lime;
            this.SortByLastNameButton.Location = new System.Drawing.Point(210, 14);
            this.SortByLastNameButton.Name = "SortByLastNameButton";
            this.SortByLastNameButton.Size = new System.Drawing.Size(144, 38);
            this.SortByLastNameButton.TabIndex = 2;
            this.SortByLastNameButton.Text = "Sort By Last Name";
            this.SortByLastNameButton.UseVisualStyleBackColor = false;
            this.SortByLastNameButton.Click += new System.EventHandler(this.SortByLastNameButton_Click);
            // 
            // SortByDepartmentButton
            // 
            this.SortByDepartmentButton.BackColor = System.Drawing.Color.Lime;
            this.SortByDepartmentButton.Location = new System.Drawing.Point(417, 13);
            this.SortByDepartmentButton.Name = "SortByDepartmentButton";
            this.SortByDepartmentButton.Size = new System.Drawing.Size(148, 38);
            this.SortByDepartmentButton.TabIndex = 3;
            this.SortByDepartmentButton.Text = "Sort By Department";
            this.SortByDepartmentButton.UseVisualStyleBackColor = false;
            this.SortByDepartmentButton.Click += new System.EventHandler(this.SortByDepartmentButton_Click);
            // 
            // SortByHireDateButton
            // 
            this.SortByHireDateButton.BackColor = System.Drawing.Color.Lime;
            this.SortByHireDateButton.Location = new System.Drawing.Point(610, 12);
            this.SortByHireDateButton.Name = "SortByHireDateButton";
            this.SortByHireDateButton.Size = new System.Drawing.Size(165, 39);
            this.SortByHireDateButton.TabIndex = 4;
            this.SortByHireDateButton.Text = "Sort By Hire Date";
            this.SortByHireDateButton.UseVisualStyleBackColor = false;
            this.SortByHireDateButton.Click += new System.EventHandler(this.SortByHireDateButton_Click);
            // 
            // Employee_Profiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(896, 465);
            this.Controls.Add(this.SortByHireDateButton);
            this.Controls.Add(this.SortByDepartmentButton);
            this.Controls.Add(this.SortByLastNameButton);
            this.Controls.Add(this.SortByFirstNameButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Employee_Profiles";
            this.Text = "Employee_Profiles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SortByFirstNameButton;
        private System.Windows.Forms.Button SortByLastNameButton;
        private System.Windows.Forms.Button SortByDepartmentButton;
        private System.Windows.Forms.Button SortByHireDateButton;
    }
}