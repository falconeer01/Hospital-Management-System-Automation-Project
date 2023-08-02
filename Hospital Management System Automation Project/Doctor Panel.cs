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
    public partial class Doctor_Panel : Form
    {
        public Doctor_Panel()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        public string tc;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Doctor_Panel_Load(object sender, EventArgs e)
        {
            // doktorun tcsini çekme
            docTC.Text = tc;

            // doktorun ad-soyad bilgisini çekme
            SqlCommand comm = new SqlCommand(
                "select doctorName, doctorSurname from doctors " +
                $"where doctorTC = '{tc}'"
            , Connection.Connection());

            SqlDataReader dr = comm.ExecuteReader();

            if (dr.Read()) 
            {
                docFullName.Text = dr[0].ToString() + " " + dr[1].ToString();
            }

            dr.Close();

            Connection.Connection().Close();

            // doktorun randevularını çekme
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "select * from appointments " +
                $"where appoDoctor = '{docFullName.Text}'"
            , Connection.Connection());

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            diseaseBox.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void annBtn_Click(object sender, EventArgs e)
        {
            Announcements announcements = new Announcements();
            announcements.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Update_Doctor_Info_Doc_ UDI = new Update_Doctor_Info_Doc_();
            UDI.tc = docTC.Text;
            UDI.Show();
        }
    }
}
