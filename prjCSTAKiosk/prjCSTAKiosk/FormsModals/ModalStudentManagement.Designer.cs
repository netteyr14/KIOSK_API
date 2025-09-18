namespace prjCSTAKiosk
{
    partial class ModalStudentManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel_SM = new System.Windows.Forms.Button();
            this.btnSave_SM = new System.Windows.Forms.Button();
            this.gbstud_management = new System.Windows.Forms.GroupBox();
            this.cboCOM = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbYearSM = new System.Windows.Forms.ComboBox();
            this.cbSectionSM = new System.Windows.Forms.ComboBox();
            this.cbCourseSM = new System.Windows.Forms.ComboBox();
            this.txtlname_SM = new System.Windows.Forms.TextBox();
            this.txtmname_SM = new System.Windows.Forms.TextBox();
            this.txtfname_SM = new System.Windows.Forms.TextBox();
            this.txtrfid_SM = new System.Windows.Forms.TextBox();
            this.txtstudnum_SM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbstud_management.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCancel_SM);
            this.panel1.Controls.Add(this.btnSave_SM);
            this.panel1.Controls.Add(this.gbstud_management);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 611);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 56);
            this.label2.TabIndex = 11;
            this.label2.Text = "STUDENT INFORMATION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel_SM
            // 
            this.btnCancel_SM.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel_SM.FlatAppearance.BorderSize = 0;
            this.btnCancel_SM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_SM.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_SM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel_SM.Location = new System.Drawing.Point(359, 557);
            this.btnCancel_SM.Name = "btnCancel_SM";
            this.btnCancel_SM.Size = new System.Drawing.Size(96, 42);
            this.btnCancel_SM.TabIndex = 10;
            this.btnCancel_SM.Text = "Cancel";
            this.btnCancel_SM.UseVisualStyleBackColor = false;
            this.btnCancel_SM.Click += new System.EventHandler(this.btnCancel_SM_Click_1);
            // 
            // btnSave_SM
            // 
            this.btnSave_SM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSave_SM.FlatAppearance.BorderSize = 0;
            this.btnSave_SM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_SM.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_SM.ForeColor = System.Drawing.Color.White;
            this.btnSave_SM.Location = new System.Drawing.Point(257, 557);
            this.btnSave_SM.Name = "btnSave_SM";
            this.btnSave_SM.Size = new System.Drawing.Size(96, 42);
            this.btnSave_SM.TabIndex = 9;
            this.btnSave_SM.Text = "Save";
            this.btnSave_SM.UseVisualStyleBackColor = false;
            this.btnSave_SM.Click += new System.EventHandler(this.btnSave_SM_Click);
            // 
            // gbstud_management
            // 
            this.gbstud_management.Controls.Add(this.cboCOM);
            this.gbstud_management.Controls.Add(this.btnDisconnect);
            this.gbstud_management.Controls.Add(this.btnConnect);
            this.gbstud_management.Controls.Add(this.cbYearSM);
            this.gbstud_management.Controls.Add(this.cbSectionSM);
            this.gbstud_management.Controls.Add(this.cbCourseSM);
            this.gbstud_management.Controls.Add(this.txtlname_SM);
            this.gbstud_management.Controls.Add(this.txtmname_SM);
            this.gbstud_management.Controls.Add(this.txtfname_SM);
            this.gbstud_management.Controls.Add(this.txtrfid_SM);
            this.gbstud_management.Controls.Add(this.txtstudnum_SM);
            this.gbstud_management.Controls.Add(this.label11);
            this.gbstud_management.Controls.Add(this.label10);
            this.gbstud_management.Controls.Add(this.label9);
            this.gbstud_management.Controls.Add(this.label8);
            this.gbstud_management.Controls.Add(this.label7);
            this.gbstud_management.Controls.Add(this.label6);
            this.gbstud_management.Controls.Add(this.label5);
            this.gbstud_management.Controls.Add(this.label4);
            this.gbstud_management.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbstud_management.Location = new System.Drawing.Point(12, 64);
            this.gbstud_management.Name = "gbstud_management";
            this.gbstud_management.Size = new System.Drawing.Size(443, 487);
            this.gbstud_management.TabIndex = 8;
            this.gbstud_management.TabStop = false;
            // 
            // cboCOM
            // 
            this.cboCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCOM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCOM.FormattingEnabled = true;
            this.cboCOM.Location = new System.Drawing.Point(347, 458);
            this.cboCOM.Name = "cboCOM";
            this.cboCOM.Size = new System.Drawing.Size(90, 24);
            this.cboCOM.TabIndex = 11;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(245, 458);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(245, 458);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 23);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Visible = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cbYearSM
            // 
            this.cbYearSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearSM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYearSM.FormattingEnabled = true;
            this.cbYearSM.Location = new System.Drawing.Point(167, 361);
            this.cbYearSM.Name = "cbYearSM";
            this.cbYearSM.Size = new System.Drawing.Size(200, 25);
            this.cbYearSM.TabIndex = 8;
            // 
            // cbSectionSM
            // 
            this.cbSectionSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSectionSM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSectionSM.FormattingEnabled = true;
            this.cbSectionSM.Location = new System.Drawing.Point(167, 312);
            this.cbSectionSM.Name = "cbSectionSM";
            this.cbSectionSM.Size = new System.Drawing.Size(200, 25);
            this.cbSectionSM.TabIndex = 7;
            // 
            // cbCourseSM
            // 
            this.cbCourseSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseSM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourseSM.FormattingEnabled = true;
            this.cbCourseSM.Location = new System.Drawing.Point(167, 263);
            this.cbCourseSM.Name = "cbCourseSM";
            this.cbCourseSM.Size = new System.Drawing.Size(200, 25);
            this.cbCourseSM.TabIndex = 6;
            // 
            // txtlname_SM
            // 
            this.txtlname_SM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname_SM.Location = new System.Drawing.Point(166, 215);
            this.txtlname_SM.Name = "txtlname_SM";
            this.txtlname_SM.Size = new System.Drawing.Size(257, 27);
            this.txtlname_SM.TabIndex = 5;
            // 
            // txtmname_SM
            // 
            this.txtmname_SM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname_SM.Location = new System.Drawing.Point(167, 167);
            this.txtmname_SM.Name = "txtmname_SM";
            this.txtmname_SM.Size = new System.Drawing.Size(257, 27);
            this.txtmname_SM.TabIndex = 4;
            // 
            // txtfname_SM
            // 
            this.txtfname_SM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname_SM.Location = new System.Drawing.Point(167, 119);
            this.txtfname_SM.Name = "txtfname_SM";
            this.txtfname_SM.Size = new System.Drawing.Size(257, 27);
            this.txtfname_SM.TabIndex = 3;
            // 
            // txtrfid_SM
            // 
            this.txtrfid_SM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrfid_SM.Location = new System.Drawing.Point(167, 71);
            this.txtrfid_SM.Name = "txtrfid_SM";
            this.txtrfid_SM.Size = new System.Drawing.Size(257, 27);
            this.txtrfid_SM.TabIndex = 2;
            // 
            // txtstudnum_SM
            // 
            this.txtstudnum_SM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudnum_SM.Location = new System.Drawing.Point(167, 23);
            this.txtstudnum_SM.Name = "txtstudnum_SM";
            this.txtstudnum_SM.Size = new System.Drawing.Size(257, 27);
            this.txtstudnum_SM.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(87, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Section:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(107, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Year:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Course:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Middle Initial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "RFID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student Number:";
            // 
            // ModalStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(468, 611);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalStudentManagement";
            this.Load += new System.EventHandler(this.ModalStudentManagement_Load);
            this.panel1.ResumeLayout(false);
            this.gbstud_management.ResumeLayout(false);
            this.gbstud_management.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel_SM;
        private System.Windows.Forms.Button btnSave_SM;
        private System.Windows.Forms.GroupBox gbstud_management;
        private System.Windows.Forms.TextBox txtlname_SM;
        private System.Windows.Forms.TextBox txtmname_SM;
        private System.Windows.Forms.TextBox txtfname_SM;
        private System.Windows.Forms.TextBox txtrfid_SM;
        private System.Windows.Forms.TextBox txtstudnum_SM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbYearSM;
        private System.Windows.Forms.ComboBox cbSectionSM;
        private System.Windows.Forms.ComboBox cbCourseSM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCOM;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
    }
}