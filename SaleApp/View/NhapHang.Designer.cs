namespace SaleApp.View
{
    partial class frmNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbTTNhapHang = new System.Windows.Forms.GroupBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.lNgayThanhToan = new System.Windows.Forms.Label();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.txtTamUng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTTSP = new System.Windows.Forms.GroupBox();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDSSPNhap = new System.Windows.Forms.GroupBox();
            this.dtgvDSSPNhap = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTTNhapHang.SuspendLayout();
            this.gbTTSP.SuspendLayout();
            this.gbDSSPNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSPNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(486, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Hàng ";
            // 
            // gbTTNhapHang
            // 
            this.gbTTNhapHang.Controls.Add(this.btnNhap);
            this.gbTTNhapHang.Controls.Add(this.dtpNgayThanhToan);
            this.gbTTNhapHang.Controls.Add(this.lNgayThanhToan);
            this.gbTTNhapHang.Controls.Add(this.cbNhaCungCap);
            this.gbTTNhapHang.Controls.Add(this.txtTamUng);
            this.gbTTNhapHang.Controls.Add(this.label6);
            this.gbTTNhapHang.Controls.Add(this.gbTTSP);
            this.gbTTNhapHang.Controls.Add(this.label4);
            this.gbTTNhapHang.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTTNhapHang.Location = new System.Drawing.Point(11, 44);
            this.gbTTNhapHang.Margin = new System.Windows.Forms.Padding(2);
            this.gbTTNhapHang.Name = "gbTTNhapHang";
            this.gbTTNhapHang.Padding = new System.Windows.Forms.Padding(2);
            this.gbTTNhapHang.Size = new System.Drawing.Size(1137, 274);
            this.gbTTNhapHang.TabIndex = 1;
            this.gbTTNhapHang.TabStop = false;
            this.gbTTNhapHang.Text = "Thông tin Nhập Hàng ";
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNhap.FlatAppearance.BorderSize = 0;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhap.Location = new System.Drawing.Point(200, 225);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(90, 37);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.Enabled = false;
            this.dtpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(153, 193);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(208, 27);
            this.dtpNgayThanhToan.TabIndex = 2;
            // 
            // lNgayThanhToan
            // 
            this.lNgayThanhToan.AutoSize = true;
            this.lNgayThanhToan.Location = new System.Drawing.Point(170, 168);
            this.lNgayThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNgayThanhToan.Name = "lNgayThanhToan";
            this.lNgayThanhToan.Size = new System.Drawing.Size(170, 22);
            this.lNgayThanhToan.TabIndex = 18;
            this.lNgayThanhToan.Text = "Ngày thanh toán:";
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(218, 59);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(154, 30);
            this.cbNhaCungCap.TabIndex = 0;
            // 
            // txtTamUng
            // 
            this.txtTamUng.Location = new System.Drawing.Point(218, 116);
            this.txtTamUng.Margin = new System.Windows.Forms.Padding(2);
            this.txtTamUng.Name = "txtTamUng";
            this.txtTamUng.Size = new System.Drawing.Size(154, 27);
            this.txtTamUng.TabIndex = 1;
            this.txtTamUng.TextChanged += new System.EventHandler(this.txtTamUng_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tạm ứng:";
            // 
            // gbTTSP
            // 
            this.gbTTSP.Controls.Add(this.cbSanPham);
            this.gbTTSP.Controls.Add(this.btnReset);
            this.gbTTSP.Controls.Add(this.btnXoa);
            this.gbTTSP.Controls.Add(this.btnThem);
            this.gbTTSP.Controls.Add(this.txtSoLuong);
            this.gbTTSP.Controls.Add(this.txtGiaNhap);
            this.gbTTSP.Controls.Add(this.label10);
            this.gbTTSP.Controls.Add(this.label8);
            this.gbTTSP.Controls.Add(this.label7);
            this.gbTTSP.Location = new System.Drawing.Point(528, 24);
            this.gbTTSP.Margin = new System.Windows.Forms.Padding(2);
            this.gbTTSP.Name = "gbTTSP";
            this.gbTTSP.Padding = new System.Windows.Forms.Padding(2);
            this.gbTTSP.Size = new System.Drawing.Size(596, 239);
            this.gbTTSP.TabIndex = 10;
            this.gbTTSP.TabStop = false;
            this.gbTTSP.Text = "Thông tin Sản phẩm";
            // 
            // cbSanPham
            // 
            this.cbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(173, 67);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(151, 30);
            this.cbSanPham.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(433, 189);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 37);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(435, 110);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 37);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(435, 31);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(173, 120);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(154, 27);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(173, 170);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(154, 27);
            this.txtGiaNhap.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giá nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "NCC:";
            // 
            // gbDSSPNhap
            // 
            this.gbDSSPNhap.Controls.Add(this.dtgvDSSPNhap);
            this.gbDSSPNhap.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDSSPNhap.Location = new System.Drawing.Point(11, 322);
            this.gbDSSPNhap.Margin = new System.Windows.Forms.Padding(2);
            this.gbDSSPNhap.Name = "gbDSSPNhap";
            this.gbDSSPNhap.Padding = new System.Windows.Forms.Padding(2);
            this.gbDSSPNhap.Size = new System.Drawing.Size(1137, 389);
            this.gbDSSPNhap.TabIndex = 2;
            this.gbDSSPNhap.TabStop = false;
            this.gbDSSPNhap.Text = "Danh sách Sản phẩm nhập";
            // 
            // dtgvDSSPNhap
            // 
            this.dtgvDSSPNhap.AllowUserToAddRows = false;
            this.dtgvDSSPNhap.AllowUserToDeleteRows = false;
            this.dtgvDSSPNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSSPNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSSPNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluong,
            this.gianhap,
            this.ncc});
            this.dtgvDSSPNhap.Location = new System.Drawing.Point(9, 0);
            this.dtgvDSSPNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvDSSPNhap.Name = "dtgvDSSPNhap";
            this.dtgvDSSPNhap.ReadOnly = true;
            this.dtgvDSSPNhap.RowHeadersVisible = false;
            this.dtgvDSSPNhap.RowHeadersWidth = 62;
            this.dtgvDSSPNhap.RowTemplate.Height = 33;
            this.dtgvDSSPNhap.Size = new System.Drawing.Size(1115, 379);
            this.dtgvDSSPNhap.TabIndex = 0;
            this.dtgvDSSPNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSSPNhap_CellClick);
            this.dtgvDSSPNhap.SelectionChanged += new System.EventHandler(this.dtgvDSSPNhap_SelectionChanged);
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã SP";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên SP";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // gianhap
            // 
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.MinimumWidth = 6;
            this.gianhap.Name = "gianhap";
            this.gianhap.ReadOnly = true;
            // 
            // ncc
            // 
            this.ncc.HeaderText = "NCC";
            this.ncc.MinimumWidth = 6;
            this.ncc.Name = "ncc";
            this.ncc.ReadOnly = true;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 740);
            this.Controls.Add(this.gbDSSPNhap);
            this.Controls.Add(this.gbTTNhapHang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hàng ";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.gbTTNhapHang.ResumeLayout(false);
            this.gbTTNhapHang.PerformLayout();
            this.gbTTSP.ResumeLayout(false);
            this.gbTTSP.PerformLayout();
            this.gbDSSPNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSPNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox gbTTNhapHang;
        private Label label6;
        private Label label4;
        private TextBox txtTamUng;
        private GroupBox gbTTSP;
        private Label label10;
        private Label label8;
        private Label label7;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThem;
        private TextBox txtSoLuong;
        private TextBox txtGiaNhap;
        private GroupBox gbDSSPNhap;
        private DataGridView dtgvDSSPNhap;
        private DateTimePicker dtpNgayThanhToan;
        private Label lNgayThanhToan;
        private ComboBox cbNhaCungCap;
        private ComboBox cbSanPham;
        private Button btnNhap;
        private DataGridViewTextBoxColumn masp;
        private DataGridViewTextBoxColumn tensp;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn gianhap;
        private DataGridViewTextBoxColumn ncc;
    }
}