
namespace SaleApp
{
    partial class frmDonHang
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
            this.gbTTSP = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTTKhachHang = new System.Windows.Forms.GroupBox();
            this.txbMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInDon = new System.Windows.Forms.Button();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dvgMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.des = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flpDanhSachSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTienThua = new System.Windows.Forms.TextBox();
            this.txbKhachDua = new System.Windows.Forms.TextBox();
            this.txbTongBill = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.gbTTSP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.txtTTKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTTSP
            // 
            this.gbTTSP.BackColor = System.Drawing.SystemColors.Control;
            this.gbTTSP.Controls.Add(this.panel1);
            this.gbTTSP.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTTSP.Location = new System.Drawing.Point(666, 9);
            this.gbTTSP.Margin = new System.Windows.Forms.Padding(2);
            this.gbTTSP.Name = "gbTTSP";
            this.gbTTSP.Padding = new System.Windows.Forms.Padding(2);
            this.gbTTSP.Size = new System.Drawing.Size(492, 160);
            this.gbTTSP.TabIndex = 1;
            this.gbTTSP.TabStop = false;
            this.gbTTSP.Text = "Tìm Kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 119);
            this.panel1.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(389, 39);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 42);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(302, 39);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(83, 43);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(17, 44);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(261, 38);
            this.txtTimKiem.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(29, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Sản Phẩm:";
            // 
            // txtTTKhachHang
            // 
            this.txtTTKhachHang.BackColor = System.Drawing.SystemColors.Control;
            this.txtTTKhachHang.Controls.Add(this.txbMaKH);
            this.txtTTKhachHang.Controls.Add(this.label6);
            this.txtTTKhachHang.Controls.Add(this.txtSDT);
            this.txtTTKhachHang.Controls.Add(this.label5);
            this.txtTTKhachHang.Controls.Add(this.txtHoTen);
            this.txtTTKhachHang.Controls.Add(this.label4);
            this.txtTTKhachHang.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTTKhachHang.Location = new System.Drawing.Point(5, 9);
            this.txtTTKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTTKhachHang.Name = "txtTTKhachHang";
            this.txtTTKhachHang.Padding = new System.Windows.Forms.Padding(2);
            this.txtTTKhachHang.Size = new System.Drawing.Size(656, 147);
            this.txtTTKhachHang.TabIndex = 0;
            this.txtTTKhachHang.TabStop = false;
            this.txtTTKhachHang.Text = "Thông tin Khách hàng ";
            // 
            // txbMaKH
            // 
            this.txbMaKH.Location = new System.Drawing.Point(9, 72);
            this.txbMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaKH.Multiline = true;
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.Size = new System.Drawing.Size(213, 34);
            this.txbMaKH.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã Khách Hàng:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(444, 72);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(213, 34);
            this.txtSDT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(443, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "SDT:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(226, 72);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(213, 34);
            this.txtHoTen.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(226, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Khách Hàng:";
            // 
            // btnInDon
            // 
            this.btnInDon.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInDon.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInDon.ForeColor = System.Drawing.Color.White;
            this.btnInDon.Location = new System.Drawing.Point(44, 549);
            this.btnInDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnInDon.Name = "btnInDon";
            this.btnInDon.Size = new System.Drawing.Size(185, 37);
            this.btnInDon.TabIndex = 11;
            this.btnInDon.Text = "Thanh Toán";
            this.btnInDon.UseVisualStyleBackColor = false;
            this.btnInDon.Click += new System.EventHandler(this.btnInDon_Click);
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHuyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDon.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuyDon.ForeColor = System.Drawing.Color.White;
            this.btnHuyDon.Location = new System.Drawing.Point(233, 549);
            this.btnHuyDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(128, 37);
            this.btnHuyDon.TabIndex = 14;
            this.btnHuyDon.Text = "Hủy Đơn";
            this.btnHuyDon.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgMaSP,
            this.dvgTenSP,
            this.dvgSoLuong,
            this.dvgGiaBan,
            this.dvgTong,
            this.Delete,
            this.des});
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(486, 338);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // dvgMaSP
            // 
            this.dvgMaSP.Frozen = true;
            this.dvgMaSP.HeaderText = "MaSP";
            this.dvgMaSP.MinimumWidth = 40;
            this.dvgMaSP.Name = "dvgMaSP";
            this.dvgMaSP.ReadOnly = true;
            this.dvgMaSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgMaSP.Width = 40;
            // 
            // dvgTenSP
            // 
            this.dvgTenSP.Frozen = true;
            this.dvgTenSP.HeaderText = "Tên SP";
            this.dvgTenSP.MinimumWidth = 85;
            this.dvgTenSP.Name = "dvgTenSP";
            this.dvgTenSP.ReadOnly = true;
            this.dvgTenSP.Width = 85;
            // 
            // dvgSoLuong
            // 
            this.dvgSoLuong.Frozen = true;
            this.dvgSoLuong.HeaderText = "Qty";
            this.dvgSoLuong.MinimumWidth = 50;
            this.dvgSoLuong.Name = "dvgSoLuong";
            this.dvgSoLuong.ReadOnly = true;
            this.dvgSoLuong.Width = 50;
            // 
            // dvgGiaBan
            // 
            this.dvgGiaBan.Frozen = true;
            this.dvgGiaBan.HeaderText = "Giá SP";
            this.dvgGiaBan.MinimumWidth = 68;
            this.dvgGiaBan.Name = "dvgGiaBan";
            this.dvgGiaBan.ReadOnly = true;
            this.dvgGiaBan.Width = 68;
            // 
            // dvgTong
            // 
            this.dvgTong.Frozen = true;
            this.dvgTong.HeaderText = "Tổng";
            this.dvgTong.MinimumWidth = 80;
            this.dvgTong.Name = "dvgTong";
            this.dvgTong.ReadOnly = true;
            this.dvgTong.Width = 80;
            // 
            // Delete
            // 
            this.Delete.Frozen = true;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 55;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.Width = 55;
            // 
            // des
            // 
            this.des.HeaderText = "-1";
            this.des.MinimumWidth = 40;
            this.des.Name = "des";
            this.des.ReadOnly = true;
            this.des.Text = "des";
            this.des.Width = 40;
            // 
            // flpDanhSachSanPham
            // 
            this.flpDanhSachSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDanhSachSanPham.AutoScroll = true;
            this.flpDanhSachSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpDanhSachSanPham.Location = new System.Drawing.Point(3, 46);
            this.flpDanhSachSanPham.Name = "flpDanhSachSanPham";
            this.flpDanhSachSanPham.Size = new System.Drawing.Size(657, 538);
            this.flpDanhSachSanPham.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.flpDanhSachSanPham);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-5, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 605);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 43);
            this.panel4.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(192, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(259, 35);
            this.label14.TabIndex = 0;
            this.label14.Text = "Danh Sách Sản Phẩm";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbTienThua);
            this.panel5.Controls.Add(this.txbKhachDua);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.txbTongBill);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.btnInDon);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.btnHuyDon);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(666, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(492, 604);
            this.panel5.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(366, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "VNĐ";
            // 
            // txbTienThua
            // 
            this.txbTienThua.Enabled = false;
            this.txbTienThua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTienThua.ForeColor = System.Drawing.Color.Firebrick;
            this.txbTienThua.Location = new System.Drawing.Point(173, 494);
            this.txbTienThua.Multiline = true;
            this.txbTienThua.Name = "txbTienThua";
            this.txbTienThua.Size = new System.Drawing.Size(189, 34);
            this.txbTienThua.TabIndex = 34;
            this.txbTienThua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbKhachDua
            // 
            this.txbKhachDua.Enabled = false;
            this.txbKhachDua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbKhachDua.Location = new System.Drawing.Point(173, 450);
            this.txbKhachDua.Multiline = true;
            this.txbKhachDua.Name = "txbKhachDua";
            this.txbKhachDua.Size = new System.Drawing.Size(189, 34);
            this.txbKhachDua.TabIndex = 33;
            this.txbKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbKhachDua.TextChanged += new System.EventHandler(this.txbKhachDua_TextChanged);
            // 
            // txbTongBill
            // 
            this.txbTongBill.Enabled = false;
            this.txbTongBill.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTongBill.ForeColor = System.Drawing.Color.Goldenrod;
            this.txbTongBill.Location = new System.Drawing.Point(173, 403);
            this.txbTongBill.Multiline = true;
            this.txbTongBill.Name = "txbTongBill";
            this.txbTongBill.Size = new System.Drawing.Size(189, 38);
            this.txbTongBill.TabIndex = 32;
            this.txbTongBill.Text = "0";
            this.txbTongBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTongBill.TextChanged += new System.EventHandler(this.txbTongBill_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(74, 505);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 23);
            this.label18.TabIndex = 31;
            this.label18.Text = "Tiền Thừa: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(32, 457);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 23);
            this.label17.TabIndex = 30;
            this.label17.Text = "Tiền Khách Đưa: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(42, 413);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 23);
            this.label16.TabIndex = 29;
            this.label16.Text = "Tổng Hóa Đơn:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(0, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(497, 43);
            this.panel6.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(150, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(244, 35);
            this.label15.TabIndex = 0;
            this.label15.Text = "Thông Tin Hóa Đơn";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1168, 770);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtTTKhachHang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gbTTSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonHang";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            this.gbTTSP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.txtTTKhachHang.ResumeLayout(false);
            this.txtTTKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gbTTSP;
        private GroupBox txtTTKhachHang;
        private TextBox txtSDT;
        private Label label5;
        private TextBox txtHoTen;
        private Label label4;
        private Button btnInDon;
        private Button btnHuyDon;
        private FlowLayoutPanel flpDanhSachSanPham;
        private Panel panel3;
        private Label label14;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label15;
        private DataGridView dataGridView1;
        private TextBox txbTienThua;
        private TextBox txbKhachDua;
        private TextBox txbTongBill;
        private Label label18;
        private Label label17;
        private Label label16;
        private Panel panel1;
        private Button btnReset;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label10;
        private Label label3;
        private DataGridViewTextBoxColumn dvgMaSP;
        private DataGridViewTextBoxColumn dvgTenSP;
        private DataGridViewTextBoxColumn dvgSoLuong;
        private DataGridViewTextBoxColumn dvgGiaBan;
        private DataGridViewTextBoxColumn dvgTong;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn des;
        private TextBox txbMaKH;
        private Label label6;
    }
}