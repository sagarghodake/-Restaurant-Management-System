using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Configuration;
using System.Security;
using System.Security.Permissions;
namespace Restaurant_Management_System
{
    class ConnectionString
    {

        // FileInfo f = new FileInfo("Database/MilkDatabase.mdf");

             //  con = new SqlConnection();
          // con.ConnectionString = @"server=.\sqlexpress;attachdbfilename=" + f.FullName + ";integrated Security=true;User Instance=true";
        public string DBConn = @"server=.\sqlexpress;attachdbfilename=|DataDirectory|\RMS_DB.mdf;integrated Security=true;User Instance=true";
     
       
    }
}
