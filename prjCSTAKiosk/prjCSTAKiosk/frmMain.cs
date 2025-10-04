using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCSTAKiosk
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void OpenForm(Form frm)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tDateTime.Start();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tDateTime_Tick(object sender, EventArgs e)
        {
            sslDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy | hh:mm:ss tt");
        }

        private void tsbSuggestion_Click(object sender, EventArgs e)
        {
            OpenForm(new frmSuggestions());
        }

        private void tsbLostFound_Click(object sender, EventArgs e)
        {
            OpenForm(new frmLostFound());
        }

        private void tsbStudentInfo_Click(object sender, EventArgs e)
        {
            OpenForm(new frmStudentManagement());
        }


        private void tsbAttendance_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAttendance());
        }

        private void tsbAnnouncement_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAnnouncement());
        }

        private void studentScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new frmScheduling());
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance.frmCourse course = new Maintenance.frmCourse();
            course.ShowDialog();
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance.frmFaculty faculty = new Maintenance.frmFaculty();
            faculty.ShowDialog();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance.frmSubject subject = new Maintenance.frmSubject();
            subject.ShowDialog();
        }

        private void devicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance.frmDevices device = new Maintenance.frmDevices();
            device.ShowDialog();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Systems.frmUser user = new Systems.frmUser();
            user.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Systems.frmAboutUs about = new Systems.frmAboutUs();
            about.ShowDialog();
        }

        private void listOfStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.frmCoverageStudent coverageStudent = new Reports.frmCoverageStudent();
            coverageStudent.ShowDialog();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.frmCoverageAttendance coverageAttendance = new Reports.frmCoverageAttendance();
            coverageAttendance.ShowDialog();
        }

        private void suggestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.frmReportSuggestion reportSuggest = new Reports.frmReportSuggestion();
            reportSuggest.ShowDialog();
        }

        private void classScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Main.frmClassScheduling());
        }

    }
}
