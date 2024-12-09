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
    internal class KhachHangBUS
    {
        private static KhachHangBUS instance;

        internal static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return instance;
            }
        }
        private KhachHangBUS() { }
        public KHACHHANG TimTheoMakh(string ma)
        {
            KHACHHANG p = new KHACHHANG();
            DataTable check = KhachHangDAO.Instance.TimTheoMakh(ma);
            if (check != null && check.Rows.Count > 0)
            {
                DataRow existingRow = check.Rows[0]; // Chỉ lấy hàng đầu tiên (nếu có)

                p.MaKhachHang = existingRow.Field<string>("MaKhachHang");
                p.HoTen = existingRow.Field<string>("HoTen");
                p.Email = existingRow.Field<string>("Email");
                p.NgayVao = existingRow.Field<DateTime>("NgayVao");
                p.SoDienThoai = existingRow.Field<string>("SoDienThoai");
                p.DiaChi = existingRow.Field<string>("DiaChi");
            }
            return p;
        }
    }
}
