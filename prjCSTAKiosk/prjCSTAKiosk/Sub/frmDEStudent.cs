using prjCSTAKiosk.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCSTAKiosk.Sub
{
    public partial class frmDEStudent : Form
    {
        private string filepath;
        private SerialPort serial_port;
        private class_con cls = new class_con();
        private student_obj student_info = new student_obj();
        public frmDEStudent()
        {
            InitializeComponent();
            // Initialize SerialPort
            serial_port = new SerialPort("COM4", 9600);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)// RFID RECIEVER
        {
            try
            {
                string rfid = serial_port.ReadLine().Trim();

                // safely update the UI from another thread
                this.Invoke((MethodInvoker)delegate
                {
                    // kung existing na yung rfid sa txtbox
                    if (!string.IsNullOrWhiteSpace(txtRFID.Text))
                    {
                        DialogResult result = MessageBox.Show(
                            "This will overwrite the current RFID text. Continue?",
                            "Confirm Overwrite",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result != DialogResult.Yes)
                        {
                            return; // don't overwrite
                        }
                    }

                    txtRFID.Text = rfid; // overwrite after confirmation or if empty
                });
            }
            catch (Exception ex)
            {
                // clear fields
                txtRFID.Text = "";
                txtStudNumber.Text = "";
                txtFname.Text = "";
                txtMname.Text = "";
                txtLname.Text = "";
                txtSection.Text = "";
                cboCourse.SelectedIndex = 0;
                cboYear.SelectedIndex = 0;
                MessageBox.Show("Error: " + ex.Message);
            }
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
                MessageBox.Show(filepath);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            student_info.stud_num = txtStudNumber.Text;
            student_info.rfid = txtRFID.Text;
            student_info.fname = txtFname.Text;
            student_info.mname = txtMname.Text;
            student_info.lname = txtLname.Text;
            student_info.course_no = Convert.ToInt32(cboCourse.SelectedValue);
            student_info.year_level = cboYear.Text;
            student_info.section = txtSection.Text;
            int isactive_entry = chkActive.Checked ? 1 : 0;
            student_info.isactive = isactive_entry;
            student_info.image_path = filepath;
            if (check_fields(gb_fields))
            {
                await cls.insert_student(student_info);
            }
            else {
                MessageBox.Show("Message: "+"Empty Fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void frmDEStudent_Load(object sender, EventArgs e)
        {
            await cls.loadcbo(cboCourse, "load_tbl_course_cbo", "course_name", "course_id");
            string[] ports = SerialPort.GetPortNames();
            cboCom.Items.AddRange(ports);

            if (ports.Length > 0)
                cboCom.SelectedIndex = 0;
            else
                cboCom.Items.Add("No COM ports found");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string selectedPort = cboCom.SelectedItem != null ? cboCom.SelectedItem.ToString() : "";

            if (!string.IsNullOrEmpty(selectedPort) && selectedPort.StartsWith("COM"))
            {
                try
                {
                    if (serial_port != null && serial_port.IsOpen)
                    {
                        MessageBox.Show("Already connected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    serial_port = new SerialPort(selectedPort, 9600);
                    serial_port.NewLine = "\r\n"; // optional, if your device uses newline
                    serial_port.DataReceived += SerialPort_DataReceived;
                    serial_port.Open();

                    MessageBox.Show(string.Format("Connected to {0}", selectedPort), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboCom.Enabled = false;
                    btnDisconnect.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex.Message), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid COM port.");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e) 
        {
            if (serial_port != null && serial_port.IsOpen)
            {
                try
                {
                    serial_port.Close();
                    serial_port.Dispose();
                    serial_port = null;

                    MessageBox.Show("Disconnected from COM port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboCom.Enabled = true;
                    btnDisconnect.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error disconnecting: {0}", ex.Message));
                }
            }
            else
            {
                MessageBox.Show("No COM port is currently connected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool check_fields(GroupBox gbox) {
            foreach (Control ctrl in gbox.Controls) {
                if (ctrl is TextBox textBox) {
                    if (string.IsNullOrEmpty(textBox.Text)) { 
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
