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
    public partial class ModalAnnouncements : Form
    {
        public ModalAnnouncements()
        {
            InitializeComponent();
        }

        private void btnUpload_Ann_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofd.Title = "Select an Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbPreview.Image = Image.FromFile(ofd.FileName);
                pbPreview.SizeMode = PictureBoxSizeMode.StretchImage;

                txtIpath_Ann.Text = ofd.FileName;
            }
        }
    }
}
