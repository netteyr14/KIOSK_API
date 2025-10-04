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
    public partial class frmCoverageAttendance : Form
    {
        public frmCoverageAttendance()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportAttendance reportAttendance = new frmReportAttendance();
            reportAttendance.ShowDialog();
        }
    }
}
