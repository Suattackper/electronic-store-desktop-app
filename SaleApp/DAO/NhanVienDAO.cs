using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }
        private NhanVienDAO() { }
        public DataTable getMaNhanVien(string masp)
        {
            string sql = $"select MaNhanVien,SoDienThoai from NHANVIEN where SoDienThoai = '{masp}'";
            return KetNoiSql.Instance.execSql(sql);
        }
        public DataTable Xem()
        {
            string sql = "select n.manhanvien,n.hoten,q.tenquyen,n.cccd,n.sodienthoai,n.diachi,n.email,n.ngayvao from nhanvien n, quyen q where n.maquyen=q.maquyen";
            return KetNoiSql.Instance.execSql(sql);
        }

        public DataTable getAnh(string masp)
        {
            string sql = $"select MaNhanVien,Anh from NHANVIEN where MaNhanVien = '{masp}'";
            return KetNoiSql.Instance.execSql(sql);
        }
        public bool Them(NHANVIEN p)
        {
            string sql = "INSERT INTO NHANVIEN VALUES( @manv, @hoten, @cccd, @sđt, @diachi, @email, getdate(), @anh, @maquyen )";
            Object[] prms = new object[] { p.MaNhanVien, p.HoTen, p.CCCD, p.SoDienThoai, p.DiaChi, p.Email, p.Anh, p.MaQuyen };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool Xoa(string pCode)
        {
            string sql = "DELETE NHANVIEN WHERE MaNhanVien = @ma";
            Object[] prms = new object[] { pCode };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool Sua(NHANVIEN nv)
        {
            string sql = "UPDATE NHANVIEN SET HoTen = @tennv, CCCD = @cccd, SoDienThoai = @sdt, DiaChi = @diachi, Email = @email, Anh = @anh, MaQuyen = @maquyen WHERE MaNhanVien = @manv";
            Object[] prms = new object[] { nv.HoTen, nv.CCCD, nv.SoDienThoai, nv.DiaChi, nv.Email, nv.Anh, nv.MaQuyen, nv.MaNhanVien };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        //public DataTable Tim(string name)
        //{
        //    string sql = " SELECT s.masanpham,s.tensanpham,l.tenloaihang,s.giaban from sanpham s inner join loaihang l on l.maloaihang=s.maloaihang WHERE TenSanPham LIKE @keyword ";
        //    Object[] prms = new object[] { "%" + name + "%" };
        //    return KetNoiSql.Instance.execSql(sql, prms);
        //}
    }
}
