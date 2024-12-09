namespace SaleApp.View
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.gbDSHangTon = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.laTongDon = new System.Windows.Forms.Label();
            this.laTongkh = new System.Windows.Forms.Label();
            this.laTongsp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.dtgvDSDonHang = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.laTong = new System.Windows.Forms.Label();
            this.btnXemCTDH = new System.Windows.Forms.Button();
            this.gbDSHangTon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.btnXuatFile, "btnXuatFile");
            this.btnXuatFile.ForeColor = System.Drawing.Color.White;
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // gbDSHangTon
            // 
            this.gbDSHangTon.Controls.Add(this.btnTim);
            this.gbDSHangTon.Controls.Add(this.laTongDon);
            this.gbDSHangTon.Controls.Add(this.laTongkh);
            this.gbDSHangTon.Controls.Add(this.laTongsp);
            this.gbDSHangTon.Controls.Add(this.label7);
            this.gbDSHangTon.Controls.Add(this.label6);
            this.gbDSHangTon.Controls.Add(this.label5);
            this.gbDSHangTon.Controls.Add(this.txtNam);
            this.gbDSHangTon.Controls.Add(this.label4);
            this.gbDSHangTon.Controls.Add(this.label3);
            this.gbDSHangTon.Controls.Add(this.cbThang);
            this.gbDSHangTon.Controls.Add(this.dtgvDSDonHang);
            resources.ApplyResources(this.gbDSHangTon, "gbDSHangTon");
            this.gbDSHangTon.Name = "gbDSHangTon";
            this.gbDSHangTon.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.btnTim, "btnTim");
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Name = "btnTim";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // laTongDon
            // 
            resources.ApplyResources(this.laTongDon, "laTongDon");
            this.laTongDon.ForeColor = System.Drawing.Color.Red;
            this.laTongDon.Name = "laTongDon";
            // 
            // laTongkh
            // 
            resources.ApplyResources(this.laTongkh, "laTongkh");
            this.laTongkh.ForeColor = System.Drawing.Color.Red;
            this.laTongkh.Name = "laTongkh";
            // 
            // laTongsp
            // 
            resources.ApplyResources(this.laTongsp, "laTongsp");
            this.laTongsp.ForeColor = System.Drawing.Color.Red;
            this.laTongsp.Name = "laTongsp";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtNam
            // 
            resources.ApplyResources(this.txtNam, "txtNam");
            this.txtNam.Name = "txtNam";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbThang
            // 
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            resources.GetString("cbThang.Items"),
            resources.GetString("cbThang.Items1"),
            resources.GetString("cbThang.Items2"),
            resources.GetString("cbThang.Items3"),
            resources.GetString("cbThang.Items4"),
            resources.GetString("cbThang.Items5"),
            resources.GetString("cbThang.Items6"),
            resources.GetString("cbThang.Items7"),
            resources.GetString("cbThang.Items8"),
            resources.GetString("cbThang.Items9"),
            resources.GetString("cbThang.Items10"),
            resources.GetString("cbThang.Items11"),
            resources.GetString("cbThang.Items12")});
            resources.ApplyResources(this.cbThang, "cbThang");
            this.cbThang.Name = "cbThang";
            // 
            // dtgvDSDonHang
            // 
            this.dtgvDSDonHang.AllowUserToAddRows = false;
            this.dtgvDSDonHang.AllowUserToDeleteRows = false;
            this.dtgvDSDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSDonHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvDSDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgvDSDonHang, "dtgvDSDonHang");
            this.dtgvDSDonHang.Name = "dtgvDSDonHang";
            this.dtgvDSDonHang.ReadOnly = true;
            this.dtgvDSDonHang.RowHeadersVisible = false;
            this.dtgvDSDonHang.RowTemplate.Height = 33;
            this.dtgvDSDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSDonHang_CellClick);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.btnrefresh, "btnrefresh");
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // laTong
            // 
            resources.ApplyResources(this.laTong, "laTong");
            this.laTong.ForeColor = System.Drawing.Color.Red;
            this.laTong.Name = "laTong";
            // 
            // btnXemCTDH
            // 
            this.btnXemCTDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.btnXemCTDH, "btnXemCTDH");
            this.btnXemCTDH.ForeColor = System.Drawing.Color.White;
            this.btnXemCTDH.Name = "btnXemCTDH";
            this.btnXemCTDH.UseVisualStyleBackColor = false;
            this.btnXemCTDH.Click += new System.EventHandler(this.btnXemCTDH_Click);
            // 
            // frmThongKe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXemCTDH);
            this.Controls.Add(this.laTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.gbDSHangTon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.gbDSHangTon.ResumeLayout(false);
            this.gbDSHangTon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnXuatFile;
        private GroupBox gbDSHangTon;
        private DataGridView dtgvDSDonHang;
        private Button btnrefresh;
        private Label label2;
        private Label laTong;
        private Button btnXemCTDH;
        private ComboBox cbThang;
        private Label label3;
        private Button btnTim;
        private Label laTongDon;
        private Label laTongkh;
        private Label laTongsp;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtNam;
        private Label label4;
    }
}