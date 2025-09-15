namespace prjCSTAKiosk
{
    partial class Announcements
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
            this.pAnn = new System.Windows.Forms.Panel();
            this.pDgv = new System.Windows.Forms.Panel();
            this.dgvAnn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsControls = new System.Windows.Forms.ToolStrip();
            this.tsadd_Ann = new System.Windows.Forms.ToolStripButton();
            this.tsedit_Ann = new System.Windows.Forms.ToolStripButton();
            this.tsdelete_Ann = new System.Windows.Forms.ToolStripButton();
            this.tsrefresgh_Ann = new System.Windows.Forms.ToolStripButton();
            this.pSearch = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pAnn.SuspendLayout();
            this.pDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnn)).BeginInit();
            this.tsControls.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pAnn
            // 
            this.pAnn.Controls.Add(this.pSearch);
            this.pAnn.Controls.Add(this.pDgv);
            this.pAnn.Controls.Add(this.tsControls);
            this.pAnn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAnn.Location = new System.Drawing.Point(0, 0);
            this.pAnn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pAnn.Name = "pAnn";
            this.pAnn.Size = new System.Drawing.Size(1331, 729);
            this.pAnn.TabIndex = 0;
            // 
            // pDgv
            // 
            this.pDgv.Controls.Add(this.dgvAnn);
            this.pDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDgv.Location = new System.Drawing.Point(0, 25);
            this.pDgv.Name = "pDgv";
            this.pDgv.Size = new System.Drawing.Size(1331, 704);
            this.pDgv.TabIndex = 14;
            // 
            // dgvAnn
            // 
            this.dgvAnn.AllowUserToAddRows = false;
            this.dgvAnn.AllowUserToDeleteRows = false;
            this.dgvAnn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnn.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvAnn.Location = new System.Drawing.Point(12, 53);
            this.dgvAnn.Name = "dgvAnn";
            this.dgvAnn.ReadOnly = true;
            this.dgvAnn.RowHeadersVisible = false;
            this.dgvAnn.Size = new System.Drawing.Size(1307, 639);
            this.dgvAnn.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ann_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "title";
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "message";
            this.Column3.HeaderText = "Message";
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
            // tsControls
            // 
            this.tsControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsadd_Ann,
            this.tsedit_Ann,
            this.tsdelete_Ann,
            this.tsrefresgh_Ann});
            this.tsControls.Location = new System.Drawing.Point(0, 0);
            this.tsControls.Name = "tsControls";
            this.tsControls.Size = new System.Drawing.Size(1331, 25);
            this.tsControls.TabIndex = 12;
            this.tsControls.Text = "toolStrip1";
            // 
            // tsadd_Ann
            // 
            this.tsadd_Ann.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsadd_Ann.Image = global::prjCSTAKiosk.Properties.Resources.Add;
            this.tsadd_Ann.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsadd_Ann.Name = "tsadd_Ann";
            this.tsadd_Ann.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsadd_Ann.Size = new System.Drawing.Size(101, 22);
            this.tsadd_Ann.Text = "ADD";
            this.tsadd_Ann.Click += new System.EventHandler(this.tsadd_Ann_Click);
            // 
            // tsedit_Ann
            // 
            this.tsedit_Ann.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsedit_Ann.Image = global::prjCSTAKiosk.Properties.Resources.Edit;
            this.tsedit_Ann.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsedit_Ann.Name = "tsedit_Ann";
            this.tsedit_Ann.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsedit_Ann.Size = new System.Drawing.Size(98, 22);
            this.tsedit_Ann.Text = "EDIT";
            // 
            // tsdelete_Ann
            // 
            this.tsdelete_Ann.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsdelete_Ann.Image = global::prjCSTAKiosk.Properties.Resources.Delete;
            this.tsdelete_Ann.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdelete_Ann.Name = "tsdelete_Ann";
            this.tsdelete_Ann.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsdelete_Ann.Size = new System.Drawing.Size(113, 22);
            this.tsdelete_Ann.Text = "DELETE";
            // 
            // tsrefresgh_Ann
            // 
            this.tsrefresgh_Ann.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsrefresgh_Ann.Image = global::prjCSTAKiosk.Properties.Resources.Refresh;
            this.tsrefresgh_Ann.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrefresgh_Ann.Name = "tsrefresgh_Ann";
            this.tsrefresgh_Ann.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tsrefresgh_Ann.Size = new System.Drawing.Size(123, 22);
            this.tsrefresgh_Ann.Text = "REFRESH";
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
            this.pSearch.TabIndex = 15;
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
            // Announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1331, 729);
            this.Controls.Add(this.pAnn);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Announcements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Announcements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Announcements_Load);
            this.pAnn.ResumeLayout(false);
            this.pAnn.PerformLayout();
            this.pDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnn)).EndInit();
            this.tsControls.ResumeLayout(false);
            this.tsControls.PerformLayout();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAnn;
        private System.Windows.Forms.ToolStrip tsControls;
        private System.Windows.Forms.ToolStripButton tsadd_Ann;
        private System.Windows.Forms.ToolStripButton tsedit_Ann;
        private System.Windows.Forms.ToolStripButton tsdelete_Ann;
        private System.Windows.Forms.ToolStripButton tsrefresgh_Ann;
        private System.Windows.Forms.Panel pDgv;
        private System.Windows.Forms.DataGridView dgvAnn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}