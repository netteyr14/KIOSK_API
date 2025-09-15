namespace prjCSTAKiosk
{
    partial class Attendance_Monitoring
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
            this.pAttenMoni = new System.Windows.Forms.Panel();
            this.pDgv = new System.Windows.Forms.Panel();
            this.dgvAttenMoni = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pAttenMoni.SuspendLayout();
            this.pDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttenMoni)).BeginInit();
            this.pSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pAttenMoni
            // 
            this.pAttenMoni.Controls.Add(this.pSearch);
            this.pAttenMoni.Controls.Add(this.pDgv);
            this.pAttenMoni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAttenMoni.Location = new System.Drawing.Point(0, 0);
            this.pAttenMoni.Name = "pAttenMoni";
            this.pAttenMoni.Size = new System.Drawing.Size(1321, 745);
            this.pAttenMoni.TabIndex = 0;
            // 
            // pDgv
            // 
            this.pDgv.Controls.Add(this.dgvAttenMoni);
            this.pDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgv.Location = new System.Drawing.Point(0, 0);
            this.pDgv.Name = "pDgv";
            this.pDgv.Size = new System.Drawing.Size(1321, 745);
            this.pDgv.TabIndex = 14;
            // 
            // dgvAttenMoni
            // 
            this.dgvAttenMoni.AllowUserToAddRows = false;
            this.dgvAttenMoni.AllowUserToDeleteRows = false;
            this.dgvAttenMoni.AllowUserToResizeColumns = false;
            this.dgvAttenMoni.AllowUserToResizeRows = false;
            this.dgvAttenMoni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttenMoni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttenMoni.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttenMoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttenMoni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvAttenMoni.Location = new System.Drawing.Point(12, 89);
            this.dgvAttenMoni.Name = "dgvAttenMoni";
            this.dgvAttenMoni.ReadOnly = true;
            this.dgvAttenMoni.RowHeadersVisible = false;
            this.dgvAttenMoni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttenMoni.Size = new System.Drawing.Size(1297, 644);
            this.dgvAttenMoni.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "am_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "student";
            this.Column2.HeaderText = "Student";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "course";
            this.Column3.HeaderText = "Course";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "room";
            this.Column4.HeaderText = "Room";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "stime";
            this.Column5.HeaderText = "Scan Time";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.button1);
            this.pSearch.Controls.Add(this.textBox2);
            this.pSearch.Controls.Add(this.label3);
            this.pSearch.Controls.Add(this.textBox1);
            this.pSearch.Controls.Add(this.label2);
            this.pSearch.Controls.Add(this.txtSearch);
            this.pSearch.Controls.Add(this.label1);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(1321, 83);
            this.pSearch.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(335, 31);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by Student";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(431, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 31);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by Date";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(824, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 31);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search by Room";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1165, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Attendance_Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1321, 745);
            this.Controls.Add(this.pAttenMoni);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Attendance_Monitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Attendance_Monitoring_Load);
            this.pAttenMoni.ResumeLayout(false);
            this.pDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttenMoni)).EndInit();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAttenMoni;
        private System.Windows.Forms.Panel pDgv;
        private System.Windows.Forms.DataGridView dgvAttenMoni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}