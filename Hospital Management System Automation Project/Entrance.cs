using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System_Automation_Project
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            Patient_Entrance frmPE = new Patient_Entrance();
            frmPE.Show();
            this.Hide();
        }

        private void docBtn_Click(object sender, EventArgs e)
        {
            Doctor_Entrance frmDE = new Doctor_Entrance();
            frmDE.Show();
            this.Hide();
        }

        private void secBtn_Click(object sender, EventArgs e)
        {
            Secretary_Entrance frmSE = new Secretary_Entrance();
            frmSE.Show();
            this.Hide();
        }
    }
}
