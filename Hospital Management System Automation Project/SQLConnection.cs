using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Management_System_Automation_Project
{
    internal class SQLConnection
    {
        public SqlConnection Connection ()
        {
            SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-2AK7Q68\\SQLEXPRESS;Initial Catalog=hospitalDB;Integrated Security=True"
            );
            conn.Open ();
            return conn;
        }
    }
}
