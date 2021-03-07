using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace Restaurant_Management_System
{
    public partial class frmSalesReport : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        ConnectionString cs = new ConnectionString();
        SqlDataReader rdr;
        public frmSalesReport()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dtpInvoiceDateFrom.Text = System.DateTime.Today.ToString();
            dtpInvoiceDateTo.Text = System.DateTime.Today.ToString();
            crystalReportViewer1.ReportSource = null;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dtpInvoiceDateFrom.Text = System.DateTime.Today.ToString();
            dtpInvoiceDateTo.Text = System.DateTime.Today.ToString();
            crystalReportViewer1.ReportSource = null;
            cmbCurrency.Text = "";
            dateTimePicker1.Text = System.DateTime.Today.ToString();
            dateTimePicker2.Text = System.DateTime.Today.ToString();
            crystalReportViewer2.ReportSource = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbCurrency.Text = "";
            dateTimePicker1.Text = System.DateTime.Today.ToString();
            dateTimePicker2.Text = System.DateTime.Today.ToString();
            crystalReportViewer2.ReportSource = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                rptSales rpt = new rptSales();
                //The report you created.
                cmd = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                DataSet myDS = new DataSet();
                //The DataSet you created.
                con = new SqlConnection(cs.DBConn);
                cmd.Connection = con;
                cmd.CommandText = "SELECT BillNo,BillDate,VATAmount,DiscountAmount,GrandTotal,CurrencyName from Invoice_Info,Currency where Invoice_Info.CurrencyID=Currency.ID and BillDate between @d1 and @d2 order by BillDate";
                cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "BillDate").Value = dtpInvoiceDateFrom.Value.Date;
                cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "BillDate").Value = dtpInvoiceDateTo.Value.Date;
                cmd.CommandType = CommandType.Text;
                myDA.SelectCommand = cmd;
                myDA.Fill(myDS, "Invoice_Info");
                myDA.Fill(myDS, "Currency");
                rpt.SetDataSource(myDS);
                crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCurrency.Text == "")
                {
                    MessageBox.Show("Please select currency", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCurrency.Focus();
                    return;
                }
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                rptSales rpt = new rptSales();
                //The report you created.
                cmd = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                DataSet myDS = new DataSet();
                //The DataSet you created.
                con = new SqlConnection(cs.DBConn);
                cmd.Connection = con;
                cmd.CommandText = "SELECT BillNo,BillDate,VATAmount,DiscountAmount,GrandTotal,CurrencyName from Invoice_Info,Currency where Invoice_Info.CurrencyID=Currency.ID and BillDate between @d1 and @d2 and CurrencyName='" + cmbCurrency.Text + "' order by BillDate";
                cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "BillDate").Value = dateTimePicker2.Value.Date;
                cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "BillDate").Value = dateTimePicker1.Value.Date;
                cmd.CommandType = CommandType.Text;
                myDA.SelectCommand = cmd;
                myDA.Fill(myDS, "Invoice_Info");
                myDA.Fill(myDS, "Currency");
                rpt.SetDataSource(myDS);
                crystalReportViewer2.ReportSource = rpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FillCombo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(CurrencyName) from Invoice_Info,Currency where Invoice_Info.CurrencyID=Currency.Id";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbCurrency.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            FillCombo();
        }
    }
}
