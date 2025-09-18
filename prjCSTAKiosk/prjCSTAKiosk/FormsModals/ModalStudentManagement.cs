using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjCSTAKiosk
{
    public partial class ModalStudentManagement : Form
    {
        private SerialPort serial_port;
        ClasCon con = new ClasCon();
        public ModalStudentManagement()
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
                    if (!string.IsNullOrWhiteSpace(txtrfid_SM.Text))
                    {
                        DialogResult result = MessageBox.Show(
                            "This will overwrite the current RFID text. Continue?",
                            "Confirm Overwrite",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result != DialogResult.Yes)
                        {
                            return; // Don't overwrite
                        }
                    }

                    txtrfid_SM.Text = rfid; // Overwrite after confirmation or if empty
                });
            }
            catch (Exception ex)
            {
                // Optional: log or handle errors
                Cleaner();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void Cleaner()
        {
            foreach (Control obj in gbstud_management.Controls)
            {
                if (obj is TextBox)
                {
                    obj.Text = "";
                }
            }
        }

        private async void ModalStudentManagement_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboCOM.Items.AddRange(ports);

            if (ports.Length > 0)
                cboCOM.SelectedIndex = 0;
            else
                cboCOM.Items.Add("No COM ports found");

            var taskCourse = con.LoadComboBoxAsync(cbCourseSM, "tbl_course", "course_name", "course_id");
            var taskSection = con.LoadComboBoxAsync(cbSectionSM, "tbl_section", "student_section", "section_id");
            var taskYear = con.LoadComboBoxAsync(cbYearSM, "tbl_year", "year_level", "year_id");

            // load cbo's at the same time
            await Task.WhenAll(taskCourse, taskSection, taskYear);
        }

        private void btnCancel_SM_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbCourseSM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string selectedPort = cboCOM.SelectedItem != null ? cboCOM.SelectedItem.ToString() : "";

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
                    cboCOM.Enabled = false;
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
                    cboCOM.Enabled = true;
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

        private void btnSave_SM_Click(object sender, EventArgs e)
        {

        }
    }
}
