using SaleApp.DAO;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Business
{
    internal class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        internal static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
        }
        private TaiKhoanBUS() { }

        public string checkLogin(TAIKHOAN taikhoan)
        {
            if (taikhoan.SoDienThoai == "")
            {
                return "errorTaikhoan";
            }
            if (taikhoan.MatKhau == "")
            {
                return "errorMatkhau";
            }
            string check = TaiKhoanDAO.Instance.checkLogin(taikhoan);
            return check;
        }
    }
}
