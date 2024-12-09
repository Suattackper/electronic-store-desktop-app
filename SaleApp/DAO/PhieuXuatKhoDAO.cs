using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class PhieuXuatKhoDAO
    {
        private static PhieuXuatKhoDAO instance;

        internal static PhieuXuatKhoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuXuatKhoDAO();
                return instance;
            }
        }
        private PhieuXuatKhoDAO() { }
        public DataTable Xem()
        {
            string sql = "select * from PHIEUXUATKHO";
            return KetNoiSql.Instance.execSql(sql);
        }
        public bool Them(PHIEUXUATKHO p)
        {
            string sql = "insert into PHIEUXUATKHO (LyDo,MaNhanVien) values ( @lydo, @manv )";
            Object[] prms = new object[] { p.LyDo, p.MaNhanVien };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public DataTable getSoPhieuXuatKho()
        {
            string sql = "select * from PHIEUXUATKHO order by SoPhieuXuatKho desc";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
