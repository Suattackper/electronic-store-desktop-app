using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class ChiTietPhieuXuatDAO
    {
        private static ChiTietPhieuXuatDAO instance;

        internal static ChiTietPhieuXuatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuXuatDAO();
                return instance;
            }
        }
        private ChiTietPhieuXuatDAO() { }
        public DataTable Xem()
        {
            string sql = "select * from CHITIETPHIEUXUAT";
            return KetNoiSql.Instance.execSql(sql);
        }
        public bool Them(CHITIETPHIEUXUAT p)
        {
            string sql = "insert into CHITIETPHIEUXUAT (MaSanPham, SoPhieuXuatKho, SoLuong, DonGia) values ( @ma , @sop , @sol , @gia );";
            Object[] prms = new object[] { p.MaSanPham, p.SoPhieuXuatKho, p.SoLuong, p.DonGia };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
    }
}
