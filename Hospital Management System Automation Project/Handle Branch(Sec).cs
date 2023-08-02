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
    public partial class Handle_Branch_Sec_ : Form
    {
        public Handle_Branch_Sec_()
        {
            InitializeComponent();
        }

        SQLConnection Connection = new SQLConnection();

        private void Handle_Branch_Sec__Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(
                "select * from branchs"
            , Connection.Connection());

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            IDBox.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            nameBox.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand(
                "insert into branchs(branchName) " +
                "values(@b1)"
            , Connection.Connection());

            comm.Parameters.AddWithValue("@b1", nameBox.Text);

            comm.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You added a new branch to the database.");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm2 = new SqlCommand(
                "update branchs " +
                "set branchName = @b1 " +
                "where branchID = @b2"
            , Connection.Connection());

            comm2.Parameters.AddWithValue("@b1", nameBox.Text);
            comm2.Parameters.AddWithValue("@b2", IDBox.Text);

            comm2.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You updated this branch to the database.");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlCommand comm3 = new SqlCommand(
                "delete from branchs " + 
                "where branchID = @b1"
            , Connection.Connection());

            comm3.Parameters.AddWithValue("@b1", IDBox.Text);

            comm3.ExecuteNonQuery();

            Connection.Connection().Close();

            MessageBox.Show("You deleted this branch to the database.");
        }
    }
}
