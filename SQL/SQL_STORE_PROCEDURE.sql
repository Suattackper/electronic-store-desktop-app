USE QUAN_LY_BAN_HANG;
GO

create or alter proc sp_checkLogin(@sodienthoai nvarchar(50),@matkhau nvarchar(50),@maquyen int)
as 
begin
	select * from TAIKHOAN where SoDienThoai = @sodienthoai and MatKhau = @matkhau and MaQuyen = @maquyen;
end

execute sp_checkLogin 'admin','admin',1;



create or alter proc sp_getTongDoanhThu
as
begin
	select sum(tongtien) tong from donmua
end
go
exec sp_getTongDoanhThu

create or alter proc sp_getTongDoanhThuTheoNam
@n int
as
begin
	select sum(tongtien) tong from donmua where year(ngaytao)=@n
end
go
exec sp_getTongDoanhThuTheoNam 2022

create or alter proc sp_getTongDoanhThuTheoNamThang
@n int, @t int
as
begin
	select sum(tongtien) tong from donmua where year(ngaytao)=@n and month(ngaytao)=@t
end
go
exec sp_getTongDoanhThuTheoNamThang 2023,10

create or alter proc sp_getTongKhachHang
as
begin
	select distinct count(makhachhang) tongkh from donmua
end
go
exec sp_getTongKhachHang

create or alter proc sp_getTongKhachHangTheoNam
@n int
as
begin
	select distinct count(makhachhang) tongkh from  donmua where year(ngaytao)=@n
end
go
exec sp_getTongKhachHangTheoNam 2023

create or alter proc sp_getTongKhachHangTheoNamThang
@n int, @t int
as
begin
	select distinct count(makhachhang) tongkh from  donmua where year(ngaytao)=@n and month(ngaytao)=@t
end
go
exec sp_getTongKhachHangTheoNamThang 2023,10

create or alter proc sp_getTongSanPham
as
begin
	SELECT SUM(soluong) AS tong_soluong FROM chitietdonmua
end
go 
exec sp_getTongSanPham 

create or alter proc sp_getTongSanPhamTheoNam
@n int
as
begin
	SELECT SUM(soluong) AS tong_soluong FROM chitietdonmua c inner join donmua d on d.madonmua=c.madonmua where year(d.ngaytao)=@n
		
end
go 
exec sp_getTongSanPhamTheoNam 2023 

create or alter proc sp_getTongSanPhamTheoNamThang
@n int,@t int
as
begin
	SELECT SUM(soluong) AS tong_soluong FROM chitietdonmua c inner join donmua d on d.madonmua=c.madonmua where year(d.ngaytao)=@n and month(d.ngaytao)=@t
		
end
go 
exec sp_getTongSanPhamTheoNamThang 2023,11

create or alter proc sp_getTongDonMua
as
begin
	select count(madonmua) tongdm from donmua
end
go 
exec sp_getTongDonMua 

create or alter proc sp_getTongDonMuaTheoNam
@n int
as
begin
	select count(madonmua) tongdm from donmua where year(ngaytao)=@n
end
go 
exec sp_getTongDonMuaTheoNam 2023 

create or alter proc sp_getTongDonMuaTheoNamThang
@n int, @t int
as
begin
	select count(madonmua) tongdm from donmua where year(ngaytao)=@n and month(ngaytao)=@t
end
go 
exec sp_getTongDonMuaTheoNamThang 2023,10 

--create or alter proc sp_getDoanhThu
--@thang int, @nam int
--as
--begin
--	if @thang = 0
--	begin
--		select k.masanpham,s.tensanpham,l.tenloaihang,k.soluong 
--		from kho k 
--		inner join sanpham s on s.masanpham = k.masanpham inner join loaihang l on l.maloaihang = s.maloaihang
--		where
		
--	end
--end
--go 
--exec sp_getTongSanPham 
--drop proc sp_getTongSanPham
--go
--create or alter function sp_getTongSanPham()
--returns int
--as
--begin
--	return (
--	SELECT SUM(tong_soluong) AS tong_tat_ca
--	FROM (
--		SELECT SUM(soluong) AS tong_soluong FROM chitietdonmua
--		UNION ALL -- hợp 2 bảng thảnh 1
--		SELECT SUM(soluong) AS tong_soluong FROM chitietphieuxuat
--	) AS combined_data --AS combined_data tạo bảng tạm thời để truy vấn
--	);
--end
--go
--SELECT dbo.sp_getTongSanPham() as aa

--drop function sp_getTongSanPham


