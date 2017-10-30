using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dvd.UI
{
    public partial class MainForm : Form
    {
        OrderStatusForm orderStatusForm = null;
        OrderEntryForm orderEntryForm = null;
        AddInventoryForm addInventoryForm = null;
       

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void OpenMdiClientOrderForm()
        {
            var orderEntryForm = new OrderEntryForm();
            orderEntryForm.MdiParent = this;
            orderEntryForm.Show();
        }

        private void OpenMdiClientOrderStatusForm()
        {
            var orderStatusForm = new OrderStatusForm();
            orderStatusForm.MdiParent = this;
            orderStatusForm.Show();
        }

        private void OpenMdiClientAddInventoryForm()
        {
            var addInventoryForm = new AddInventoryForm();
            addInventoryForm.MdiParent = this;
            addInventoryForm.Show();
        }

        protected void ShowOrderEntryForm()
        {
            var orderEntryForm = new OrderEntryForm();
            orderEntryForm.ShowDialog(this);
            orderEntryForm.Dispose();
        }

        protected void ShowOrderStatusForm()
        {
            var orderStatusForm = new OrderStatusForm();
            orderStatusForm.ShowDialog(this);
            orderStatusForm.Dispose();
        }

        protected void ShowAddInventoryForm()
        {
            var addInventoryForm = new AddInventoryForm();
            addInventoryForm.ShowDialog(this);
            addInventoryForm.Dispose();
        }

        private void orderFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiClientOrderForm();
        }

        private void orderStatusFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiClientOrderStatusForm();
        }

        private void addInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMdiClientAddInventoryForm();
        }
    }
}
