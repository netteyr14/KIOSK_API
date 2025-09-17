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
    public partial class MainPage : Form
    {
        private Student_Management studManForm;
        private Class_Sched sched;
        private Attendance_Monitoring amForm;
        private Announcements annForm;
        private Lost_Found lfForm;
        private Suggestion_Box sbForm;

        public MainPage()
        {
            InitializeComponent();
            tsLogout.Alignment = ToolStripItemAlignment.Right;          
            tsControls.ImageScalingSize = new Size(45, 45);
        }

        private void LoadForm(Form form)
        {
            pContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pContainer.Controls.Add(form);
            form.Show();
            form.BringToFront();
            form.Refresh();
            pContainer.ResumeLayout();
            pContainer.PerformLayout();
        }

        private void ToggleForm<T>(ref T formRef, Func<T> createForm) where T : Form
        {
            if (formRef != null && pContainer.Controls.Contains(formRef))
            {
                pContainer.Controls.Clear();
                pbLogo.Visible = true;
            }
            else
            {
                if (formRef == null || formRef.IsDisposed)
                    formRef = createForm();
                LoadForm(formRef);
                pbLogo.Visible = false;
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
        }

        private void tsbLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login log = new Login();
                log.Show();
            }
        }

        private void tsStud_Man_Click(object sender, EventArgs e)
        {
            ToggleForm(ref studManForm, () => new Student_Management());
        }

        private void tsClass_Sched_Click(object sender, EventArgs e)
        {
            if (studManForm != null && !studManForm.IsDisposed)
            {
                string studNumber = studManForm.SelectedStudentNumber;

                if (!string.IsNullOrEmpty(studNumber))
                {
                    ToggleForm(ref sched, () => new Class_Sched(studNumber));
                }
                else
                {
                    MessageBox.Show("Please select a student first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Student Management form is not open.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void tsAtten_Moni_Click(object sender, EventArgs e)
        {
            ToggleForm(ref amForm, () => new Attendance_Monitoring());
        }

        private void tsAnnouncemet_Click(object sender, EventArgs e)
        {
            ToggleForm(ref annForm, () => new Announcements());
        }

        private void tsLost_Found_Click(object sender, EventArgs e)
        {
            ToggleForm(ref lfForm, () => new Lost_Found());
        }

        private void tsSuggestion_Box_Click(object sender, EventArgs e)
        {
            ToggleForm(ref sbForm, () => new Suggestion_Box());
        }
    }
}
