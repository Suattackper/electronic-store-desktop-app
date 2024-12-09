using SaleApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Business
{
    internal class KhoBUS
    {
        private static KhoBUS instance;

        internal static KhoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhoBUS();
                return instance;
            }
        }
        private KhoBUS() { }
        public void XemHangTon(DataGridView dgv)
        {
            dgv.DataSource = KhoDAO.Instance.XemHangTon();
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã sản phẩm";
            dgv.Columns[1].HeaderText = "Tên sản phẩm";
            dgv.Columns[2].HeaderText = "Loại";
            dgv.Columns[3].HeaderText = "Số lượng tồn";
        }
    }
}
