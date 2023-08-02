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
    public partial class Doctor_Entrance : Form
    {
        public Doctor_Entrance()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        private void Doctor_Entrance_Load(object sender, EventArgs e)
        {
            
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand(
                "select doctorName, doctorTC from doctors " +
                "where doctorName = @d1 " +
                "and doctorTC = @d2"
            , Connection.Connection());

            comm.Parameters.AddWithValue("@d1", nameBox.Text);
            comm.Parameters.AddWithValue("@d2", tcBox.Text);

            SqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                Doctor_Panel DP = new Doctor_Panel();
                DP.tc = tcBox.Text;
                DP.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Wrong information.");
            }

            dr.Close();

            Connection.Connection().Close();
        }
    }
}
