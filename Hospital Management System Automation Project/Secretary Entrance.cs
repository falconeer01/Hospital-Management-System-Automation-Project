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
    public partial class Secretary_Entrance : Form
    {
        public Secretary_Entrance()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        private void enterBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand(
                "select * from secretaries " +
                "where secretaryFullname = @p1 " +
                "and secretaryTC = @p2"
            , Connection.Connection());

            comm.Parameters.AddWithValue("@p1", fullnameBox.Text);
            comm.Parameters.AddWithValue("@p2", tcBox.Text);

            SqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                Secretary_Panel SP = new Secretary_Panel();
                SP.tc = tcBox.Text;
                SP.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Wrong information.");
            }

            Connection.Connection().Close();
        }

        private void Secretary_Entrance_Load(object sender, EventArgs e)
        {

        }
    }
}
