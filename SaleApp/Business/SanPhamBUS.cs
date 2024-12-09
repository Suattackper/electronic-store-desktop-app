using SaleApp.DAO;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SaleApp.Business
{
    internal class SanPhamBUS
    {
        private static SanPhamBUS instance;

        internal static SanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamBUS();
                return instance;
            }
        }
        private SanPhamBUS() { }

        public void Xem(DataGridView dgv)
        {
            dgv.DataSource = SanPhamDAO.Instance.Xem();
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã sản phẩm";
            dgv.Columns[1].HeaderText = "Tên sản phẩm";
            dgv.Columns[2].HeaderText = "Loại hàng";
            dgv.Columns[3].HeaderText = "Giá bán";
            dgv.Columns[4].HeaderText = "Mô tả";
        }
        public byte[] getAnh(string masp)
        {
            byte[] image = null;
            DataTable check = SanPhamDAO.Instance.getAnh(masp);
            if (check.Rows.Count > 0)
            {
                // Kiểm tra xem có dữ liệu hình ảnh trong bảng
                DataRow row = check.Rows[0];
                if (row["Anh"] != DBNull.Value)
                {
                    // Lấy dữ liệu hình ảnh từ cơ sở dữ liệu
                    image = (byte[])row["Anh"];
                }
            }
            return image;
        }
        public string Them(SANPHAM p)
        {
            if (p.TenSanPham == "")
            {
                return "errorTen";
            }
            if (p.MaSanPham == "")
            {
                return "errorMa";
            }
            if (p.MaLoaiHang == null)
            {
                return "errorMal";
            }
            if (p.Anh == null)
            {
                return "errorAnh";
            }
            if (p.MoTa == "")
            {
                return "errorMot";
            }
            if (p.GiaBan == null)
            {
                return "errorGia";
            }
            if (!Regex.IsMatch(p.GiaBan.ToString(), @"^\d+(\.\d+)?$")) //as
            {
                return "errorGia2";
            }
            if (p.GiaBan <= 0){
                return "errorGia1";
            }
            //kiểm tra mã sp đã tồn tại chưa
            DataTable check = SanPhamDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["MaSanPham"].ToString() == p.MaSanPham)
                {
                    return "error1";
                }
            }
            SanPhamDAO.Instance.Them(p);
            return "";
        }
        public bool Xoa(DataGridView dgv)
        {
            //lấy dữ liệu cột đầu đang được chọn
            string code = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value + "";
            //kiem tra xem masp có tồn tại trong chi tiet phieu nhap, chi tiet phieu xuat hay chi tiets don mua không
            DataTable check = ChiTietPhieuNhapDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["MaSanPham"].ToString() == code)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này này!", "Thông báo!");
                    return false;
                }
            }
            DataTable check1 = ChiTietPhieuXuatDAO.Instance.Xem();
            foreach (DataRow existingRow in check1.Rows)
            {
                if (existingRow["MaSanPham"].ToString() == code)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này này!", "Thông báo!");
                    return false;
                }
            }
            DataTable check2 = ChiTietDonMuaDAO.Instance.Xem();
            foreach (DataRow existingRow in check2.Rows)
            {
                if (existingRow["MaSanPham"].ToString() == code)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này này!", "Thông báo!");
                    return false;
                }
            }
            return SanPhamDAO.Instance.Xoa(code);
        }
        public string Sua(SANPHAM p)
        {

            if (p.TenSanPham == "")
            {
                return "errorTen";
            }
            if (p.MaSanPham == "")
            {
                return "errorMa";
            }
            if (p.MaLoaiHang == null)
            {
                return "errorMal";
            }
            if (p.Anh == null)
            {
                return "errorAnh";
            }
            if (p.MoTa == "")
            {
                return "errorMot";
            }
            if (p.GiaBan == null)
            {
                return "errorGia";
            }
            if (!Regex.IsMatch(p.GiaBan.ToString(), @"^\d+(\.\d+)?$"))
            {
                return "errorGia2";
            }
            if (p.GiaBan <= 0)
            {
                return "errorGia1";
            }
            SanPhamDAO.Instance.Sua(p);
            return "";
        }
        public void Tim(DataGridView dgv, string tenncc)
        {
            dgv.DataSource = SanPhamDAO.Instance.Tim(tenncc);
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã sản phẩm";
            dgv.Columns[1].HeaderText = "Tên sản phẩm";
            dgv.Columns[2].HeaderText = "Loại hàng";
            dgv.Columns[3].HeaderText = "Giá bán";
            dgv.Columns[4].HeaderText = "Mô tả";
        }
        public void getDataSanPham(ComboBox comboBoxQuyen)
        {
            // Sử dụng hàm getDataQuyen để lấy danh sách QUYEN từ CSDL
            List<SANPHAM> loaih = SanPhamDAO.Instance.getDataSanPham();

            // Thêm dữ liệu vào ComboBox
            comboBoxQuyen.DataSource = loaih; //chọn nguồn dữ liệu
            comboBoxQuyen.DisplayMember = "TenSanPham"; // Hiển thị tên quyền trong ComboBox

            comboBoxQuyen.SelectedIndex = 0; // Chọn mục đầu tiên
        }
        public string getMaSanPham(string ten)
        {
            string ma = null;
            DataTable check = SanPhamDAO.Instance.getMaSanPham(ten);
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["TenSanPham"].ToString() == ten)
                {
                    return existingRow["MaSanPham"].ToString();
                }
            }
            return ma;
        }
        public void GetTongBill(TextBox txbTongBill, DataGridView dataGridView1)
        {
            double tong = 0;
            txbTongBill.Text = "";

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["dvgTong"].Value != null)
                {
                    double giaTriTong;
                    if (double.TryParse(item.Cells["dvgTong"].Value.ToString(), out giaTriTong))
                    {
                        tong += giaTriTong;
                    }
                }
            }

            txbTongBill.Text = tong.ToString("N0");
        }

        public void CalcTongTien(DataGridView dataGridView1, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "dvgSoLuong")
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int soLuongHienTai = int.Parse(selectedRow.Cells["dvgSoLuong"].Value.ToString());
                DataGridViewCell cellGiaBan = dataGridView1.Rows[e.RowIndex].Cells["dvgGiaBan"];
                float giaBan = float.Parse(selectedRow.Cells["dvgGiaBan"].Value.ToString());
                selectedRow.Cells["dvgTong"].Value = (soLuongHienTai * giaBan).ToString("N0");
            }
        }

        public void ActionWithDVG(DataGridView dataGridView1, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // người dùng đã chọn 
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Bạn thực sự muốn xóa sản phẩm này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == System.Windows.Forms.DialogResult.OK)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "des")
                {
                    int soLuongHienTai = int.Parse(selectedRow.Cells["dvgSoLuong"].Value.ToString());
                    selectedRow.Cells["dvgSoLuong"].Value = soLuongHienTai - 1;
                    if (int.Parse(selectedRow.Cells["dvgSoLuong"].Value.ToString()) <= 0)
                    {
                        if (MessageBox.Show("Bạn thực sự muốn xóa sản phẩm này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == System.Windows.Forms.DialogResult.OK)
                        {
                            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                        }
                        else
                        {
                            selectedRow.Cells["dvgSoLuong"].Value = 1;
                        }
                    }
                }
            }
        }

        public void ActionModelSanPham(ModelSanPham S, DataGridView dataGridView1, TextBox txbTongBill, DataTable dt)
        {
            S.onSelect += (ss, ee) =>
            {

                var wdg = (ModelSanPham)ss;

                bool SanPhamDaTonTai = false;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["dvgMaSP"].Value != null && item.Cells["dvgMaSP"].Value.ToString() == wdg.MaSanPham.ToString())
                    {

                        // Sản phẩm đã tồn tại trong DataGridView, tăng số lượng và cập nhật tổng tiền
                        int soLuongHienTai = int.Parse(item.Cells["dvgSoLuong"].Value.ToString());
                        if (soLuongHienTai+1 > S.SoLuong)
                        {
                            MessageBox.Show("Không đủ số lượng trong kho!", "Error!");
                            return;
                        }
                        item.Cells["dvgSoLuong"].Value = soLuongHienTai + 1;

                        float giaBan = float.Parse(item.Cells["dvgGiaBan"].Value.ToString());
                        item.Cells["dvgTong"].Value = (giaBan * (soLuongHienTai + 1)).ToString("N0");
                        SanPhamBUS.Instance.GetTongBill(txbTongBill, dataGridView1);
                        SanPhamDaTonTai = true;
                        break; // thoát khỏi vòng lặp vì sản phẩm đã tồn tại
                    }
                }

                if (SanPhamDaTonTai == false)
                {
                    // thêm sản phầm nếu nó chưa tồn tại
                    dataGridView1.Rows.Add(new object[] { wdg.MaSanPham, wdg.TenSanPham, 1, wdg.GiaBan.ToString("N0"), wdg.GiaBan.ToString("N0") });

                    SanPhamBUS.Instance.GetTongBill(txbTongBill, dataGridView1);
                }

            };

        }
        public void checkSame()
        {

        }
        public void LoadData(DataTable dt, DataGridView dataGridView1)
        {
            dt.Clear();
            // Kiểm tra xem cột có tồn tại trong DataTable chưa trước khi thêm
            if (!dt.Columns.Contains("Mã SP"))
            {
                // Nếu chưa tồn tại, thì thêm cột mới
                dt.Columns.Add("Mã SP");
            }

            // Tiếp tục kiểm tra và thêm các cột khác
            if (!dt.Columns.Contains("Tên SP"))
            {
                dt.Columns.Add("Tên SP");

            }
            if (!dt.Columns.Contains("Số Lượng"))
            {
                dt.Columns.Add("Số Lượng");
            }
            if (!dt.Columns.Contains("Giá Bán"))
            {
                dt.Columns.Add("Giá Bán");
            }
            if (!dt.Columns.Contains("Tổng"))
            {
                dt.Columns.Add("Tổng");
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow newRow = dt.NewRow();
                newRow["Mã SP"] = row.Cells["dvgMaSP"].Value;
                //if (row.Cells["dvgMaSP"].Value == r)
                newRow["Tên SP"] = row.Cells["dvgTenSP"].Value;
                newRow["Số Lượng"] = Convert.ToInt32(row.Cells["dvgSoLuong"].Value); // Ép kiểu về int
                newRow["Giá Bán"] = Convert.ToSingle(row.Cells["dvgGiaBan"].Value).ToString("N0"); // Ép kiểu về float
                newRow["Tổng"] = Convert.ToSingle(row.Cells["dvgTong"].Value).ToString("N0");
                dt.Rows.Add(newRow);
            }
        }
        public string CalcTienThua(object sender, TextBox txbKhachDua, TextBox txbTongBill)
        {
            TextBox txb = (TextBox)sender;
            string inputText = txb.Text;
            string kq = " ";

            while (!double.TryParse(inputText, out double numericValue) &&txbKhachDua.Text=="")
            {
                MessageBox.Show("Hãy nhập vào 1 số");
                break;

            }
            if (double.TryParse(inputText, out double numericValue1))
            {
                string formattedText = numericValue1.ToString("N0"); // Format as numeric with thousands separators
                txb.Text = formattedText;


                double khachdua = double.Parse(txbKhachDua.Text);
                double tong = double.Parse(txbTongBill.Text);
                double calc;
                if (khachdua < tong)
                {
                    kq = "Không đủ";
                }
                else if (khachdua > tong)
                {
                    calc = khachdua - tong;
                    kq = calc.ToString("N0");
                }
                else
                {
                    kq = "";
                }
            }
            return kq;
        }
    }
}
