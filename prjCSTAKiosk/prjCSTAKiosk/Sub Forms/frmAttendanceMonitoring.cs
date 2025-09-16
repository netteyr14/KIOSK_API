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
    public partial class Attendance_Monitoring : Form
    {
        ClasCon con = new ClasCon();
        public Attendance_Monitoring()
        {
            InitializeComponent();      
            dgvDesign(); 
        }

        private void dgvDesign()
        {
            DataGridView dgv = dgvAttenMoni;

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

        private void Attendance_Monitoring_Load(object sender, EventArgs e)
        {
            //DataTable dt = con.GetDataTable("SELECT * FROM tblam");
            //dgvAttenMoni.DataSource = dt;
            //dgvAttenMoni.ClearSelection();
            //dgvAttenMoni.Tag = 0;
            //this.BeginInvoke((Action)(() => this.ActiveControl = null));
        }
    }
}
