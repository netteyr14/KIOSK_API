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
    public partial class Student_Management : Form
    {
        public string SelectedStudentNumber
        {
            get
            {
                if (dgvStud.SelectedRows.Count > 0)
                {
                    return dgvStud.SelectedRows[0].Cells["designName_stud_num"].Value.ToString(); //Yung cell dito is columnName. Iba pa to sa columnHeader sa dgv edit columns.
                }
                return null;
            }
        }

        ClasCon con = new ClasCon();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);
        const int EM_SETCUEBANNER = 0x1501;
        public Student_Management()
        {
            InitializeComponent();
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Search by Student Name or Number");
            tsControls.ImageScalingSize = new Size(32, 32);
            dgvDesign();
        }

        private void dgvDesign()
        {
            DataGridView dgv = dgvStud;

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

        private async void Student_Management_Load(object sender, EventArgs e)
        {
            //DataTable dt = con.GetDataTable("SELECT * FROM tblsm");
            //dgvStud.DataSource = dt;
            dgvStud.AutoGenerateColumns = false;
            dgvStud.ClearSelection();
<<<<<<< HEAD
            dgvStud.CurrentCell = null;
=======
>>>>>>> 7c6c2ccd053b229f6b52d9cbdc1f9023ecdd1bc0
            //dgvStud.Tag = 0;
            //this.BeginInvoke((Action)(() => this.ActiveControl = null));     

            await con.LoadDataAsync(dgvStud, "view_student_management");
        }

        private void tsadd_SM_Click(object sender, EventArgs e)
        {
            dgvStud.ClearSelection();
            ModalStudentManagement modalsm = new ModalStudentManagement();
            modalsm.ShowDialog();
        }

        private async void tsrefresh_SM_Click(object sender, EventArgs e)
        {
            dgvStud.ClearSelection();
            await con.LoadDataAsync(dgvStud, "view_student_management");
        }
    }
}
