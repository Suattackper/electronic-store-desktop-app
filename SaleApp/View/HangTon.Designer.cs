namespace SaleApp.View
{
    partial class frmHangTon
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
            this.gbDSHangTon = new System.Windows.Forms.GroupBox();
            this.dtgvDSHangTon = new System.Windows.Forms.DataGridView();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.gbDSHangTon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHangTon)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDSHangTon
            // 
            this.gbDSHangTon.Controls.Add(this.dtgvDSHangTon);
            this.gbDSHangTon.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDSHangTon.Location = new System.Drawing.Point(27, 48);
            this.gbDSHangTon.Margin = new System.Windows.Forms.Padding(2);
            this.gbDSHangTon.Name = "gbDSHangTon";
            this.gbDSHangTon.Padding = new System.Windows.Forms.Padding(2);
            this.gbDSHangTon.Size = new System.Drawing.Size(1106, 601);
            this.gbDSHangTon.TabIndex = 0;
            this.gbDSHangTon.TabStop = false;
            this.gbDSHangTon.Text = "Danh sách hàng tồn";
            // 
            // dtgvDSHangTon
            // 
            this.dtgvDSHangTon.AllowUserToAddRows = false;
            this.dtgvDSHangTon.AllowUserToDeleteRows = false;
            this.dtgvDSHangTon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHangTon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvDSHangTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHangTon.Location = new System.Drawing.Point(5, 27);
            this.dtgvDSHangTon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvDSHangTon.Name = "dtgvDSHangTon";
            this.dtgvDSHangTon.ReadOnly = true;
            this.dtgvDSHangTon.RowHeadersVisible = false;
            this.dtgvDSHangTon.RowHeadersWidth = 62;
            this.dtgvDSHangTon.RowTemplate.Height = 33;
            this.dtgvDSHangTon.Size = new System.Drawing.Size(1097, 567);
            this.dtgvDSHangTon.TabIndex = 0;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(407, 667);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(166, 51);
            this.btnXuatFile.TabIndex = 1;
            this.btnXuatFile.Text = "Xuất File ";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.Location = new System.Drawing.Point(607, 667);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(166, 51);
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // frmHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1159, 740);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.gbDSHangTon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHangTon";
            this.Text = "Hàng tồn ";
            this.Load += new System.EventHandler(this.frmHangTon_Load);
            this.gbDSHangTon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHangTon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbDSHangTon;
        private DataGridView dtgvDSHangTon;
        private Button btnXuatFile;
        private Button btnrefresh;
    }
}