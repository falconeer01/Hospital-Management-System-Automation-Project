using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System_Automation_Project
{
    public partial class Patient_Sign_Up : Form
    {
        public Patient_Sign_Up()
        {
            InitializeComponent();
        }

        SQLConnection Connect = new SQLConnection();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand(
                "insert into patients(" +
                "patientName, patientSurname, patientTC, patientPhone, patientPassword, patientGender" +
                ")" +
                "values(@p1, @p2, @p3, @p4, @p5, @p6)"
                , Connect.Connection()
            );

            comm.Parameters.AddWithValue("@p1", nameBox.Text);
            comm.Parameters.AddWithValue("@p2", surnameBox.Text);
            comm.Parameters.AddWithValue("@p3", tcBox.Text);
            comm.Parameters.AddWithValue("@p4", phoneBox.Text);
            comm.Parameters.AddWithValue("@p5", passwordBox.Text);
            comm.Parameters.AddWithValue("@p6", checkBox1.Checked ? "Male" : "Female");

            comm.ExecuteNonQuery();

            Connect.Connection().Close();

            MessageBox.Show($"You successfully signed up. Your password is: {passwordBox.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
