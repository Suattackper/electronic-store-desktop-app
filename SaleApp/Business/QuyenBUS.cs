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
    internal class QuyenBUS
    {
        private static QuyenBUS instance;

        internal static QuyenBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuyenBUS();
                return instance;
            }
        }
        private QuyenBUS() { }

        public void getDataQuyen(ComboBox comboBoxQuyen)
        {
            // Sử dụng hàm getDataQuyen để lấy danh sách QUYEN từ CSDL
            List<QUYEN> quyens = QuyenDAO.Instance.getDataQuyen();

            // Thêm dữ liệu vào ComboBox
            comboBoxQuyen.DataSource = quyens; //chọn nguồn dữ liệu
            comboBoxQuyen.DisplayMember = "TenQuyen"; // Hiển thị tên quyền trong ComboBox

            comboBoxQuyen.SelectedIndex = 0; // Chọn mục đầu tiên là mục trống
        }
        public string getMaQuyen(string ten)
        {
            string ma = null;
            DataTable check = QuyenDAO.Instance.getMaQuyen(ten);
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["TenQuyen"].ToString() == ten)
                {
                    return existingRow["MaQuyen"].ToString();
                }
            }
            return ma;
        }
    }
}
