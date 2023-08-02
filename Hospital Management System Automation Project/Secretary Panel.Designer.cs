namespace Hospital_Management_System_Automation_Project
{
    partial class Secretary_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secTC = new System.Windows.Forms.Label();
            this.secFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createAnnounBtn = new System.Windows.Forms.Button();
            this.announBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.hourBox = new System.Windows.Forms.MaskedTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.MaskedTextBox();
            this.doctorBox = new System.Windows.Forms.ComboBox();
            this.branchBox = new System.Windows.Forms.ComboBox();
            this.TXBox = new System.Windows.Forms.MaskedTextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.statusCheck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.appoListBtn = new System.Windows.Forms.Button();
            this.toBranchPanel = new System.Windows.Forms.Button();
            this.toDocPanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secTC);
            this.groupBox1.Controls.Add(this.secFullName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Info";
            // 
            // secTC
            // 
            this.secTC.AutoSize = true;
            this.secTC.Location = new System.Drawing.Point(105, 74);
            this.secTC.Name = "secTC";
            this.secTC.Size = new System.Drawing.Size(50, 19);
            this.secTC.TabIndex = 7;
            this.secTC.Text = "label4";
            // 
            // secFullName
            // 
            this.secFullName.AutoSize = true;
            this.secFullName.Location = new System.Drawing.Point(105, 36);
            this.secFullName.Name = "secFullName";
            this.secFullName.Size = new System.Drawing.Size(49, 19);
            this.secFullName.TabIndex = 6;
            this.secFullName.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createAnnounBtn);
            this.groupBox2.Controls.Add(this.announBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcement";
            // 
            // createAnnounBtn
            // 
            this.createAnnounBtn.Location = new System.Drawing.Point(7, 168);
            this.createAnnounBtn.Name = "createAnnounBtn";
            this.createAnnounBtn.Size = new System.Drawing.Size(239, 27);
            this.createAnnounBtn.TabIndex = 1;
            this.createAnnounBtn.Text = "Create";
            this.createAnnounBtn.UseVisualStyleBackColor = true;
            this.createAnnounBtn.Click += new System.EventHandler(this.createAnnounBtn_Click);
            // 
            // announBox
            // 
            this.announBox.Location = new System.Drawing.Point(7, 27);
            this.announBox.Name = "announBox";
            this.announBox.Size = new System.Drawing.Size(239, 135);
            this.announBox.TabIndex = 0;
            this.announBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateBtn);
            this.groupBox3.Controls.Add(this.hourBox);
            this.groupBox3.Controls.Add(this.saveBtn);
            this.groupBox3.Controls.Add(this.dateBox);
            this.groupBox3.Controls.Add(this.doctorBox);
            this.groupBox3.Controls.Add(this.branchBox);
            this.groupBox3.Controls.Add(this.TXBox);
            this.groupBox3.Controls.Add(this.IDBox);
            this.groupBox3.Controls.Add(this.statusCheck);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(276, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 318);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(117, 281);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(79, 31);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(84, 98);
            this.hourBox.Mask = "00:00";
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(100, 27);
            this.hourBox.TabIndex = 21;
            this.hourBox.ValidatingType = typeof(System.DateTime);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(6, 281);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(79, 31);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(84, 65);
            this.dateBox.Mask = "00/00/0000";
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(100, 27);
            this.dateBox.TabIndex = 20;
            this.dateBox.ValidatingType = typeof(System.DateTime);
            // 
            // doctorBox
            // 
            this.doctorBox.FormattingEnabled = true;
            this.doctorBox.Location = new System.Drawing.Point(84, 169);
            this.doctorBox.Name = "doctorBox";
            this.doctorBox.Size = new System.Drawing.Size(100, 27);
            this.doctorBox.TabIndex = 19;
            // 
            // branchBox
            // 
            this.branchBox.FormattingEnabled = true;
            this.branchBox.Location = new System.Drawing.Point(84, 136);
            this.branchBox.Name = "branchBox";
            this.branchBox.Size = new System.Drawing.Size(100, 27);
            this.branchBox.TabIndex = 18;
            this.branchBox.SelectedIndexChanged += new System.EventHandler(this.branchBox_SelectedIndexChanged);
            // 
            // TXBox
            // 
            this.TXBox.Location = new System.Drawing.Point(84, 204);
            this.TXBox.Mask = "00000000000";
            this.TXBox.Name = "TXBox";
            this.TXBox.Size = new System.Drawing.Size(100, 27);
            this.TXBox.TabIndex = 17;
            this.TXBox.ValidatingType = typeof(int);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(84, 28);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 27);
            this.IDBox.TabIndex = 14;
            // 
            // statusCheck
            // 
            this.statusCheck.AutoSize = true;
            this.statusCheck.Location = new System.Drawing.Point(84, 238);
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Size = new System.Drawing.Size(100, 23);
            this.statusCheck.TabIndex = 13;
            this.statusCheck.Text = "checkBox1";
            this.statusCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doctor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(484, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 200);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branchs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(12, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(784, 167);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(778, 141);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.appoListBtn);
            this.groupBox6.Controls.Add(this.toDocPanel);
            this.groupBox6.Controls.Add(this.toBranchPanel);
            this.groupBox6.Location = new System.Drawing.Point(487, 215);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(309, 115);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fast Accsess";
            // 
            // appoListBtn
            // 
            this.appoListBtn.Location = new System.Drawing.Point(92, 68);
            this.appoListBtn.Name = "appoListBtn";
            this.appoListBtn.Size = new System.Drawing.Size(135, 32);
            this.appoListBtn.TabIndex = 2;
            this.appoListBtn.Text = "Appointment List";
            this.appoListBtn.UseVisualStyleBackColor = true;
            this.appoListBtn.Click += new System.EventHandler(this.appoListBtn_Click);
            // 
            // toBranchPanel
            // 
            this.toBranchPanel.Location = new System.Drawing.Point(189, 21);
            this.toBranchPanel.Name = "toBranchPanel";
            this.toBranchPanel.Size = new System.Drawing.Size(114, 32);
            this.toBranchPanel.TabIndex = 1;
            this.toBranchPanel.Text = "Branch Panel";
            this.toBranchPanel.UseVisualStyleBackColor = true;
            this.toBranchPanel.Click += new System.EventHandler(this.toBranchPanel_Click);
            // 
            // toDocPanel
            // 
            this.toDocPanel.Location = new System.Drawing.Point(6, 21);
            this.toDocPanel.Name = "toDocPanel";
            this.toDocPanel.Size = new System.Drawing.Size(120, 32);
            this.toDocPanel.TabIndex = 0;
            this.toDocPanel.Text = "Doctor Panel";
            this.toDocPanel.UseVisualStyleBackColor = true;
            this.toDocPanel.Click += new System.EventHandler(this.toDocPanel_Click);
            // 
            // Secretary_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(805, 501);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Secretary_Panel";
            this.Text = "Secretary_Panel";
            this.Load += new System.EventHandler(this.Secretary_Panel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label secTC;
        private System.Windows.Forms.Label secFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button createAnnounBtn;
        private System.Windows.Forms.RichTextBox announBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox statusCheck;
        private System.Windows.Forms.MaskedTextBox dateBox;
        private System.Windows.Forms.ComboBox doctorBox;
        private System.Windows.Forms.ComboBox branchBox;
        private System.Windows.Forms.MaskedTextBox TXBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.MaskedTextBox hourBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button appoListBtn;
        private System.Windows.Forms.Button toBranchPanel;
        private System.Windows.Forms.Button toDocPanel;
    }
}