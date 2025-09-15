using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace prjCSTAKiosk
{
    public partial class Announcements : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);
        const int EM_SETCUEBANNER = 0x1501;
        ClasCon con = new ClasCon();
        public Announcements()
        {
            InitializeComponent();
            tsControls.ImageScalingSize = new Size(32, 32);
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Search by Title");
            dgvDesign();
        }

        private void dgvDesign()
        {
            DataGridView dgv = dgvAnn;

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 58, 99);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 35;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgv.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            dgv.DefaultCellStyle.ForeColor = Color.Black;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 212, 59);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.RowTemplate.Height = 30;
        }

        private void Announcements_Load(object sender, EventArgs e)
        {
            DataTable dt = con.GetDataTable("SELECT * FROM tblann");
            dgvAnn.DataSource = dt;
            dgvAnn.ClearSelection();
            dgvAnn.Tag = 0;
            this.BeginInvoke((Action)(() => this.ActiveControl = null));
        }

        private void tsadd_Ann_Click(object sender, EventArgs e)
        {
            ModalAnnouncements modalann = new ModalAnnouncements();
            modalann.ShowDialog();
        }
    }
}
