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
        }
    }
}
