using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class SanPhamDAO
    {
        private static SanPhamDAO instance;

        internal static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamDAO();
                return instance;
            }
        }
        private SanPhamDAO() { }

        public DataTable Xem()
        {
            string sql = "select s.masanpham,s.tensanpham,l.tenloaihang,s.giaban,s.mota from sanpham s inner join loaihang l on l.maloaihang=s.maloaihang";
            return KetNoiSql.Instance.execSql(sql);
        }
        public DataTable getAnh(string masp)
        {
            string sql = $"select MaSanPham,Anh from SANPHAM where MaSanPham = '{masp}'";
            return KetNoiSql.Instance.execSql(sql);
        }
        public bool Them(SANPHAM p)
        {
            string sql = "INSERT INTO SANPHAM VALUES( @masp, @tensp, @maloaihang, @mota, @gia, @anh )";
            Object[] prms = new object[] { p.MaSanPham, p.TenSanPham, p.MaLoaiHang, p.MoTa, p.GiaBan, p.Anh };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool Xoa(string pCode)
        {
            string sql = "DELETE SANPHAM WHERE MaSanPham = @masp";
            Object[] prms = new object[] { pCode };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool Sua(SANPHAM sp)
        {
            string sql = "UPDATE SANPHAM SET TenSanPham = @tensp, MaLoaiHang = @mal, GiaBan = @gia, Anh = @anh, MoTa = @mota WHERE MaSanPham = @masp";
            Object[] prms = new object[] { sp.TenSanPham,sp.MaLoaiHang,sp.GiaBan,sp.Anh, sp.MoTa, sp.MaSanPham };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public DataTable Tim(string name)
        {
            string sql = " SELECT s.masanpham,s.tensanpham,l.tenloaihang,s.giaban,s.mota from sanpham s inner join loaihang l on l.maloaihang=s.maloaihang WHERE TenSanPham LIKE @keyword ";
            Object[] prms = new object[] { "%" + name + "%" };
            return KetNoiSql.Instance.execSql(sql, prms);
        }
        public List<SANPHAM> getDataSanPham()
        {
            return KetNoiSql.Instance.getDataSanPham();
        }
        public DataTable getMaSanPham(string masp)
        {
            string sql = $"select MaSanPham,TenSanPham from SANPHAM where TenSanPham = N'{masp}'";
            return KetNoiSql.Instance.execSql(sql);
        }
        public void SetCbx(ComboBox b, string table, string mb)
        {

            string sql = "select * from " + table;
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            b.DataSource = data;
            b.DisplayMember = mb;

        }
    }
}
