using SaleApp.DAO;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Business
{
    internal class PhieuNhapKhoBUS
    {
        private static PhieuNhapKhoBUS instance;

        internal static PhieuNhapKhoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapKhoBUS();
                return instance;
            }
        }
        private PhieuNhapKhoBUS() { }
        public string Them(PHIEUNHAPKHO p)
        {
            PhieuNhapKhoDAO.Instance.Them(p);
            return "";
        }
        public string getSoPhieuNhapKho()
        {
            string ma = null;
            DataTable check = PhieuNhapKhoDAO.Instance.getSoPhieuNhapKho();
            foreach (DataRow existingRow in check.Rows)
            {
                return existingRow["SoPhieuNhapKho"].ToString();
            }
            return ma;
        }
    }
}
