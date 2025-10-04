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
    public partial class frmLostFound : Form
    {
        public frmLostFound()
        {
            InitializeComponent();
            tscboFilter.SelectedIndex = 0;
           
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            Sub.frmDELostFound lostfound = new Sub.frmDELostFound();
            lostfound.ShowDialog();
        }

        private void tsbClaim_Click(object sender, EventArgs e)
        {
            Sub.frmClaimItem claim = new Sub.frmClaimItem();
            claim.ShowDialog();
        }
    }
}
