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
    public partial class Secretary_Panel : Form
    {
        public Secretary_Panel()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        public string tc;

        private void Secretary_Panel_Load(object sender, EventArgs e)
        {
            secTC.Text = tc;

            // ad-soyad çekme
            SqlCommand comm = new SqlCommand(
                "select secretaryFullname from secretaries " +
                $"where secretaryTC = '{tc}'"
            , Connection.Connection());

            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read()) 
            { 
                secFullName.Text = dr[0].ToString();
            }

            dr.Close();

            Connection.Connection().Close();

            // branşları datagride çekme
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "select branchName from branchs"
            , Connection.Connection());

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            // doktorları datagride çekme
            DataTable dt2 = new DataTable();

            SqlDataAdapter da2 = new SqlDataAdapter(
                "select * from doctors"
            , Connection.Connection());

            da2.Fill(dt2);

            dataGridView2.DataSource = dt2;

            // branşları comboboxa çekme
            SqlCommand comm2 = new SqlCommand(
                "select branchName from branchs"
            , Connection.Connection());

            SqlDataReader dr2 = comm2.ExecuteReader();

            while (dr2.Read()) 
            {
                branchBox.Items.Add(dr2[0].ToString());
            }

            dr2.Close();

            Connection.Connection().Close();
        }

        private void branchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // doktorları comboboxa çekme
            SqlCommand comm3 = new SqlCommand(
                "select doctorName, doctorSurname from doctors " +
                "where doctorBranch = @p1"
            , Connection.Connection());

            comm3.Parameters.AddWithValue("@p1", branchBox.Text);

            SqlDataReader dr3 = comm3.ExecuteReader();

            doctorBox.Items.Clear();

            while (dr3.Read())
            {
                doctorBox.Items.Add(dr3[0] + " " + dr3[1]);
            }

            dr3.Close();

            Connection.Connection().Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // randevu oluşturma
            SqlCommand comm4 = new SqlCommand(
                "insert into appointments(appoDate, appoHour, appoBranch, appoDoctor) " +
                "values(@p1, @p2, @p3, @p4)"
            , Connection.Connection());

            comm4.Parameters.AddWithValue("@p1", dateBox.Text);
            comm4.Parameters.AddWithValue("@p2", hourBox.Text);
            comm4.Parameters.AddWithValue("@p3", branchBox.Text);
            comm4.Parameters.AddWithValue("@p4", doctorBox.Text);

            comm4.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You created a new appointment");
        }

        private void createAnnounBtn_Click(object sender, EventArgs e)
        {
            // duyuru oluşturma
            SqlCommand comm5 = new SqlCommand(
                "insert into announcements(announM) " + 
                "values(@m1)"
            , Connection.Connection());

            comm5.Parameters.AddWithValue("@m1", announBox.Text);

            comm5.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You added a new annnouncement.");
        }

        private void toDocPanel_Click(object sender, EventArgs e)
        {
            Handle_Docs_Sec_ HDS = new Handle_Docs_Sec_();
            HDS.Show();
        }

        private void toBranchPanel_Click(object sender, EventArgs e)
        {
            Handle_Branch_Sec_ HBS = new Handle_Branch_Sec_();
            HBS.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm6 = new SqlCommand(
                "update appointments " + 
                "set appoDate = @a1, " +
                "appoHour = @a2, " +
                "appoBranch = @a3, " +
                "appoDoctor = @a4 " +
                "where appoID = @a5"
            , Connection.Connection());

            comm6.Parameters.AddWithValue("@a1", dateBox.Text);
            comm6.Parameters.AddWithValue("@a2", hourBox.Text);
            comm6.Parameters.AddWithValue("@a3", branchBox.Text);
            comm6.Parameters.AddWithValue("@a4", doctorBox.Text);
            comm6.Parameters.AddWithValue("@a5", IDBox.Text);

            comm6.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You updated this appointment.");
        }

        private void appoListBtn_Click(object sender, EventArgs e)
        {
            Appointments appo = new Appointments();
            appo.Show();
        }
    }
}
