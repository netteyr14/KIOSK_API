namespace prjCSTAKiosk
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbStudentInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScheduling = new System.Windows.Forms.ToolStripDropDownButton();
            this.studentScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAttendance = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAnnouncement = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLostFound = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSuggestion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tDateTime = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStudentInfo,
            this.toolStripSeparator1,
            this.tsbScheduling,
            this.toolStripSeparator2,
            this.tsbAttendance,
            this.toolStripSeparator3,
            this.tsbAnnouncement,
            this.toolStripSeparator4,
            this.tsbLostFound,
            this.toolStripSeparator6,
            this.tsbSuggestion,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1360, 55);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbStudentInfo
            // 
            this.tsbStudentInfo.Image = global::prjCSTAKiosk.Properties.Resources.icons8_student_48;
            this.tsbStudentInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStudentInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStudentInfo.Name = "tsbStudentInfo";
            this.tsbStudentInfo.Size = new System.Drawing.Size(197, 52);
            this.tsbStudentInfo.Text = "STUDENT MANAGEMENT";
            this.tsbStudentInfo.Click += new System.EventHandler(this.tsbStudentInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbScheduling
            // 
            this.tsbScheduling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentScheduleToolStripMenuItem,
            this.classScheduleToolStripMenuItem});
            this.tsbScheduling.Image = global::prjCSTAKiosk.Properties.Resources.icons8_class_48;
            this.tsbScheduling.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbScheduling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScheduling.Name = "tsbScheduling";
            this.tsbScheduling.Size = new System.Drawing.Size(144, 52);
            this.tsbScheduling.Text = "SCHEDULING";
            // 
            // studentScheduleToolStripMenuItem
            // 
            this.studentScheduleToolStripMenuItem.Name = "studentScheduleToolStripMenuItem";
            this.studentScheduleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.studentScheduleToolStripMenuItem.Text = "Student Schedule";
            this.studentScheduleToolStripMenuItem.Click += new System.EventHandler(this.studentScheduleToolStripMenuItem_Click);
            // 
            // classScheduleToolStripMenuItem
            // 
            this.classScheduleToolStripMenuItem.Name = "classScheduleToolStripMenuItem";
            this.classScheduleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.classScheduleToolStripMenuItem.Text = "Class Schedule";
            this.classScheduleToolStripMenuItem.Click += new System.EventHandler(this.classScheduleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbAttendance
            // 
            this.tsbAttendance.Image = global::prjCSTAKiosk.Properties.Resources.icons8_time_48;
            this.tsbAttendance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAttendance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAttendance.Name = "tsbAttendance";
            this.tsbAttendance.Size = new System.Drawing.Size(216, 52);
            this.tsbAttendance.Text = "ATTENDANCE MONITORING";
            this.tsbAttendance.Click += new System.EventHandler(this.tsbAttendance_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbAnnouncement
            // 
            this.tsbAnnouncement.Image = global::prjCSTAKiosk.Properties.Resources.icons8_announcement_48;
            this.tsbAnnouncement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAnnouncement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnnouncement.Name = "tsbAnnouncement";
            this.tsbAnnouncement.Size = new System.Drawing.Size(160, 52);
            this.tsbAnnouncement.Text = "ANNOUNCEMENT";
            this.tsbAnnouncement.Click += new System.EventHandler(this.tsbAnnouncement_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbLostFound
            // 
            this.tsbLostFound.Image = global::prjCSTAKiosk.Properties.Resources.icons8_lost_and_found_48;
            this.tsbLostFound.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLostFound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLostFound.Name = "tsbLostFound";
            this.tsbLostFound.Size = new System.Drawing.Size(163, 52);
            this.tsbLostFound.Text = "LOST AND FOUND";
            this.tsbLostFound.Click += new System.EventHandler(this.tsbLostFound_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbSuggestion
            // 
            this.tsbSuggestion.Image = global::prjCSTAKiosk.Properties.Resources.icons8_faq_48;
            this.tsbSuggestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSuggestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSuggestion.Name = "tsbSuggestion";
            this.tsbSuggestion.Size = new System.Drawing.Size(142, 52);
            this.tsbSuggestion.Text = "SUGGESTIONS";
            this.tsbSuggestion.Click += new System.EventHandler(this.tsbSuggestion_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1360, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseToolStripMenuItem,
            this.facultyToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.toolStripSeparator7,
            this.devicesToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.courseToolStripMenuItem.Text = "Courses";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.facultyToolStripMenuItem.Text = "Faculty";
            this.facultyToolStripMenuItem.Click += new System.EventHandler(this.facultyToolStripMenuItem_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.subjectToolStripMenuItem.Text = "Subjects";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(115, 6);
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.devicesToolStripMenuItem.Text = "Devices";
            this.devicesToolStripMenuItem.Click += new System.EventHandler(this.devicesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfStudentsToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.suggestionsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // listOfStudentsToolStripMenuItem
            // 
            this.listOfStudentsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.listOfStudentsToolStripMenuItem.Name = "listOfStudentsToolStripMenuItem";
            this.listOfStudentsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listOfStudentsToolStripMenuItem.Text = "List of Students";
            this.listOfStudentsToolStripMenuItem.Click += new System.EventHandler(this.listOfStudentsToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance Logs";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // suggestionsToolStripMenuItem
            // 
            this.suggestionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.suggestionsToolStripMenuItem.Name = "suggestionsToolStripMenuItem";
            this.suggestionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.suggestionsToolStripMenuItem.Text = "Suggestions";
            this.suggestionsToolStripMenuItem.Click += new System.EventHandler(this.suggestionsToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.userAccountToolStripMenuItem.Text = "User Account";
            this.userAccountToolStripMenuItem.Click += new System.EventHandler(this.userAccountToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sslUsername,
            this.toolStripStatusLabel2,
            this.sslPosition,
            this.sslDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1360, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "USER ACCOUNT";
            // 
            // sslUsername
            // 
            this.sslUsername.AutoSize = false;
            this.sslUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sslUsername.Name = "sslUsername";
            this.sslUsername.Size = new System.Drawing.Size(300, 17);
            this.sslUsername.Text = "JUAN DELA CRUZ";
            this.sslUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel2.Text = "DESIGNATION";
            // 
            // sslPosition
            // 
            this.sslPosition.AutoSize = false;
            this.sslPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sslPosition.Name = "sslPosition";
            this.sslPosition.Size = new System.Drawing.Size(300, 17);
            this.sslPosition.Text = "SUPER ADMINISTRATOR";
            this.sslPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sslDateTime
            // 
            this.sslDateTime.AutoSize = false;
            this.sslDateTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sslDateTime.Name = "sslDateTime";
            this.sslDateTime.Size = new System.Drawing.Size(559, 17);
            this.sslDateTime.Spring = true;
            this.sslDateTime.Text = "DATE/TIME";
            this.sslDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tDateTime
            // 
            this.tDateTime.Tick += new System.EventHandler(this.tDateTime_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 729);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSTA Kiosk | Main Window [Developed by SIT Students]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbStudentInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAttendance;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbAnnouncement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbLostFound;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbSuggestion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem listOfStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggestionsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sslUsername;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel sslPosition;
        private System.Windows.Forms.ToolStripStatusLabel sslDateTime;
        private System.Windows.Forms.Timer tDateTime;
        private System.Windows.Forms.ToolStripDropDownButton tsbScheduling;
        private System.Windows.Forms.ToolStripMenuItem studentScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
    }
}