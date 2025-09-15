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
        public Class_Sched()
        {
            InitializeComponent();
            tsControls.ImageScalingSize = new Size(32, 32);
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Search by Subject");
            dgvDesign();
        }

        private async Task LoadDataAsync()
        {
            string url = "http://192.168.1.7:8080/tbl_class_sched";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync(url);
                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(response);

                    // binding ng tables rows from dt(from response)
                    dgvCSched.DataSource = dt;
                    dgvCSched.ClearSelection();
                    dgvCSched.Tag = 0;
                    this.BeginInvoke((Action)(() => this.ActiveControl = null));
                }
                catch
                {
                    // If already bound to a DataTable clear lang yung rows to retain yung column at i load yung dt rows
                    if (dgvCSched.DataSource is DataTable dt)
                    {
                        dt.Rows.Clear();
                    }
                    else
                    {
                        dgvCSched.Rows.Clear(); // if walang na fetch na value si dt its either walang data or server is offline
                    }

                    MessageBox.Show("Message: Cannot connect to the server!",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Class_Sched_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
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
            ModalClassSched modalsc = new ModalClassSched();
            modalsc.Show();
        }

        private async void tsrefresh_CS_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }
    }
}
