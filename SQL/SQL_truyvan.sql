USE QUAN_LY_BAN_HANG;
GO

insert into quyen values('Admin')
insert into quyen values('Employee')
insert into taikhoan values('0369787811','0369787811',1)
insert into taikhoan values('0369787822','0369787822',2)
insert into loaihang values('lh1','Smarthome')
insert into loaihang values('lh2','Gaming Gear')
insert into loaihang values('lh3',N'Thiết bị mạng')
insert into loaihang values('lh4',N'Phụ kiện laptop - máy tính')


alter table khachhang 
--alter column Email varchar(30) null
alter column DiaChi nvarchar(50) null
select s.masanpham,s.tensanpham,l.tenloaihang,s.giaban
from sanpham s
inner join loaihang l on l.maloaihang=s.maloaihang

select MaSanPham,Anh from SANPHAM

select n.manhanvien,n.hoten,q.tenquyen,n.cccd,n.sodienthoai
,n.diachi,n.email,n.ngayvao
from nhanvien n, quyen q
where n.maquyen=q.maquyen

select s.masanpham,s.tensanpham,l.tenloaihang,SUM(pn.soluongnhap) soluong
from sanpham s 
inner join chitietphieunhap pn on s.masanpham=pn.masanpham
inner join loaihang l on l.maloaihang = s.maloaihang
group by s.masanpham,s.tensanpham,l.tenloaihang

select * from PHIEUNHAPKHO order by SoPhieuNhapKho desc

SELECT * FROM CHITIETPHIEUNHAP where masanpham = '1' order by sophieunhapkho

select * from kho

update KHO set soluong = soluong+1 where masanpham = 1 ;

select k.masanpham,s.tensanpham,l.tenloaihang,k.soluong from kho k 
inner join sanpham s on s.masanpham = k.masanpham inner join loaihang l on l.maloaihang = s.maloaihang

select distinct d.madonmua, k.hoten, d.ngaytao, d.manhanvien, d.tongtien from donmua d
inner join khachhang k on d.makhachhang=k.makhachhang
inner join chitietdonmua c on c.madonmua=d.madonmua

select sum(tongtien) tong from donmua 
select sum(tongtien),count(madonmua) from donmua 

select count(makhachhang) tongkh from khachhang


SELECT SUM(tong_soluong) AS tong_tat_ca
FROM (
    SELECT SUM(soluong) AS tong_soluong FROM chitietdonmua
    UNION ALL -- hợp 2 bảng thảnh 1
    SELECT SUM(soluong) AS tong_soluong FROM chitietphieuxuat
) AS combined_data; --AS combined_data tạo bảng tạm thời để truy vấn

select * from donmua WHERE madonmua = 1

select * from khachhang WHERE makhachhang = '15'

select c.masanpham, s.tensanpham, c.soluong, s.giaban, s.giaban*c.soluong thanhtien from chitietdonmua c
inner join sanpham s on s.masanpham = c.masanpham
where c.madonmua = 2

select distinct d.madonmua, k.hoten, d.ngaytao, d.manhanvien, d.tongtien 
from donmua d 
inner join khachhang k on d.makhachhang=k.makhachhang 
inner join chitietdonmua c on c.madonmua=d.madonmua
where year(d.ngaytao)=2023 and month(d.ngaytao)=10

select s.masanpham,s.tensanpham,l.tenloaihang,k.soluong,s.giaban, s.anh 
from sanpham s 
inner join loaihang l on l.maloaihang=s.maloaihang
inner join kho k on k.masanpham=s.masanpham
where k.soluong>0
