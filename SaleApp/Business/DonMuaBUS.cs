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
    internal class DonMuaBUS
    {
        private static DonMuaBUS instance;

        internal static DonMuaBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonMuaBUS();
                return instance;
            }
        }
        private DonMuaBUS() { }
        public void ThongKe(DataGridView dgv)
        {
            dgv.DataSource = DonMuaDAO.Instance.ThongKe();
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã đơn mua";
            dgv.Columns[1].HeaderText = "Tên khách hàng";
            dgv.Columns[2].HeaderText = "Ngày mua";
            dgv.Columns[3].HeaderText = "Mã nhân viên";
            dgv.Columns[4].HeaderText = "Tổng tiền";
        }
        public void ThongKeTheoNam(DataGridView dgv, int nam)
        {
            dgv.DataSource = DonMuaDAO.Instance.ThongKeTheoNam(nam);
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã đơn mua";
            dgv.Columns[1].HeaderText = "Tên khách hàng";
            dgv.Columns[2].HeaderText = "Ngày mua";
            dgv.Columns[3].HeaderText = "Mã nhân viên";
            dgv.Columns[4].HeaderText = "Tổng tiền";
        }
        public void ThongKeTheoNamThang(DataGridView dgv, int nam, int thang)
        {
            dgv.DataSource = DonMuaDAO.Instance.ThongKeTheoNamThang(nam,thang);
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã đơn mua";
            dgv.Columns[1].HeaderText = "Tên khách hàng";
            dgv.Columns[2].HeaderText = "Ngày mua";
            dgv.Columns[3].HeaderText = "Mã nhân viên";
            dgv.Columns[4].HeaderText = "Tổng tiền";
        }
        public void Tim(DataGridView dgv, string tenkh)
        {
            dgv.DataSource = DonMuaDAO.Instance.Tim(tenkh);
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã đơn mua";
            dgv.Columns[1].HeaderText = "Tên khách hàng";
            dgv.Columns[2].HeaderText = "Ngày mua";
            dgv.Columns[3].HeaderText = "Mã nhân viên";
            dgv.Columns[4].HeaderText = "Tổng tiền";
        }
        public DONMUA TimTheoMadm(int ma)
        {
            DONMUA p = new DONMUA();
            DataTable check = DonMuaDAO.Instance.TimTheoMadm(ma);
            if (check != null && check.Rows.Count > 0)
            {
                DataRow existingRow = check.Rows[0]; // Chỉ lấy hàng đầu tiên (nếu có)

                p.MaDonMua = existingRow.Field<int>("MaDonMua");
                p.MaNhanVien = existingRow.Field<string>("MaNhanVien");
                p.MaKhachHang = existingRow.Field<string>("MaKhachHang");
                p.TongTien = existingRow.Field<decimal>("TongTien");
                p.NgayTao = existingRow.Field<DateTime>("NgayTao");
            }
            return p;
        }
        public void XemChiTietDon(DataGridView dgv, int ma)
        {
            dgv.DataSource = DonMuaDAO.Instance.XemChiTietDon(ma);
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã SP";
            dgv.Columns[1].HeaderText = "Tên SP";
            dgv.Columns[2].HeaderText = "Số lượng";
            dgv.Columns[3].HeaderText = "Giá bán";
            dgv.Columns[4].HeaderText = "Thành tiền";
        }
        public string getMaDonMua()
        {
            string ma = null;
            DataTable check = DonMuaDAO.Instance.getMaDonMua();
            foreach (DataRow existingRow in check.Rows)
            {
                return existingRow["MaDonMua"].ToString();
            }
            return ma;
        }
    }
}
