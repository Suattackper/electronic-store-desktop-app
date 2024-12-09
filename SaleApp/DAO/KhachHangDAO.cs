using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class KhachHangDAO
    {
        private static KhachHangDAO instance;

        internal static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
        }
        private KhachHangDAO() { }
        public DataTable TimTheoMakh(string ma)
        {
            string sql = "select * from khachhang WHERE makhachhang = @keyword ";
            Object[] prms = new object[] { ma };
            return KetNoiSql.Instance.execSql(sql, prms);
        }
    }
}
