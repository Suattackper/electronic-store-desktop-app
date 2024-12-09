using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class LoaiHangDAO
    {
        private static LoaiHangDAO instance;

        internal static LoaiHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiHangDAO();
                return instance;
            }
        }
        private LoaiHangDAO() { }

        public List<LOAIHANG> getDataLoaiHang()
        {
            return KetNoiSql.Instance.getDataLoaiHang();
        }
        public DataTable getMaLoaiHang(string masp)
        {
            string sql = $"select MaLoaiHang,TenLoaiHang from LOAIHANG where TenLoaiHang = N'{masp}'";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
