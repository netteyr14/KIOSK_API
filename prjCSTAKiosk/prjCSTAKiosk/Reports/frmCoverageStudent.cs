using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCSTAKiosk.Reports
{
    public partial class frmCoverageStudent : Form
    {
        public frmCoverageStudent()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportStudents reportStudent = new frmReportStudents();
            reportStudent.ShowDialog();
        }
    }
}
