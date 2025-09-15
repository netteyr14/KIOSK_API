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
    public partial class ModalStudentManagement : Form
    {
        public ModalStudentManagement()
        {
            InitializeComponent();
        }

        private void ModalStudentManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_SM_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
