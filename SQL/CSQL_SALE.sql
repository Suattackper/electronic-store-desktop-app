CREATE DATABASE QUAN_LY_BAN_HANG;
GO
USE QUAN_LY_BAN_HANG;
GO
-- COLLATE SQL_Latin1_General_CP1_CS_AS lệnh dùng để phân biệt hoa thường trong sqlserver

CREATE TABLE KHACHHANG (
	MaKhachHang varchar(20) not null,
	HoTen nvarchar(50) not null,
	Email varchar(30) COLLATE SQL_Latin1_General_CP1_CS_AS unique,
	NgayVao DATE DEFAULT GETDATE() NOT NULL CHECK (NgayVao > DATEADD(DAY, -1, GETDATE()) AND NgayVao < DATEADD(DAY, 1, GETDATE())),
	SoDienThoai varchar(15) unique not null,
	DiaChi nvarchar(50),
	primary key (MaKhachHang)
);

CREATE TABLE QUYEN (
	MaQuyen int identity(1,1) not null,
	TenQuyen nVARCHAR(50)
	primary key (MaQuyen)
);

CREATE TABLE NHANVIEN (
	MaNhanVien varchar(20) not null,
	HoTen nvarchar(50) not null,
	CCCD varchar(15) unique not null,
	SoDienThoai varchar(15) unique not null,
	DiaChi nvarchar(50) not null,
	Email varchar(30) COLLATE SQL_Latin1_General_CP1_CS_AS unique not null,
	NgayVao DATE DEFAULT GETDATE() NOT NULL CHECK (NgayVao > DATEADD(DAY, -1, GETDATE()) AND NgayVao < DATEADD(DAY, 1, GETDATE())),
	Anh image,
	MaQuyen int not null,
	primary key (MaNhanVien),
	foreign key (MaQuyen) references Quyen(MaQuyen)
);

CREATE TABLE LOAIHANG (
	MaLoaiHang varchar(20) not null,
	TenLoaiHang nvarchar(50) not null,
	primary key (MaLoaiHang)
);

CREATE TABLE SANPHAM (
	MaSanPham varchar(20) not null,
	TenSanPham nvarchar(50) not null,
	MaLoaiHang varchar(20) not null,
	MoTa nvarchar(500) not null,
	GiaBan decimal(18,2) not null check(GiaBan>=0),
	Anh image,
	primary key (MaSanPham),
	foreign key (MaLoaiHang) references LoaiHang(MaLoaiHang)
);

CREATE TABLE DONMUA (
	MaDonMua int identity(1,1) not null,
	MaNhanVien varchar(20) not null,
	MaKhachHang varchar(20) not null,
	NgayTao DATE DEFAULT GETDATE() NOT NULL CHECK (NgayTao > DATEADD(DAY, -1, GETDATE()) AND NgayTao < DATEADD(DAY, 1, GETDATE())),
	TongTien decimal(18,2) not null,
	primary key (MaDonMua),
	foreign key (MaNhanVien) references NhanVien(MaNhanVien),
	foreign key (MaKhachHang) references KhachHang(MaKhachHang)
);

CREATE TABLE CHITIETDONMUA (
	MaSanPham varchar(20) not null,
	MaDonMua int not null,
	SoLuong int not null check(SoLuong>=0),
	DonGia decimal(18,2) not null check(DonGia>=0),
	primary key (MaDonMua,MaSanPham),
	foreign key (MaSanPham) references SANPHAM(MaSanPham),
	foreign key (MaDonMua) references DONMUA(MaDonMua)
);

CREATE TABLE NHACUNGCAP (
	MaNhaCungCap varchar(20) not null,
	TenNhaCungCap nvarchar(50) not null,
	SoDienThoai varchar(15) unique not null,
	DiaChi varchar(50) not null,
	primary key (MaNhaCungCap)
);

CREATE TABLE PHIEUNHAPKHO (
	SoPhieuNhapKho int identity(1,1) not null,
	NgayNhap DATE DEFAULT GETDATE() NOT NULL CHECK (NgayNhap > DATEADD(DAY, -1, GETDATE()) AND NgayNhap < DATEADD(DAY, 1, GETDATE())),
	MaNhaCungCap varchar(20) not null,
	TamUng money default 0 not null,
	NgayThanhToan date,
	MaNhanVien varchar(20) not null,
	primary key (SoPhieuNhapKho), 
	foreign key (MaNhanVien) references NHANVIEN (MaNhanVien),
	foreign key (MaNhaCungCap) references NHACUNGCAP (MaNhaCungCap)
);

CREATE TABLE CHITIETPHIEUNHAP (
	SoPhieuNhapKho int not null,
	MaSanPham varchar(20) not null,
	SoLuongNhap int not null,
	GiaNhap decimal(18,2) not null check(GiaNhap > 0),
	primary key (SoPhieuNhapKho,MaSanPham),
	foreign key (SoPhieuNhapKho) references PHIEUNHAPKHO (SoPhieuNhapKho),
	foreign key (MaSanPham) references SANPHAM (MaSanPham)
);

CREATE TABLE PHIEUXUATKHO (
	SoPhieuXuatKho int identity(1,1) not null,
	NgayXuat DATE DEFAULT GETDATE() NOT NULL CHECK (NgayXuat > DATEADD(DAY, -1, GETDATE()) AND NgayXuat < DATEADD(DAY, 1, GETDATE())),
	LyDo nvarchar(100) not null,
	MaNhanVien varchar(20) not null,
	primary key (SoPhieuXuatKho),
	foreign key (MaNhanVien) references NHANVIEN (MaNhanVien)
);

CREATE TABLE CHITIETPHIEUXUAT (
	SoPhieuXuatKho int not null,
	MaSanPham varchar(20) not null,
	SoLuong int not null check(SoLuong>=0),
	DonGia decimal(18,2) not null check(DonGia>=0),
	primary key (SoPhieuXuatKho,MaSanPham),
	foreign key (SoPhieuXuatKho) references PHIEUXUATKHO (SoPhieuXuatKho),
	foreign key (MaSanPham) references SANPHAM (MaSanPham)
);

CREATE TABLE TAIKHOAN (
	SoDienThoai varchar(15) unique not null,
	MatKhau varchar(20) COLLATE SQL_Latin1_General_CP1_CS_AS not null,
	MaQuyen int not null,
	foreign key (MaQuyen) references QUYEN (MaQuyen)
);

CREATE TABLE KHO (
	MaSanPham varchar(20) not null,
	SoLuong int not null check(SoLuong>=0),
	foreign key (MaSanPham) references SANPHAM (MaSanPham)
);
