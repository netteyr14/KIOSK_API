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
    public partial class frmStudentManagement : Form
    {
        class_con cls = new class_con();
        public frmStudentManagement()
        {
            InitializeComponent();
            //need to for load initialization kasi load ng frmMain yung nag rurun if wala to
            this.Load += new System.EventHandler(this.frmStudentManagement_Load);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            Sub.frmDEStudent student = new Sub.frmDEStudent();
            student.ShowDialog();
        }

        private async void frmStudentManagement_Load(object sender, EventArgs e)
        {
            await cls.loaddgv(dgvStudent, "view_student_management");
            
            tscboFilter.Items.Add("Course");
            tscboFilter.Items.Add("Year");

            tscboFilter.SelectedIndex = 0;
        }

        private async void tscboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = tscboFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedFilter)) return;

            tscboSelection.ComboBox.DataSource = null;
            tscboSelection.Enabled = false;

            switch (selectedFilter)
            {
                case "Course":
                    await cls.loadcbo(tscboSelection, "tbl_course", "course_name", "course_id");
                    break;

                case "Year":
                    tscboSelection.Items.AddRange(new string[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
                    tscboSelection.SelectedIndex = 0;
                    break;
            }

            tscboSelection.Enabled = true;
        }

        private async void tsbSearch_Click(object sender, EventArgs e)
        {
            await cls.loaddgv(dgvStudent, "view_student_management", tstbSearch.Text, tscboSelection.Text);
        }

        private async void tsbRefresh_Click(object sender, EventArgs e)
        {
            await cls.loaddgv(dgvStudent, "view_student_management");
            dgvStudent.ClearSelection();
            dgvStudent.BeginInvoke((Action)(()=>dgvStudent.FindForm().ActiveControl=null));
        }
    }
}
