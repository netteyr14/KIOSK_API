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
    public partial class ModalLostFound : Form
    {
        public ModalLostFound()
        {
            InitializeComponent();
        }

        private void btnUpload_LF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofd.Title = "Select an Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbPreview_LF.Image = Image.FromFile(ofd.FileName);
                pbPreview_LF.SizeMode = PictureBoxSizeMode.StretchImage;

                txtIpath_LF.Text = ofd.FileName;
            }
        }

        private void ModalLostFound_Load(object sender, EventArgs e)
        {

        }
    }
}
