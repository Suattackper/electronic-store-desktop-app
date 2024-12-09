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
    internal class ChiTietPhieuXuatBUS
    {
        private static ChiTietPhieuXuatBUS instance;

        internal static ChiTietPhieuXuatBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuXuatBUS();
                return instance;
            }
        }
        private ChiTietPhieuXuatBUS() { }
        public string Them(CHITIETPHIEUXUAT p)
        {
            if (p.SoLuong == null)
            {
                return "errorSo";
            }
            if (p.DonGia == null)
            {
                return "errorGia";
            }
            if (p.MaSanPham == null)
            {
                return "errorMa";
            }
            if (p.SoPhieuXuatKho == null)
            {
                return "errorSop";
            }
            KHO k = new KHO();
            k.MaSanPham = p.MaSanPham;
            k.SoLuong = -p.SoLuong;
            bool kt = false;
            //kiểm tra mã sp đã tồn tại chưa
            DataTable check = KhoDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["MaSanPham"].ToString() == k.MaSanPham)
                {
                    kt = true;
                    break;
                }
            }
            if (kt) KhoDAO.Instance.CatNhatThem(k);
            else KhoDAO.Instance.Them(k);
            ChiTietPhieuXuatDAO.Instance.Them(p);
            return "";
        }
    }
}
