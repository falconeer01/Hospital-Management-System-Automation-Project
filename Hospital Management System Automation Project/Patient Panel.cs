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
    public partial class Patient_Info : Form
    {
        public Patient_Info()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        public string patientTc;

        private void Patient_Info_Load(object sender, EventArgs e)
        {
            // tc bilgisini çekme
            tcLbl.Text = patientTc;

            // ad soyad bilgisini çekme
            SqlCommand comm = new SqlCommand(
                "select patientName, patientSurname from patients " + 
                "where patientTC = @p1 "
            , Connection.Connection());

            comm.Parameters.AddWithValue("@p1", patientTc);

            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read()) 
            {
                fullNameLbl.Text = $"{dr[0]} {dr[1]}";
            }

            dr.Close();
            Connection.Connection().Close();

            // cinsiyet bilgisini çekme
            SqlCommand comm2 = new SqlCommand(
                "select patientGender from patients " +
                "where patientTC = @p2 "
            , Connection.Connection());

            comm2.Parameters.AddWithValue("@p2", patientTc);

            SqlDataReader dr2 = comm2.ExecuteReader();

            while (dr2.Read()) 
            {
                genderLbl.Text = $"{dr2[0]}";
            }

            dr2.Close();
            Connection.Connection().Close();

            // randevu bilgilerini çekme
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                $"select * from appointments where patientTC = {patientTc}"
            , Connection.Connection());

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            // branş bilgilerini çekme
            SqlCommand comm3 = new SqlCommand(
                $"select branchName from branchs "
            , Connection.Connection());

            SqlDataReader dr3 = comm3.ExecuteReader();

            while (dr3.Read()) 
            {
                branchsBox.Items.Add(dr3[0]);
            }

            dr3.Close();
            Connection.Connection().Close();
        }

        private void doctorsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // aktif randevu bilgilerini çekme
            DataTable dt2 = new DataTable();

            SqlDataAdapter da2 = new SqlDataAdapter(
                $"select * from appointments " +
                $"where appoBranch = '{branchsBox.Text}' " +
                $"and appoDoctor = '{doctorsBox.Text}' " +
                $"and appoStatus = 0"
            , Connection.Connection());

            da2.Fill(dt2);

            dataGridView2.DataSource = dt2;
        }

        private void branchsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // doktor bilgilerini çekme
            SqlCommand comm4 = new SqlCommand(
                "select doctorName, doctorSurname from doctors " +
                $"where doctorBranch = '{branchsBox.Text}' "
            , Connection.Connection());

            SqlDataReader dr4 = comm4.ExecuteReader();

            doctorsBox.Items.Clear();

            while (dr4.Read())
            {
                if (branchsBox.Text != "")
                {
                    doctorsBox.Items.Add($"{dr4[0]} {dr4[1]}");
                }
                else
                {
                    MessageBox.Show("First, you should choose a branch.");
                }
            }

            dr4.Close();
            Connection.Connection().Close();
        }

        private void updateLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Update_Info UI = new Update_Info();
            UI.tc = tcLbl.Text;
            UI.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;

            IDBox.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comm4 = new SqlCommand(
                "update appointments " +
                "set appoStatus = 1, " +
                "patientTC = @p1, " +
                "patientDisease = @p2 " +
                "where appoID = @p3"
            , Connection.Connection());

            comm4.Parameters.AddWithValue("@p1", tcLbl.Text);
            comm4.Parameters.AddWithValue("@p2", diseaseBox.Text);
            comm4.Parameters.AddWithValue("@p3", IDBox.Text);

            comm4.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You created a new appointment.");
        }
    }
}