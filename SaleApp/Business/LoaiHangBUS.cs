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
    internal class LoaiHangBUS
    {
        private static LoaiHangBUS instance;

        internal static LoaiHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiHangBUS();
                return instance;
            }
        }
        private LoaiHangBUS() { }

        public void getDataLoaiHang(ComboBox comboBoxQuyen)
        {
            // Sử dụng hàm getDataQuyen để lấy danh sách QUYEN từ CSDL
            List<LOAIHANG> loaih = LoaiHangDAO.Instance.getDataLoaiHang();

            // Thêm dữ liệu vào ComboBox
            comboBoxQuyen.DataSource = loaih; //chọn nguồn dữ liệu
            comboBoxQuyen.DisplayMember = "TenLoaiHang"; // Hiển thị tên quyền trong ComboBox

            comboBoxQuyen.SelectedIndex = 0; // Chọn mục đầu tiên
        }
        public string getMaLoaiHang(string ten)
        {
            string ma = null;
            DataTable check = LoaiHangDAO.Instance.getMaLoaiHang(ten);
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["TenLoaiHang"].ToString() == ten)
                {
                    return existingRow["MaLoaiHang"].ToString();
                }
            }
            return ma;
        }
    }
}
