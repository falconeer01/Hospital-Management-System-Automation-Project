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
    public partial class Update_Info : Form
    {
        public Update_Info()
        {
            InitializeComponent();
        }

        public string tc;

        SQLConnection Connection = new SQLConnection();

        private void Update_Info_Load(object sender, EventArgs e)
        {
            tcBox.Text = tc;

            SqlCommand comm = new SqlCommand(
                $"select * from patients where patientTC = '{tc}' "
            , Connection.Connection());

            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read()) 
            {
                nameBox.Text = dr[1].ToString();
                surnameBox.Text = dr[2].ToString();
                phoneBox.Text = dr[4].ToString();
                passwordBox.Text = dr[5].ToString();
                if (dr[6].ToString() == "Male")
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                }
                else 
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = true;
                }
            }

            Connection.Connection().Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm2 = new SqlCommand(
                "update patients " +
                "set patientName = @p1, " +
                "patientSurname = @p2, " +
                "patientPhone = @p3, " +
                "patientPassword = @p4, " +
                "patientGender = @p5 " + 
                "where patientTC = @p6"
            , Connection.Connection());

            comm2.Parameters.AddWithValue("@p1", nameBox.Text);
            comm2.Parameters.AddWithValue("@p2", surnameBox.Text);
            comm2.Parameters.AddWithValue("@p3", phoneBox.Text);
            comm2.Parameters.AddWithValue("@p4", passwordBox.Text);
            comm2.Parameters.AddWithValue("@p5", checkBox1.Checked ? "Male" : "Female");
            comm2.Parameters.AddWithValue("@p6", tcBox.Text);

            comm2.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You successfully updated this patients data.");
        }
    }
}
