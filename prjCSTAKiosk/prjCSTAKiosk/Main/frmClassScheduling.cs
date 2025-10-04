using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCSTAKiosk.Main
{
    public partial class frmClassScheduling : Form
    {
        public frmClassScheduling()
        {
            InitializeComponent();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            Sub.frmDEClassSched clasSched = new Sub.frmDEClassSched();
            clasSched.ShowDialog();
        }
    }
}
