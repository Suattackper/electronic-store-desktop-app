using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        internal static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
        }
        private TaiKhoanDAO() { }

        public string checkLogin(TAIKHOAN taikhoan)
        {
            string check = KetNoiSql.Instance.checkLogin(taikhoan);
            return check;
        }
    }
}
