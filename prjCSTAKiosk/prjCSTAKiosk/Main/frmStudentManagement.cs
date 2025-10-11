using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjCSTAKiosk.Functions;
namespace prjCSTAKiosk
{
    public partial class frmStudentManagement : Form
    {
        private class_con cls = new class_con();
        private student_obj student_info = new student_obj();
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
            dgvStudent.Tag = "";
            await cls.loaddgv(dgvStudent, "load_tbl_student_management");
            
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
                    await cls.loadcbo_ts(tscboSelection, "load_tbl_course_cbo", "course_name", "course_id");
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
            await cls.loaddgv(dgvStudent, "load_tbl_student_management", tstbSearch.Text, tscboSelection.Text);
        }

        private async void tsbRefresh_Click(object sender, EventArgs e)
        {
            dgvStudent.Tag = "";
            await cls.loaddgv(dgvStudent, "load_tbl_student_management");
            dgvStudent.ClearSelection();
            dgvStudent.BeginInvoke((Action)(()=>dgvStudent.FindForm().ActiveControl=null));
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dgvStudent.Tag.ToString()))
            {
                Sub.frmDEStudent student = new Sub.frmDEStudent(student_info, dgvStudent.Tag.ToString());
                student.ShowDialog();
            }
            else {
                MessageBox.Show("Message: Please select a rows first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                DataGridViewRow selected_row = dgvStudent.Rows[e.RowIndex];
                dgvStudent.Tag = selected_row.Cells[0].Value.ToString();
                student_info.stud_num = selected_row.Cells[0].Value.ToString();
                student_info.rfid = selected_row.Cells[1].Value.ToString();
                student_info.fname = selected_row.Cells[2].Value.ToString();
                student_info.mname = selected_row.Cells[3].Value.ToString();
                student_info.lname = selected_row.Cells[4].Value.ToString();
                student_info.course_name = selected_row.Cells[5].Value.ToString();
                student_info.year_level = selected_row.Cells[6].Value.ToString();
                student_info.section = selected_row.Cells[7].Value.ToString();
                student_info.isactive = Convert.ToInt32(selected_row.Cells[8].Value.ToString());
            }
        }

        private async void tsbDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dgvStudent.Tag.ToString()))
            {
                await cls.CUD_Operation_Student(student_info, "delete_student_information");
            }
            else
            {
                MessageBox.Show("Message: Please select a rows first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
