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
    public partial class frmAnnouncement : Form
    {
        public frmAnnouncement()
        {
            InitializeComponent();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            Sub.frmDEAnnouncement announc = new Sub.frmDEAnnouncement();
            announc.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvAnnouncement.Tag.ToString()) > 0)
            {
                Sub.frmDEAnnouncement announc = new Sub.frmDEAnnouncement();
                announc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select record to edit.", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmAnnouncement_Load(object sender, EventArgs e)
        {
            dgvAnnouncement.Tag = 0;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvAnnouncement.Tag.ToString()) > 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete a selected record?", "Announcement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                }
            }
            else
            {
                MessageBox.Show("Please select record to edit.", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
