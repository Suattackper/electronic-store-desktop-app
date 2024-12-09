using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class DonMuaDAO
    {
        private static DonMuaDAO instance;

        internal static DonMuaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonMuaDAO();
                return instance;
            }
        }
        private DonMuaDAO() { }

        public DataTable Xem()
        {
            string sql = "SELECT * FROM DONMUA";
            return KetNoiSql.Instance.execSql(sql);
        }
        public DataTable ThongKe()
        {
            string sql = "select distinct d.madonmua, k.hoten, d.ngaytao, d.manhanvien, d.tongtien from donmua d inner join khachhang k on d.makhachhang=k.makhachhang inner join chitietdonmua c on c.madonmua=d.madonmua";
            return KetNoiSql.Instance.execSql(sql);
        }
        public DataTable ThongKeTheoNam(int nam)
        {
            string sql = "select distinct d.madonmua, k.hoten, d.ngaytao, d.manhanvien, d.tongtien  from donmua d inner join khachhang k on d.makhachhang=k.makhachhang inner join chitietdonmua c on c.madonmua=d.madonmua where year(d.ngaytao)= @nam ";
            Object[] prms = new object[] { nam };
            return KetNoiSql.Instance.execSql(sql, prms);
        }
        public DataTable ThongKeTheoNamThang(int nam, int thang)
        {
            string sql = "select distinct d.madonmua, k.hoten, d.ngaytao, d.manhanvien, d.tongtien  from donmua d inner join khachhang k on d.makhachhang=k.makhachhang inner join chitietdonmua c on c.madonmua=d.madonmua where year(d.ngaytao)= @nam and month(d.ngaytao)= @thang ";
            Object[] prms = new object[] { nam,thang};
            return KetNoiSql.Instance.execSql(sql, prms);
        }
        public DataTable Tim(string name)
        {
            string sql = "select distinct d.madonmua, k.hoten, d.ngaytao, d.manhanvien, d.tongtien from donmua d inner join khachhang k on d.makhachhang=k.makhachhang inner join chitietdonmua c on c.madonmua=d.madonmua WHERE k.hoten LIKE @keyword ";
            Object[] prms = new object[] { "%" + name + "%" };
            return KetNoiSql.Instance.execSql(sql, prms);
        }
        public DataTable TimTheoMadm(int ma)
        {
            string sql = "select * from donmua WHERE madonmua = @keyword ";
            Object[] prms = new object[] { ma };
            return KetNoiSql.Instance.execSql(sql, prms);
        }
        public DataTable XemChiTietDon(int ma)
        {
            string sql = "select c.masanpham, s.tensanpham, c.soluong, s.giaban, s.giaban*c.soluong thanhtien from chitietdonmua c inner join sanpham s on s.masanpham = c.masanpham where c.madonmua = @keyword ";
            Object[] prms = new object[] { ma };
            return KetNoiSql.Instance.execSql(sql, prms);
        }
        public DataTable getMaDonMua()
        {
            string sql = "select * from DONMUA order by MaDonMua desc";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
