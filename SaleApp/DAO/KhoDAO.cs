using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class KhoDAO
    {
        private static KhoDAO instance;

        internal static KhoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhoDAO();
                return instance;
            }
        }
        private KhoDAO() { }
        public DataTable Xem()
        {
            string sql = "select * from kho";
            return KetNoiSql.Instance.execSql(sql);
        }
        public DataTable XemHangTon()
        {
            string sql = "select k.masanpham,s.tensanpham,l.tenloaihang,k.soluong from kho k inner join sanpham s on s.masanpham = k.masanpham inner join loaihang l on l.maloaihang = s.maloaihang";
            return KetNoiSql.Instance.execSql(sql);
        }
        public bool Them(KHO p)
        {
            string sql = "insert into KHO (MaSanPham, SoLuong) values ( @ma , @sol );";
            Object[] prms = new object[] { p.MaSanPham, p.SoLuong };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool CatNhatThem(KHO p)
        {
            string sql = "update KHO set soluong = soluong + @sol where masanpham = @ma ;";
            Object[] prms = new object[] { p.SoLuong, p.MaSanPham };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
    }
}
