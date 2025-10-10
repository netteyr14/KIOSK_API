using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjCSTAKiosk.Functions;
namespace prjCSTAKiosk.Maintenance
{
    public partial class frmCourse : Form
    {
        private class_con cls = new class_con();
        public frmCourse()
        {
            InitializeComponent();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmDECourse course = new frmDECourse();
            course.ShowDialog();
        }

        private async void frmCourse_Load(object sender, EventArgs e)
        {
            await cls.loaddgv(dgvSchedule, "load_tbl_course_dgv");
        }
    }
}
