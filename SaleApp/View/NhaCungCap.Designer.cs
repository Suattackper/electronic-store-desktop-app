namespace SaleApp.View
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.gbThongTinNCC = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXuatE = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSachNCC = new System.Windows.Forms.GroupBox();
            this.dtgrDSNCC = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbThongTinNCC.SuspendLayout();
            this.gbDanhSachNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDSNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinNCC
            // 
            this.gbThongTinNCC.Controls.Add(this.label5);
            this.gbThongTinNCC.Controls.Add(this.btnXuatE);
            this.gbThongTinNCC.Controls.Add(this.btnSua);
            this.gbThongTinNCC.Controls.Add(this.btnXoa);
            this.gbThongTinNCC.Controls.Add(this.btnReset);
            this.gbThongTinNCC.Controls.Add(this.btnThem);
            this.gbThongTinNCC.Controls.Add(this.btnTimKiem);
            this.gbThongTinNCC.Controls.Add(this.txtTimKiem);
            this.gbThongTinNCC.Controls.Add(this.txtTenNCC);
            this.gbThongTinNCC.Controls.Add(this.txtSDTNCC);
            this.gbThongTinNCC.Controls.Add(this.txtDiaChiNCC);
            this.gbThongTinNCC.Controls.Add(this.txtMaNCC);
            this.gbThongTinNCC.Controls.Add(this.label4);
            this.gbThongTinNCC.Controls.Add(this.label3);
            this.gbThongTinNCC.Controls.Add(this.label2);
            this.gbThongTinNCC.Controls.Add(this.label1);
            this.gbThongTinNCC.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbThongTinNCC.Location = new System.Drawing.Point(10, 33);
            this.gbThongTinNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTinNCC.Name = "gbThongTinNCC";
            this.gbThongTinNCC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTinNCC.Size = new System.Drawing.Size(1146, 303);
            this.gbThongTinNCC.TabIndex = 0;
            this.gbThongTinNCC.TabStop = false;
            this.gbThongTinNCC.Text = "Thông tin Nhà Cung Cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhập tncc:";
            // 
            // btnXuatE
            // 
            this.btnXuatE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXuatE.FlatAppearance.BorderSize = 0;
            this.btnXuatE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatE.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuatE.ForeColor = System.Drawing.Color.White;
            this.btnXuatE.Location = new System.Drawing.Point(972, 235);
            this.btnXuatE.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatE.Name = "btnXuatE";
            this.btnXuatE.Size = new System.Drawing.Size(120, 40);
            this.btnXuatE.TabIndex = 9;
            this.btnXuatE.Text = "Xuất Excel";
            this.btnXuatE.UseVisualStyleBackColor = false;
            this.btnXuatE.Click += new System.EventHandler(this.btnXuatE_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(972, 78);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(972, 131);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(972, 183);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(972, 26);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Gray;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(255, 211);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 49);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTimKiem.Location = new System.Drawing.Point(31, 235);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(170, 25);
            this.txtTimKiem.TabIndex = 4;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(205, 131);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNCC.Multiline = true;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(214, 28);
            this.txtTenNCC.TabIndex = 2;
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Location = new System.Drawing.Point(633, 56);
            this.txtSDTNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(230, 29);
            this.txtSDTNCC.TabIndex = 1;
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Location = new System.Drawing.Point(633, 129);
            this.txtDiaChiNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChiNCC.Multiline = true;
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(230, 27);
            this.txtDiaChiNCC.TabIndex = 3;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(205, 58);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(214, 29);
            this.txtMaNCC.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(539, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(579, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "SDT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà cung cấp:";
            // 
            // gbDanhSachNCC
            // 
            this.gbDanhSachNCC.Controls.Add(this.dtgrDSNCC);
            this.gbDanhSachNCC.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDanhSachNCC.Location = new System.Drawing.Point(10, 349);
            this.gbDanhSachNCC.Margin = new System.Windows.Forms.Padding(2);
            this.gbDanhSachNCC.Name = "gbDanhSachNCC";
            this.gbDanhSachNCC.Padding = new System.Windows.Forms.Padding(2);
            this.gbDanhSachNCC.Size = new System.Drawing.Size(1147, 383);
            this.gbDanhSachNCC.TabIndex = 2;
            this.gbDanhSachNCC.TabStop = false;
            this.gbDanhSachNCC.Text = "Danh Sách Nhà cung cấp ";
            // 
            // dtgrDSNCC
            // 
            this.dtgrDSNCC.AllowUserToAddRows = false;
            this.dtgrDSNCC.AllowUserToDeleteRows = false;
            this.dtgrDSNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrDSNCC.BackgroundColor = System.Drawing.Color.White;
            this.dtgrDSNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrDSNCC.Location = new System.Drawing.Point(4, 25);
            this.dtgrDSNCC.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrDSNCC.Name = "dtgrDSNCC";
            this.dtgrDSNCC.ReadOnly = true;
            this.dtgrDSNCC.RowHeadersVisible = false;
            this.dtgrDSNCC.RowHeadersWidth = 62;
            this.dtgrDSNCC.RowTemplate.Height = 33;
            this.dtgrDSNCC.Size = new System.Drawing.Size(1139, 348);
            this.dtgrDSNCC.TabIndex = 0;
            this.dtgrDSNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrDSNCC_CellClick);
            this.dtgrDSNCC.SelectionChanged += new System.EventHandler(this.dtgrDSNCC_SelectionChanged);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 770);
            this.Controls.Add(this.gbDanhSachNCC);
            this.Controls.Add(this.gbThongTinNCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.gbThongTinNCC.ResumeLayout(false);
            this.gbThongTinNCC.PerformLayout();
            this.gbDanhSachNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDSNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbThongTinNCC;
        private Button btnXuatE;
        private Button btnSua;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private TextBox txtTenNCC;
        private TextBox txtSDTNCC;
        private TextBox txtDiaChiNCC;
        private TextBox txtMaNCC;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbDanhSachNCC;
        private DataGridView dtgrDSNCC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
    }
}