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
    internal class ChiTietDonMuaBUS
    {
        private static ChiTietDonMuaBUS instance;

        internal static ChiTietDonMuaBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietDonMuaBUS();
                return instance;
            }
        }
        private ChiTietDonMuaBUS() { }
        public string Them(CHITIETDONMUA p)
        {
            if (p.MaSanPham == null)
            {
                return "errormasp";
            }
            if (p.MaDonMua == null)
            {
                return "errormadm";
            }
            if (p.SoLuong == null)
            {
                return "errorsol";
            }
            if (p.DonGia == null)
            {
                return "errordong";
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
            ChiTietDonMuaDAO.Instance.Them(p);
            return "";
        }
    }
}
