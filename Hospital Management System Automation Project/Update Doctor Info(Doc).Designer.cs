namespace Hospital_Management_System_Automation_Project
{
    partial class Update_Doctor_Info_Doc_
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
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tcBox = new System.Windows.Forms.MaskedTextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.branchBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(108, 112);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(143, 27);
            this.surnameBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Surname:";
            // 
            // tcBox
            // 
            this.tcBox.Location = new System.Drawing.Point(108, 162);
            this.tcBox.Mask = "00000000000";
            this.tcBox.Name = "tcBox";
            this.tcBox.Size = new System.Drawing.Size(143, 27);
            this.tcBox.TabIndex = 28;
            this.tcBox.ValidatingType = typeof(int);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 61);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(143, 27);
            this.nameBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(108, 263);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(143, 27);
            this.passwordBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Branch:";
            // 
            // branchBox
            // 
            this.branchBox.FormattingEnabled = true;
            this.branchBox.Location = new System.Drawing.Point(108, 214);
            this.branchBox.Name = "branchBox";
            this.branchBox.Size = new System.Drawing.Size(143, 27);
            this.branchBox.TabIndex = 34;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(108, 307);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 27);
            this.updateBtn.TabIndex = 35;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(108, 12);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(143, 27);
            this.IDBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "ID:";
            // 
            // Update_Doctor_Info_Doc_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(293, 341);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.branchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Update_Doctor_Info_Doc_";
            this.Text = "Update_Doctor_Info_Doc_";
            this.Load += new System.EventHandler(this.Update_Doctor_Info_Doc__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tcBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox branchBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label6;
    }
}