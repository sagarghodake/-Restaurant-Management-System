using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Restaurant_Management_System
{
    public partial class frmCustomersReport : Form
    {
      
        SqlConnection con = null;
        SqlCommand cmd = null;
        ConnectionString cs = new ConnectionString();
        public frmCustomersReport()
        {
            InitializeComponent();
        }

        private void frmCustomersReport_Load(object sender, EventArgs e)
        {
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                rptCustomers rpt = new rptCustomers();
                //The report you created.
                cmd = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                RMS_DBDataSet myDS = new RMS_DBDataSet();
                //The DataSet you created.
                con = new SqlConnection(cs.DBConn);
                cmd.Connection = con;
                cmd.CommandText = "SELECT * from Customer order by CustomerName";
                cmd.CommandType = CommandType.Text;
                myDA.SelectCommand = cmd;
                myDA.Fill(myDS, "Customer");
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
    }
}
