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
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void OpenNewOrderForm()
        {
            var orderEntryForm = new NewOrderForm();
            orderEntryForm.MdiParent = this;
            orderEntryForm.Show();
        }

        private void OpenViewOrderForm()
        {
            var orderStatusForm = new ViewOrderForm();
            orderStatusForm.MdiParent = this;
            orderStatusForm.Show();
        }

        private void OpenAddDVDForm()
        {
            var addInventoryForm = new AddDVDForm();
            addInventoryForm.MdiParent = this;
            addInventoryForm.Show();
        }

        private void OpenAddCustomerForm()
        {
            var addCustomerForm = new AddCustomerForm();
            addCustomerForm.MdiParent = this;
            addCustomerForm.Show();
        }

        private void OpenViewCustomerForm()
        {
            var viewCustomerForm = new ViewCustomerForm();
            viewCustomerForm.MdiParent = this;
            viewCustomerForm.Show();
        }

        private void OpenViewDVDForm()
        {
            var viewDVDForm = new ViewDVDForm();
            viewDVDForm.MdiParent = this;
            viewDVDForm.Show();
        }

        private void OpenUpdateOrderForm()
        {
            var updateOrderForm = new UpdateOrderForm();
            updateOrderForm.MdiParent = this;
            updateOrderForm.Show();
        }

        private void OpenUpdateCustomerForm()
        {
            var updateCustomerForm = new UpdateCustomerForm();
            updateCustomerForm.MdiParent = this;
            updateCustomerForm.Show();
        }

        private void OpenUpdateDVDForm()
        {
            var updateDVDForm = new UpdateDVDForm();
            updateDVDForm.MdiParent = this;
            updateDVDForm.Show();
        }

        private void OpenDeleteOrderForm()
        {
            var deleteOrderForm = new DeleteOrderForm();
            deleteOrderForm.MdiParent = this;
            deleteOrderForm.Show();
        }

        private void orderFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewOrderForm();
        }

        private void orderStatusFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenViewOrderForm();
        }

        private void addInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddDVDForm();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddCustomerForm();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenViewCustomerForm();
        }

        private void viewDVDInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenViewDVDForm();
        }

        private void updateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUpdateOrderForm();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUpdateCustomerForm();
        }

        private void updateDVDInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUpdateDVDForm();
        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDeleteOrderForm();
        }
    }
}
