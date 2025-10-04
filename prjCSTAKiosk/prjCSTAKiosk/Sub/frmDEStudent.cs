using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCSTAKiosk.Sub
{
    public partial class frmDEStudent : Form
    {
        public string filepath;
        public frmDEStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdImage.FileName = "";
            ofdImage.Title = "Select an Image";
            ofdImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = ofdImage.FileName;
                filepath = ofdImage.FileName;
            }
        }

      
    }
}
