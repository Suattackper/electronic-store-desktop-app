using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class QuyenDAO
    {
        private static QuyenDAO instance;

        internal static QuyenDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuyenDAO();
                return instance;
            }
        }
        private QuyenDAO() { }

        public List<QUYEN> getDataQuyen()
        {
            return KetNoiSql.Instance.getDataQuyen();
        }
        public DataTable getMaQuyen(string ma)
        {
            string sql = $"select * from QUYEN where TenQuyen = '{ma}'";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
