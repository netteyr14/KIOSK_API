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
    public partial class frmLogin : Form
    {
        class_con cls = new class_con();
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var result = await cls.login(txtUsername.Text, txtPassword.Text);
            if (result.success)
            {
                frmMain main = new frmMain(result.fullname ?? "none", result.role ?? "none");
                this.Hide();
                main.Show();
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
