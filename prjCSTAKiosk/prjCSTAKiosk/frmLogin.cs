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
            if (await cls.login(txtUsername.Text, txtPassword.Text)) {
                frmMain main = new frmMain();
                this.Hide();
                main.Show();
            } else if (!await cls.login(txtUsername.Text, txtPassword.Text)) {
                MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
