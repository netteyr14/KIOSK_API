namespace prjCSTAKiosk
{
    partial class Suggestion_Box
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
            this.pSugg = new System.Windows.Forms.Panel();
            this.dgvSugg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSugg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugg)).BeginInit();
            this.SuspendLayout();
            // 
            // pSugg
            // 
            this.pSugg.Controls.Add(this.dgvSugg);
            this.pSugg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSugg.Location = new System.Drawing.Point(0, 0);
            this.pSugg.Name = "pSugg";
            this.pSugg.Size = new System.Drawing.Size(1134, 662);
            this.pSugg.TabIndex = 0;
            // 
            // dgvSugg
            // 
            this.dgvSugg.AllowUserToAddRows = false;
            this.dgvSugg.AllowUserToDeleteRows = false;
            this.dgvSugg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSugg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSugg.BackgroundColor = System.Drawing.Color.White;
            this.dgvSugg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSugg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSugg.Location = new System.Drawing.Point(12, 12);
            this.dgvSugg.Name = "dgvSugg";
            this.dgvSugg.ReadOnly = true;
            this.dgvSugg.RowHeadersVisible = false;
            this.dgvSugg.Size = new System.Drawing.Size(1110, 638);
            this.dgvSugg.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sb_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sugg";
            this.Column2.FillWeight = 300F;
            this.Column2.HeaderText = "Suggestion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tstamp";
            this.Column3.HeaderText = "Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Suggestion_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1134, 662);
            this.Controls.Add(this.pSugg);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Suggestion_Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suggestion_Box";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Suggestion_Box_Load);
            this.pSugg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSugg;
        private System.Windows.Forms.DataGridView dgvSugg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}