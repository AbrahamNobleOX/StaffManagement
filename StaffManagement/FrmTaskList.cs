using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagement
{
    public partial class FrmTaskList : Form
    {
        public FrmTaskList()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            pnlForAdmin.Hide(); // Hide the panel for admin
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmTask frm = new FrmTask(); // Create an instance of the child form
            this.Hide(); // Hide the parent form
            frm.ShowDialog(); // Show the child form
            this.Visible = true; // Show the form again after closing the child form
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmTask frm = new FrmTask(); // Create an instance of the child form
            this.Hide(); // Hide the parent form
            frm.ShowDialog(); // Show the child form
            this.Visible = true; // Show the form again after closing the child form
        }
    }
}
