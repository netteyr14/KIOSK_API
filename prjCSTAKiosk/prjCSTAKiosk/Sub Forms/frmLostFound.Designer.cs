namespace prjCSTAKiosk
{
    partial class Lost_Found
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
            this.plf = new System.Windows.Forms.Panel();
            this.pDgv = new System.Windows.Forms.Panel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLF = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsControls = new System.Windows.Forms.ToolStrip();
            this.tsadd_LF = new System.Windows.Forms.ToolStripButton();
            this.tsedit_LF = new System.Windows.Forms.ToolStripButton();
            this.tsdelete_LF = new System.Windows.Forms.ToolStripButton();
            this.tsrefresh_LF = new System.Windows.Forms.ToolStripButton();
            this.plf.SuspendLayout();
            this.pDgv.SuspendLayout();
            this.pSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLF)).BeginInit();
            this.tsControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // plf
            // 
            this.plf.Controls.Add(this.pDgv);
            this.plf.Controls.Add(this.tsControls);
            this.plf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plf.Location = new System.Drawing.Point(0, 0);
            this.plf.Name = "plf";
            this.plf.Size = new System.Drawing.Size(1331, 778);
            this.plf.TabIndex = 0;
            // 
            // pDgv
            // 
            this.pDgv.Controls.Add(this.pSearch);
            this.pDgv.Controls.Add(this.dgvLF);
            this.pDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgv.Location = new System.Drawing.Point(0, 25);
            this.pDgv.Name = "pDgv";
            this.pDgv.Size = new System.Drawing.Size(1331, 753);
            this.pDgv.TabIndex = 14;
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.txtSearch);
            this.pSearch.Controls.Add(this.label1);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(1331, 47);
            this.pSearch.TabIndex = 13;
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
            // dgvLF
            // 
            this.dgvLF.AllowUserToAddRows = false;
            this.dgvLF.AllowUserToDeleteRows = false;
            this.dgvLF.AllowUserToResizeColumns = false;
            this.dgvLF.AllowUserToResizeRows = false;
            this.dgvLF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLF.BackgroundColor = System.Drawing.Color.White;
            this.dgvLF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvLF.Location = new System.Drawing.Point(12, 53);
            this.dgvLF.Name = "dgvLF";
            this.dgvLF.ReadOnly = true;
            this.dgvLF.RowHeadersVisible = false;
            this.dgvLF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLF.Size = new System.Drawing.Size(1307, 688);
            this.dgvLF.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "lf_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "iname";
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "descrip";
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ipath";
            this.Column4.HeaderText = "Image Path";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "stat";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "reportby";
            this.Column6.HeaderText = "Reported By";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "claimby";
            this.Column7.HeaderText = "Claimed By";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // tsControls
            // 
            this.tsControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsadd_LF,
            this.tsedit_LF,
            this.tsdelete_LF,
            this.tsrefresh_LF});
            this.tsControls.Location = new System.Drawing.Point(0, 0);
            this.tsControls.Name = "tsControls";
            this.tsControls.Size = new System.Drawing.Size(1331, 25);
            this.tsControls.TabIndex = 12;
            this.tsControls.Text = "toolStrip1";
            // 
            // tsadd_LF
            // 
            this.tsadd_LF.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsadd_LF.Image = global::prjCSTAKiosk.Properties.Resources.Add;
            this.tsadd_LF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsadd_LF.Name = "tsadd_LF";
            this.tsadd_LF.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsadd_LF.Size = new System.Drawing.Size(101, 22);
            this.tsadd_LF.Text = "ADD";
            this.tsadd_LF.Click += new System.EventHandler(this.tsadd_LF_Click);
            // 
            // tsedit_LF
            // 
            this.tsedit_LF.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsedit_LF.Image = global::prjCSTAKiosk.Properties.Resources.Edit;
            this.tsedit_LF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsedit_LF.Name = "tsedit_LF";
            this.tsedit_LF.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsedit_LF.Size = new System.Drawing.Size(98, 22);
            this.tsedit_LF.Text = "EDIT";
            // 
            // tsdelete_LF
            // 
            this.tsdelete_LF.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsdelete_LF.Image = global::prjCSTAKiosk.Properties.Resources.Delete;
            this.tsdelete_LF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdelete_LF.Name = "tsdelete_LF";
            this.tsdelete_LF.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsdelete_LF.Size = new System.Drawing.Size(113, 22);
            this.tsdelete_LF.Text = "DELETE";
            // 
            // tsrefresh_LF
            // 
            this.tsrefresh_LF.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsrefresh_LF.Image = global::prjCSTAKiosk.Properties.Resources.Refresh;
            this.tsrefresh_LF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrefresh_LF.Name = "tsrefresh_LF";
            this.tsrefresh_LF.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsrefresh_LF.Size = new System.Drawing.Size(123, 22);
            this.tsrefresh_LF.Text = "REFRESH";
            // 
            // Lost_Found
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1331, 778);
            this.Controls.Add(this.plf);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Lost_Found";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost_Found";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lost_Found_Load);
            this.plf.ResumeLayout(false);
            this.plf.PerformLayout();
            this.pDgv.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLF)).EndInit();
            this.tsControls.ResumeLayout(false);
            this.tsControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plf;
        private System.Windows.Forms.ToolStrip tsControls;
        private System.Windows.Forms.ToolStripButton tsadd_LF;
        private System.Windows.Forms.ToolStripButton tsedit_LF;
        private System.Windows.Forms.ToolStripButton tsdelete_LF;
        private System.Windows.Forms.ToolStripButton tsrefresh_LF;
        private System.Windows.Forms.Panel pDgv;
        private System.Windows.Forms.DataGridView dgvLF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;

    }
}