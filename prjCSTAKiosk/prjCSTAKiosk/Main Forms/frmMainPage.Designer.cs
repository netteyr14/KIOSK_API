namespace prjCSTAKiosk
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsControls = new System.Windows.Forms.ToolStrip();
            this.tsStud_Man = new System.Windows.Forms.ToolStripButton();
            this.tsClass_Sched = new System.Windows.Forms.ToolStripButton();
            this.tsAtten_Moni = new System.Windows.Forms.ToolStripButton();
            this.tsAnnouncemet = new System.Windows.Forms.ToolStripButton();
            this.tsLost_Found = new System.Windows.Forms.ToolStripButton();
            this.tsSuggestion_Box = new System.Windows.Forms.ToolStripButton();
            this.tsLogout = new System.Windows.Forms.ToolStripButton();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsControls.SuspendLayout();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(59)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1394, 25);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1394, 103);
            this.label1.TabIndex = 3;
            this.label1.Text = "                  CSTA KIOSK SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsControls
            // 
            this.tsControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStud_Man,
            this.tsClass_Sched,
            this.tsAtten_Moni,
            this.tsAnnouncemet,
            this.tsLost_Found,
            this.tsSuggestion_Box,
            this.tsLogout});
            this.tsControls.Location = new System.Drawing.Point(0, 128);
            this.tsControls.Name = "tsControls";
            this.tsControls.Size = new System.Drawing.Size(1394, 25);
            this.tsControls.TabIndex = 6;
            this.tsControls.Text = "toolStrip1";
            // 
            // tsStud_Man
            // 
            this.tsStud_Man.Image = global::prjCSTAKiosk.Properties.Resources.Student_Management;
            this.tsStud_Man.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStud_Man.Margin = new System.Windows.Forms.Padding(13, 1, 13, 2);
            this.tsStud_Man.Name = "tsStud_Man";
            this.tsStud_Man.Size = new System.Drawing.Size(180, 22);
            this.tsStud_Man.Text = "STUDENT MANAGEMENT";
            this.tsStud_Man.Click += new System.EventHandler(this.tsStud_Man_Click);
            // 
            // tsClass_Sched
            // 
            this.tsClass_Sched.Image = global::prjCSTAKiosk.Properties.Resources.Schedule;
            this.tsClass_Sched.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClass_Sched.Margin = new System.Windows.Forms.Padding(13, 1, 13, 2);
            this.tsClass_Sched.Name = "tsClass_Sched";
            this.tsClass_Sched.Size = new System.Drawing.Size(135, 22);
            this.tsClass_Sched.Text = "CLASS SCHEDULE";
            this.tsClass_Sched.Click += new System.EventHandler(this.tsClass_Sched_Click);
            // 
            // tsAtten_Moni
            // 
            this.tsAtten_Moni.Image = global::prjCSTAKiosk.Properties.Resources.Attendance_Monitoring;
            this.tsAtten_Moni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAtten_Moni.Margin = new System.Windows.Forms.Padding(13, 1, 13, 2);
            this.tsAtten_Moni.Name = "tsAtten_Moni";
            this.tsAtten_Moni.Size = new System.Drawing.Size(204, 22);
            this.tsAtten_Moni.Text = "ATTENDANCE MONITORING";
            this.tsAtten_Moni.Click += new System.EventHandler(this.tsAtten_Moni_Click);
            // 
            // tsAnnouncemet
            // 
            this.tsAnnouncemet.Image = global::prjCSTAKiosk.Properties.Resources.Announcement;
            this.tsAnnouncemet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAnnouncemet.Margin = new System.Windows.Forms.Padding(13, 1, 13, 2);
            this.tsAnnouncemet.Name = "tsAnnouncemet";
            this.tsAnnouncemet.Size = new System.Drawing.Size(146, 22);
            this.tsAnnouncemet.Text = "ANNOUNCEMENTS";
            this.tsAnnouncemet.Click += new System.EventHandler(this.tsAnnouncemet_Click);
            // 
            // tsLost_Found
            // 
            this.tsLost_Found.Image = global::prjCSTAKiosk.Properties.Resources.Lost_and_Found;
            this.tsLost_Found.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLost_Found.Margin = new System.Windows.Forms.Padding(13, 1, 13, 2);
            this.tsLost_Found.Name = "tsLost_Found";
            this.tsLost_Found.Size = new System.Drawing.Size(108, 22);
            this.tsLost_Found.Text = "LOST/FOUND";
            this.tsLost_Found.Click += new System.EventHandler(this.tsLost_Found_Click);
            // 
            // tsSuggestion_Box
            // 
            this.tsSuggestion_Box.Image = global::prjCSTAKiosk.Properties.Resources.Box;
            this.tsSuggestion_Box.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSuggestion_Box.Margin = new System.Windows.Forms.Padding(13, 1, 13, 2);
            this.tsSuggestion_Box.Name = "tsSuggestion_Box";
            this.tsSuggestion_Box.Size = new System.Drawing.Size(142, 22);
            this.tsSuggestion_Box.Text = "SUGGESTION BOX";
            this.tsSuggestion_Box.Click += new System.EventHandler(this.tsSuggestion_Box_Click);
            // 
            // tsLogout
            // 
            this.tsLogout.Image = global::prjCSTAKiosk.Properties.Resources.Login;
            this.tsLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogout.Name = "tsLogout";
            this.tsLogout.Size = new System.Drawing.Size(71, 22);
            this.tsLogout.Text = "Logout";
            this.tsLogout.Click += new System.EventHandler(this.tsbLogout_Click);
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.pbLogo);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 153);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1394, 621);
            this.pContainer.TabIndex = 7;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Image = global::prjCSTAKiosk.Properties.Resources.CSTA_LOGO_20;
            this.pbLogo.Location = new System.Drawing.Point(372, 23);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(650, 574);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = global::prjCSTAKiosk.Properties.Resources.SIT_LOGOs;
            this.pictureBox1.Location = new System.Drawing.Point(34, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1394, 774);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.tsControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tsControls.ResumeLayout(false);
            this.tsControls.PerformLayout();
            this.pContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsControls;
        private System.Windows.Forms.ToolStripButton tsStud_Man;
        private System.Windows.Forms.ToolStripButton tsClass_Sched;
        private System.Windows.Forms.ToolStripButton tsAtten_Moni;
        private System.Windows.Forms.ToolStripButton tsAnnouncemet;
        private System.Windows.Forms.ToolStripButton tsLost_Found;
        private System.Windows.Forms.ToolStripButton tsSuggestion_Box;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolStripButton tsLogout;
    }
}