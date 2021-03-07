using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Security;
using System.Security.Permissions;

namespace GlassStoreSoft.Classes
{
   
   public  class CodeClass
    {
       public SqlConnection con;
       public SqlDataReader DR;
       public SqlDataReader DR1;
       public SqlDataReader DR2;
       public SqlCommand CMD;

       [SqlClientPermissionAttribute(SecurityAction.Demand, ConnectionString = " Data Source=localhost;Integrated Security=true;Initial Catalog=Northwind;")]
       public void ConnectToDatabase()
       {

           try
           {
            
         //FileInfo f = new FileInfo("../../Database/MilkDatabase.mdf");
              FileInfo f = new FileInfo("Database/MilkDatabase.mdf");

               con = new SqlConnection();
             con.ConnectionString = @"server=.\sqlexpress;attachdbfilename=" + f.FullName + ";integrated Security=true;User Instance=true";


               //  con.ConnectionString = ConfigurationManager.ConnectionStrings["JwalarySoft.Properties.Settings.JwalaryDatabaseConnectionString"].ConnectionString;

               con.Open();

           }
           catch
           { }
           
       }

       public void Disconnect()
       {
           if (con != null)
           {
               if (con.State == ConnectionState.Open)
                   con.Close();
           }
       }

        public void FillCombo(ComboBox cmb, String sql, String dismemb, String valuemeber)
        {
            DataTable dt = GetTable(sql);

            cmb.DataSource = dt;
            cmb.DisplayMember = dismemb;
            cmb.ValueMember = valuemeber;

            if (cmb.Items.Count > 0) cmb.SelectedIndex = 0;
        }

        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return dt;
            }
        }


        public void FillGrid(DataGridView dv, string sql)
        {
            DataTable dt = GetTable(sql);
            
            dv.DataSource = dt;
           

        }

        public void ExecuteSqlCommand(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillListView(ListView lv, string sql)
        {
            DataTable dt = GetTable(sql);
            String[] s = new string[dt.Columns.Count];
            lv.GridLines = true;
            lv.MultiSelect = false;
            lv.FullRowSelect = true;

            lv.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    s[i] = dr[i].ToString();
                }
                lv.Items.Add(new ListViewItem(s));

            }
           

        }

        public void FillGrid1(DataGridView dv, string sql)
        {
            
            DataTable dt = GetTable(sql);

            dv.DataSource = dt;
            dv.Sort(dv.Columns[0], System.ComponentModel.ListSortDirection.Ascending); 

        }


      public  void Marathi_Culture()
        {
            System.Globalization.CultureInfo a = new System.Globalization.CultureInfo("mr-IN");

            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(a);

        }
      public void SELECT1(string CmdText)
      {

          CMD = new SqlCommand(CmdText, con);
      }



      public void English_Culture()
        {
            System.Globalization.CultureInfo a = new System.Globalization.CultureInfo("EN-US");

            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(a);

        }
    }
}
