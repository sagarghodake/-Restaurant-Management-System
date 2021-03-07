using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WordPad.exe");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WinWord.exe");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ToolStripStatusLabel4.Text = System.DateTime.Now.ToString();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.Show();
        }

        private void loginDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginDetails frm = new frmLoginDetails();
            frm.Show();
        }

        private void profileEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales frm = new frmSales();
            frm.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersReport frm = new frmCustomersReport();
            frm.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmSalesReport frm = new frmSalesReport();
            frm.Show();
        }

        private void restaurantInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHotelInfo frm = new frmHotelInfo();
            frm.Show();
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrency frm = new frmCurrency();
            frm.Show();
        }
    }
}
