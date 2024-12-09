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
    internal class PhieuXuatKhoBUS
    {
        private static PhieuXuatKhoBUS instance;

        internal static PhieuXuatKhoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuXuatKhoBUS();
                return instance;
            }
        }
        private PhieuXuatKhoBUS() { }
        public string Them(PHIEUXUATKHO p)
        {
            PhieuXuatKhoDAO.Instance.Them(p);
            return "";
        }
        public string getSoPhieuXuatKho()
        {
            string ma = null;
            DataTable check = PhieuXuatKhoDAO.Instance.getSoPhieuXuatKho();
            foreach (DataRow existingRow in check.Rows)
            {
                return existingRow["SoPhieuXuatKho"].ToString();
            }
            return ma;
        }
    }
}
