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
    public partial class frmReportStudents : Form
    {
        public frmReportStudents()
        {
            InitializeComponent();
        }

        private void frmReportStudents_Load(object sender, EventArgs e)
        {

            this.rvStudent.RefreshReport();
        }

        private void frmReportStudents_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
