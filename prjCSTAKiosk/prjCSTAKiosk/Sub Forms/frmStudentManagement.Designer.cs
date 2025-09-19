namespace prjCSTAKiosk
{
    partial class Student_Management
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
            this.pStud_Manage = new System.Windows.Forms.Panel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pDgv = new System.Windows.Forms.Panel();
            this.dgvStud = new System.Windows.Forms.DataGridView();
            this.tsControls = new System.Windows.Forms.ToolStrip();
            this.tsadd_SM = new System.Windows.Forms.ToolStripButton();
            this.tsedit_SM = new System.Windows.Forms.ToolStripButton();
            this.tsdelete_SM = new System.Windows.Forms.ToolStripButton();
            this.tsrefresh_SM = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designName_stud_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pStud_Manage.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).BeginInit();
            this.tsControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pStud_Manage
            // 
            this.pStud_Manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pStud_Manage.Controls.Add(this.pSearch);
            this.pStud_Manage.Controls.Add(this.pDgv);
            this.pStud_Manage.Controls.Add(this.tsControls);
            this.pStud_Manage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStud_Manage.Location = new System.Drawing.Point(0, 0);
            this.pStud_Manage.Name = "pStud_Manage";
            this.pStud_Manage.Size = new System.Drawing.Size(1331, 778);
            this.pStud_Manage.TabIndex = 0;
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.label2);
            this.pSearch.Controls.Add(this.txtSearch);
            this.pSearch.Controls.Add(this.label1);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 25);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(1331, 47);
            this.pSearch.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1072, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Students:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(94, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(484, 31);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // pDgv
            // 
            this.pDgv.Controls.Add(this.dgvStud);
            this.pDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgv.Location = new System.Drawing.Point(0, 25);
            this.pDgv.Name = "pDgv";
            this.pDgv.Size = new System.Drawing.Size(1331, 753);
            this.pDgv.TabIndex = 11;
            // 
            // dgvStud
            // 
            this.dgvStud.AllowUserToAddRows = false;
            this.dgvStud.AllowUserToDeleteRows = false;
            this.dgvStud.AllowUserToResizeColumns = false;
            this.dgvStud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStud.BackgroundColor = System.Drawing.Color.White;
            this.dgvStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.designName_stud_num,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvStud.Location = new System.Drawing.Point(12, 54);
            this.dgvStud.Name = "dgvStud";
            this.dgvStud.ReadOnly = true;
            this.dgvStud.RowHeadersVisible = false;
            this.dgvStud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStud.Size = new System.Drawing.Size(1308, 688);
            this.dgvStud.TabIndex = 12;
            // 
            // tsControls
            // 
            this.tsControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsadd_SM,
            this.tsedit_SM,
            this.tsdelete_SM,
            this.tsrefresh_SM});
            this.tsControls.Location = new System.Drawing.Point(0, 0);
            this.tsControls.Name = "tsControls";
            this.tsControls.Size = new System.Drawing.Size(1331, 25);
            this.tsControls.TabIndex = 9;
            // 
            // tsadd_SM
            // 
            this.tsadd_SM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsadd_SM.Image = global::prjCSTAKiosk.Properties.Resources.Add;
            this.tsadd_SM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsadd_SM.Name = "tsadd_SM";
            this.tsadd_SM.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsadd_SM.Size = new System.Drawing.Size(101, 22);
            this.tsadd_SM.Text = "ADD";
            this.tsadd_SM.Click += new System.EventHandler(this.tsadd_SM_Click);
            // 
            // tsedit_SM
            // 
            this.tsedit_SM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsedit_SM.Image = global::prjCSTAKiosk.Properties.Resources.Edit;
            this.tsedit_SM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsedit_SM.Name = "tsedit_SM";
            this.tsedit_SM.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsedit_SM.Size = new System.Drawing.Size(98, 22);
            this.tsedit_SM.Text = "EDIT";
            // 
            // tsdelete_SM
            // 
            this.tsdelete_SM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsdelete_SM.Image = global::prjCSTAKiosk.Properties.Resources.Delete;
            this.tsdelete_SM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdelete_SM.Name = "tsdelete_SM";
            this.tsdelete_SM.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsdelete_SM.Size = new System.Drawing.Size(113, 22);
            this.tsdelete_SM.Text = "DELETE";
            // 
            // tsrefresh_SM
            // 
            this.tsrefresh_SM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsrefresh_SM.Image = global::prjCSTAKiosk.Properties.Resources.Refresh;
            this.tsrefresh_SM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrefresh_SM.Name = "tsrefresh_SM";
            this.tsrefresh_SM.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsrefresh_SM.Size = new System.Drawing.Size(123, 22);
            this.tsrefresh_SM.Text = "REFRESH";
            this.tsrefresh_SM.Click += new System.EventHandler(this.tsrefresh_SM_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "student_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // designName_stud_num
            // 
            this.designName_stud_num.DataPropertyName = "stud_number";
            this.designName_stud_num.HeaderText = "Student Number";
            this.designName_stud_num.Name = "designName_stud_num";
            this.designName_stud_num.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "rfid_card";
            this.Column3.HeaderText = "RFID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "fname";
            this.Column4.HeaderText = "First Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "mname";
            this.Column5.HeaderText = "Middle Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "lname";
            this.Column6.HeaderText = "Last Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
<<<<<<< HEAD
            this.Column7.DataPropertyName = "course_name";
=======
            this.Column7.DataPropertyName = "course_code";
>>>>>>> 7c6c2ccd053b229f6b52d9cbdc1f9023ecdd1bc0
            this.Column7.HeaderText = "Course";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "year_level";
            this.Column8.HeaderText = "Year";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
<<<<<<< HEAD
            this.Column9.DataPropertyName = "student_section";
=======
            this.Column9.DataPropertyName = "section";
>>>>>>> 7c6c2ccd053b229f6b52d9cbdc1f9023ecdd1bc0
            this.Column9.HeaderText = "Section";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Student_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1331, 778);
            this.Controls.Add(this.pStud_Manage);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Student_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Student_Management_Load);
            this.pStud_Manage.ResumeLayout(false);
            this.pStud_Manage.PerformLayout();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).EndInit();
            this.tsControls.ResumeLayout(false);
            this.tsControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pStud_Manage;
        private System.Windows.Forms.ToolStrip tsControls;
        private System.Windows.Forms.ToolStripButton tsadd_SM;
        private System.Windows.Forms.Panel pDgv;
        private System.Windows.Forms.DataGridView dgvStud;
        private System.Windows.Forms.ToolStripButton tsedit_SM;
        private System.Windows.Forms.ToolStripButton tsdelete_SM;
        private System.Windows.Forms.ToolStripButton tsrefresh_SM;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn designName_stud_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}