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
    public partial class Update_Doctor_Info_Doc_ : Form
    {
        public Update_Doctor_Info_Doc_()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        public string tc;

        private void Update_Doctor_Info_Doc__Load(object sender, EventArgs e)
        {
            tcBox.Text = tc;

            // doktor bilgilerini otomatik getirme
            SqlCommand comm = new SqlCommand(
                "select * from doctors " +
                $"where doctorTC = '{tc}'"
            , Connection.Connection());

            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read()) 
            {
                IDBox.Text = dr[0].ToString();
                nameBox.Text = dr[1].ToString();
                surnameBox.Text = dr[2].ToString();
                branchBox.Text = dr[3].ToString();
                passwordBox.Text = dr[5].ToString();
            }

            dr.Close();

            Connection.Connection().Close();

            // branchboxa branch bilgilerini getirme
            SqlCommand comm3 = new SqlCommand(
                "select branchName from branchs"
            , Connection.Connection());

            SqlDataReader dr3 = comm3.ExecuteReader();

            while (dr3.Read()) 
            {
                branchBox.Items.Add(dr3[0].ToString());
            }

            dr3.Close();

            Connection.Connection().Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // doktor bilgilerini güncelleme
            SqlCommand comm2 = new SqlCommand(
                "update doctors " +
                "set doctorName = @p1, " +
                "doctorSurname = @p2, " +
                "doctorTC = @p3, " +
                "doctorBranch = @p4, " +
                "doctorPassword = @p5 " +
                "where doctorID = @p0"
            , Connection.Connection());

            comm2.Parameters.AddWithValue("@p1", nameBox.Text);
            comm2.Parameters.AddWithValue("@p2", surnameBox.Text);
            comm2.Parameters.AddWithValue("@p3", tcBox.Text);
            comm2.Parameters.AddWithValue("@p4", branchBox.Text);
            comm2.Parameters.AddWithValue("@p5", passwordBox.Text);
            comm2.Parameters.AddWithValue("@p0", IDBox.Text);

            comm2.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You updated this doctors info.");
        }
    }
}
