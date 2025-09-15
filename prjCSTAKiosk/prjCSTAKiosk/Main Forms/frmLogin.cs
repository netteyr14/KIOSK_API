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
    public partial class Login : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);
        const int EM_SETCUEBANNER = 0x1501;
        public Login()
        {
            InitializeComponent();
            SendMessage(txtuname.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(txtpass.Handle, EM_SETCUEBANNER, 0, "Password");
            lblconfirmation.Visible = false;
            this.FormClosing += LoginForm_FormClosing;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() => this.ActiveControl = null));
        }

        private void pMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
                txtpass.PasswordChar = '\0'; 
            else
                txtpass.PasswordChar = '•';  
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (!cbShow.Checked && txtpass.Text.Length > 0)
                txtpass.PasswordChar = '•';
            else if (txtpass.Text.Length == 0)
                txtpass.PasswordChar = '\0'; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "" && txtpass.Text == "")
            {
                this.Hide(); 
                MainPage mpage = new MainPage();
                mpage.FormClosed += (s, args) => Application.Exit();  
                mpage.Show();             
                txtuname.Clear();
                txtpass.Clear();
                this.BeginInvoke((Action)(() => this.ActiveControl = null));
            }
            else
            {
                lblconfirmation.Visible = true;
                lblconfirmation.Text = "Invalid Credentials";
                MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }  
      
    }
}
