using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class PhieuNhapKhoDAO
    {
        private static PhieuNhapKhoDAO instance;

        internal static PhieuNhapKhoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapKhoDAO();
                return instance;
            }
        }
        private PhieuNhapKhoDAO() { }

        public DataTable Xem()
        {
            string sql = "SELECT * FROM PHIEUNHAPKHO";
            return KetNoiSql.Instance.execSql(sql);
        }
        public bool Xoa(string pCode)
        {
            string sql = "DELETE PHIEUNHAPKHO WHERE MaNhaCungCap = @mancc";
            Object[] prms = new object[] { pCode };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool Sua(PHIEUNHAPKHO pnk)
        {
            string sql = "UPDATE PHIEUNHAPKHO SET MaNhaCungCap = @mancc WHERE SoPhieuNhapKho = @sopnk";
            Object[] prms = new object[] { pnk.MaNhaCungCap, pnk.SoPhieuNhapKho };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool Them(PHIEUNHAPKHO p)
        {
            string sql = "insert into PHIEUNHAPKHO (MaNhaCungCap,TamUng,MaNhanVien,NgayThanhToan) values ( @ma, @tamung, @manv, @ngaytt )";
            Object[] prms = new object[] { p.MaNhaCungCap, p.TamUng, p.MaNhanVien, p.NgayThanhToan };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public DataTable getSoPhieuNhapKho()
        {
            string sql = "select * from PHIEUNHAPKHO order by SoPhieuNhapKho desc";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
