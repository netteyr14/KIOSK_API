using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//FOR HTTP REQUEST NATIN
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace prjCSTAKiosk
{
    public partial class Class_Sched : Form
    {
        ClasCon con = new ClasCon();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);
        const int EM_SETCUEBANNER = 0x1501;

        private string studentNumber;
        public Class_Sched(string studNumber)
        {
            InitializeComponent();
            SetStudent(studNumber);
            tsControls.ImageScalingSize = new Size(32, 32);
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Search by Subject");
            dgvDesign();
        }

        private async void Class_Sched_Load(object sender, EventArgs e)
        {
            lblSelectedStudName.Text = studentNumber;
            dgvCSched.AutoGenerateColumns = false;
            dgvCSched.ClearSelection();
            dgvCSched.CurrentCell = null;
            //var parameters = new Dictionary<string, string>
            //{
            //    { "stud_number", studentNumber }  // or whatever parameter your API expects
            //};

            //await con.LoadDataAsync(dgvCSched, "view_class_sched", parameters);
        }

        private void dgvDesign()
        {
            DataGridView dgv = dgvCSched;

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

        private void tsadd_CS_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(studentNumber);
            dgvCSched.ClearSelection();
            ModalClassSched modalsc = new ModalClassSched();
            modalsc.Show();
        }

        private async void tsrefresh_CS_Click(object sender, EventArgs e)
        {
            var parameters = new Dictionary<string, string>
            {
                { "stud_number", studentNumber }  // or whatever parameter your API expects
            };

            await con.LoadDataAsync(dgvCSched, "view_class_sched", parameters);
        }

        public void SetStudent(string studNumber)
        {
            studentNumber = studNumber;
            lblSelectedStudName.Text = studentNumber;

            // reload the grid or any dependent data
            _ = con.LoadDataAsync(dgvCSched, "view_class_sched",
                new Dictionary<string, string> { { "stud_number", studentNumber } });
        }
    }
}
