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
    public partial class Handle_Docs_Sec_ : Form
    {
        public Handle_Docs_Sec_()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        private void Handle_Docs_Sec__Load(object sender, EventArgs e)
        {
            // doktorları datagride yansıtma
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "select * from doctors"
            , Connection.Connection());

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            // branşları comboboxa yansıtma
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            IDBox.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            nameBox.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            surnameBox.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            branchBox.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            TCBox.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            passwordBox.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand(
                "insert into doctors(doctorName, doctorSurname, doctorBranch, doctorTC, doctorPassword) " +
                "values(@p1, @p2, @p3, @p4, @p5)"
            , Connection.Connection());

            comm.Parameters.AddWithValue("@p1", nameBox.Text);
            comm.Parameters.AddWithValue("@p2", surnameBox.Text);
            comm.Parameters.AddWithValue("@p3", branchBox.Text);
            comm.Parameters.AddWithValue("@p4", TCBox.Text);
            comm.Parameters.AddWithValue("@p5", passwordBox.Text);

            comm.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You added a new doctor to the database");
        }

        private void branchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm3 = new SqlCommand(
                "update doctors " +
                "set doctorName = @s1, " +
                "doctorSurname = @s2, " +
                "doctorBranch = @s3, " +
                "doctorTC = @s4, " +
                "doctorPassword = @s5 " + 
                "where doctorID = @s6"
            , Connection.Connection());

            comm3.Parameters.AddWithValue("@s1", nameBox.Text);
            comm3.Parameters.AddWithValue("@s2", surnameBox.Text);
            comm3.Parameters.AddWithValue("@s3", branchBox.Text);
            comm3.Parameters.AddWithValue("@s4", TCBox.Text);
            comm3.Parameters.AddWithValue("@s5", passwordBox.Text);
            comm3.Parameters.AddWithValue("@s6", IDBox.Text);

            comm3.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You updated the doctors information.");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm4 = new SqlCommand(
                "delete from doctors " + 
                "where doctorID = @id"
            , Connection.Connection());

            comm4.Parameters.AddWithValue("@id", IDBox.Text);

            comm4.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You deleted the doctors information.");
        }
    }
}
