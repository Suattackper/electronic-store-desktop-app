using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class ChiTietPhieuNhapDAO
    {
        private static ChiTietPhieuNhapDAO instance;

        internal static ChiTietPhieuNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuNhapDAO();
                return instance;
            }
        }
        private ChiTietPhieuNhapDAO() { }

        public DataTable Xem()
        {
            string sql = "SELECT * FROM CHITIETPHIEUNHAP";
            return KetNoiSql.Instance.execSql(sql);
        }
        public bool Xoa(string pCode)
        {
            string sql = "DELETE CHITIETPHIEUNHAP WHERE SoPhieuNhapKho = @code";
            Object[] prms = new object[] { pCode };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool Them(CHITIETPHIEUNHAP p)
        {
            string sql = "insert into CHITIETPHIEUNHAP (MaSanPham, SoPhieuNhapKho, SoLuongNhap, GiaNhap) values ( @ma , @sop , @sol , @gia );";
            Object[] prms = new object[] { p.MaSanPham, p.SoPhieuNhapKho, p.SoLuongNhap, p.GiaNhap };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
    }
}
