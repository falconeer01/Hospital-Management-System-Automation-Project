using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System_Automation_Project
{
    public partial class Patient_Entrance : Form
    {
        public Patient_Entrance()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        private void signUpBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patient_Sign_Up frmPSU = new Patient_Sign_Up();
            frmPSU.Show();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand(
                "select * from patients " +
                "where patientName = @p1 " +
                "and patientTC = @p2"
            , Connection.Connection());

            comm.Parameters.AddWithValue("@p1", nameBox.Text);
            comm.Parameters.AddWithValue("@p2", tcBox.Text);

            SqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                Patient_Info PI = new Patient_Info();
                PI.patientTc = tcBox.Text;
                PI.Show();
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
