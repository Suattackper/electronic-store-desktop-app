using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class ChiTietDonMuaDAO
    {
        private static ChiTietDonMuaDAO instance;

        internal static ChiTietDonMuaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietDonMuaDAO();
                return instance;
            }
        }
        private ChiTietDonMuaDAO() { }
        public DataTable Xem()
        {
            string sql = "select * from CHITIETDONMUA";
            return KetNoiSql.Instance.execSql(sql);
        }
        public bool Them(CHITIETDONMUA p)
        {
            string sql = "insert into CHITIETDONMUA (MaSanPham, MaDonMua, SoLuong, DonGia) values ( @ma , @sop , @sol , @gia );";
            Object[] prms = new object[] { p.MaSanPham, p.MaDonMua, p.SoLuong, p.DonGia };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
    }
}
