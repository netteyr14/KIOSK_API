namespace prjCSTAKiosk
{
    partial class Class_Sched
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
            this.pCS = new System.Windows.Forms.Panel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pDgv = new System.Windows.Forms.Panel();
            this.dgvCSched = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsControls = new System.Windows.Forms.ToolStrip();
            this.tsadd_CS = new System.Windows.Forms.ToolStripButton();
            this.tsedit_CS = new System.Windows.Forms.ToolStripButton();
            this.tsdelete_CS = new System.Windows.Forms.ToolStripButton();
            this.tsrefresh_CS = new System.Windows.Forms.ToolStripButton();
            this.pCS.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSched)).BeginInit();
            this.tsControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCS
            // 
            this.pCS.Controls.Add(this.pSearch);
            this.pCS.Controls.Add(this.pDgv);
            this.pCS.Controls.Add(this.tsControls);
            this.pCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCS.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.pCS.Location = new System.Drawing.Point(0, 0);
            this.pCS.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pCS.Name = "pCS";
            this.pCS.Size = new System.Drawing.Size(1331, 778);
            this.pCS.TabIndex = 0;
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.txtSearch);
            this.pSearch.Controls.Add(this.label1);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 25);
            this.pSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(1331, 47);
            this.pSearch.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(93, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(484, 31);
            this.txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // pDgv
            // 
            this.pDgv.Controls.Add(this.dgvCSched);
            this.pDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgv.Location = new System.Drawing.Point(0, 25);
            this.pDgv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pDgv.Name = "pDgv";
            this.pDgv.Size = new System.Drawing.Size(1331, 753);
            this.pDgv.TabIndex = 14;
            // 
            // dgvCSched
            // 
            this.dgvCSched.AllowUserToAddRows = false;
            this.dgvCSched.AllowUserToDeleteRows = false;
            this.dgvCSched.AllowUserToResizeColumns = false;
            this.dgvCSched.AllowUserToResizeRows = false;
            this.dgvCSched.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCSched.BackgroundColor = System.Drawing.Color.White;
            this.dgvCSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSched.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dgvCSched.Location = new System.Drawing.Point(15, 57);
            this.dgvCSched.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvCSched.Name = "dgvCSched";
            this.dgvCSched.ReadOnly = true;
            this.dgvCSched.RowHeadersVisible = false;
            this.dgvCSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCSched.Size = new System.Drawing.Size(1301, 682);
            this.dgvCSched.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cs_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "subj";
            this.Column2.HeaderText = "Subject";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "facul";
            this.Column3.HeaderText = "Faculty";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dow";
            this.Column4.HeaderText = "Day of Week";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tstart";
            this.Column7.HeaderText = "Time Start";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tend";
            this.Column5.HeaderText = "Time End";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "room";
            this.Column6.HeaderText = "Room";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tsControls
            // 
            this.tsControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsadd_CS,
            this.tsedit_CS,
            this.tsdelete_CS,
            this.tsrefresh_CS});
            this.tsControls.Location = new System.Drawing.Point(0, 0);
            this.tsControls.Name = "tsControls";
            this.tsControls.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsControls.Size = new System.Drawing.Size(1331, 25);
            this.tsControls.TabIndex = 12;
            this.tsControls.Text = "toolStrip1";
            // 
            // tsadd_CS
            // 
            this.tsadd_CS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsadd_CS.Image = global::prjCSTAKiosk.Properties.Resources.Add;
            this.tsadd_CS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsadd_CS.Name = "tsadd_CS";
            this.tsadd_CS.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsadd_CS.Size = new System.Drawing.Size(101, 22);
            this.tsadd_CS.Text = "ADD";
            this.tsadd_CS.Click += new System.EventHandler(this.tsadd_CS_Click);
            // 
            // tsedit_CS
            // 
            this.tsedit_CS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsedit_CS.Image = global::prjCSTAKiosk.Properties.Resources.Edit;
            this.tsedit_CS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsedit_CS.Name = "tsedit_CS";
            this.tsedit_CS.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsedit_CS.Size = new System.Drawing.Size(98, 22);
            this.tsedit_CS.Text = "EDIT";
            // 
            // tsdelete_CS
            // 
            this.tsdelete_CS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsdelete_CS.Image = global::prjCSTAKiosk.Properties.Resources.Delete;
            this.tsdelete_CS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdelete_CS.Name = "tsdelete_CS";
            this.tsdelete_CS.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsdelete_CS.Size = new System.Drawing.Size(113, 22);
            this.tsdelete_CS.Text = "DELETE";
            // 
            // tsrefresh_CS
            // 
            this.tsrefresh_CS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsrefresh_CS.Image = global::prjCSTAKiosk.Properties.Resources.Refresh;
            this.tsrefresh_CS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrefresh_CS.Name = "tsrefresh_CS";
            this.tsrefresh_CS.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsrefresh_CS.Size = new System.Drawing.Size(123, 22);
            this.tsrefresh_CS.Text = "REFRESH";
            this.tsrefresh_CS.Click += new System.EventHandler(this.tsrefresh_CS_Click);
            // 
            // Class_Sched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1331, 778);
            this.Controls.Add(this.pCS);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Class_Sched";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Schedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Class_Sched_Load);
            this.pCS.ResumeLayout(false);
            this.pCS.PerformLayout();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSched)).EndInit();
            this.tsControls.ResumeLayout(false);
            this.tsControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCS;
        private System.Windows.Forms.ToolStrip tsControls;
        private System.Windows.Forms.ToolStripButton tsadd_CS;
        private System.Windows.Forms.ToolStripButton tsedit_CS;
        private System.Windows.Forms.ToolStripButton tsdelete_CS;
        private System.Windows.Forms.ToolStripButton tsrefresh_CS;
        private System.Windows.Forms.Panel pDgv;
        private System.Windows.Forms.DataGridView dgvCSched;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}