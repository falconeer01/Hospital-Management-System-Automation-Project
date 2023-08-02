namespace Hospital_Management_System_Automation_Project
{
    partial class Patient_Entrance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.tcBox = new System.Windows.Forms.MaskedTextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(148, 66);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(143, 27);
            this.nameBox.TabIndex = 2;
            // 
            // tcBox
            // 
            this.tcBox.Location = new System.Drawing.Point(148, 113);
            this.tcBox.Mask = "00000000000";
            this.tcBox.Name = "tcBox";
            this.tcBox.Size = new System.Drawing.Size(143, 27);
            this.tcBox.TabIndex = 3;
            this.tcBox.ValidatingType = typeof(int);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(148, 158);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 27);
            this.enterBtn.TabIndex = 4;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.AutoSize = true;
            this.signUpBtn.Location = new System.Drawing.Point(229, 162);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(62, 19);
            this.signUpBtn.TabIndex = 5;
            this.signUpBtn.TabStop = true;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpBtn_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(120, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient Entrance";
            // 
            // Patient_Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(412, 203);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.tcBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Patient_Entrance";
            this.Text = "Patient Entrance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.MaskedTextBox tcBox;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.LinkLabel signUpBtn;
        private System.Windows.Forms.Label label3;
    }
}