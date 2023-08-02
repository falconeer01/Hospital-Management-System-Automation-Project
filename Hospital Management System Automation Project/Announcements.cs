using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System_Automation_Project
{
    public partial class Announcements : Form
    {
        public Announcements()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        private void Announcements_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "select * from announcements"
            , Connection.Connection());

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
