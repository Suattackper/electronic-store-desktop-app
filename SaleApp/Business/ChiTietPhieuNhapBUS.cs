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
    internal class ChiTietPhieuNhapBUS
    {
        private static ChiTietPhieuNhapBUS instance;

        internal static ChiTietPhieuNhapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuNhapBUS();
                return instance;
            }
        }
        private ChiTietPhieuNhapBUS() { }
        public string Them(CHITIETPHIEUNHAP p)
        {
            if (p.SoLuongNhap == null)
            {
                return "errorSo";
            }
            if (p.GiaNhap == null)
            {
                return "errorGia";
            }
            if (p.MaSanPham == null)
            {
                return "errorMa";
            }
            if (p.SoPhieuNhapKho == null)
            {
                return "errorSop";
            }
            KHO k = new KHO();
            k.MaSanPham = p.MaSanPham;
            k.SoLuong = p.SoLuongNhap;
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
            ChiTietPhieuNhapDAO.Instance.Them(p);
            return "";
        }
    }
}
