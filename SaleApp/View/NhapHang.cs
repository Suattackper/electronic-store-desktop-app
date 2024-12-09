using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using SaleApp.Business;
using SaleApp.Model;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SaleApp.View
{
    public partial class frmNhapHang : Form
    {
        private string sdt;
        public frmNhapHang()
        {
            InitializeComponent();
        }
        public frmNhapHang(string sdt)
        {
            this.sdt = sdt;
            InitializeComponent();
        }
        private void reset()
        {
            cbNhaCungCap.SelectedIndex = 0;
            cbSanPham.SelectedIndex = 0;
            txtTamUng.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            cbNhaCungCap.Focus();
            cbNhaCungCap.Enabled = true;
            txtTamUng.Enabled = true;
            dtgvDSSPNhap.Rows.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            NhaCungCapBUS.Instance.getDataNhaCungCap(cbNhaCungCap);
            SanPhamBUS.Instance.getDataSanPham(cbSanPham);
            
        }

        private void txtTamUng_TextChanged(object sender, EventArgs e)
        {
            if (txtTamUng.Text != "")
            {
                if (!Regex.IsMatch(txtTamUng.Text, @"^\d+(\.\d+)?$"))
                {
                    txtTamUng.Text = "";
                    MessageBox.Show("Tạm ứng phải là số lớn hơn 0!", "Error!");
                }
                else if (int.Parse(txtTamUng.Text) > 0)
                {
                    dtpNgayThanhToan.Enabled = true;
                }
                else
                {
                    dtpNgayThanhToan.Enabled = false;
                }
            }
            else
            {
                dtpNgayThanhToan.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTamUng.Text == "")
            {
                MessageBox.Show("Tạm ứng không được để trống!", "Error");
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống!", "Error");
                return;
            }
            if (txtGiaNhap.Text == "")
            {
                MessageBox.Show("Giá nhập không được để trống!", "Error");
                return;
            }
            if (!Regex.IsMatch(txtGiaNhap.Text, @"^\d+(\.\d+)?$") || float.Parse(txtGiaNhap.Text) <= 0)
            {
                MessageBox.Show("Giá nhập không đúng!", "Error");
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống!", "Error");
                return;
            }
            if (!Regex.IsMatch(txtSoLuong.Text, @"^\d+$") || int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng không đúng!", "Error");
                return;
            }
            foreach (DataGridViewRow row in dtgvDSSPNhap.Rows)
            {
                if (row.Cells[1].Value.ToString() == cbSanPham.Text && row.Cells[5].Value.ToString() == cbNhaCungCap.Text)
                {
                    MessageBox.Show($"Sản phẩm {cbSanPham.Text} đã được nhập từ {cbNhaCungCap.Text}!", "Error");
                    return;
                }
            }
            dtgvDSSPNhap.Rows.Add(SanPhamBUS.Instance.getMaSanPham(cbSanPham.Text),cbSanPham.Text,txtSoLuong.Text,txtGiaNhap.Text,cbNhaCungCap.Text);
            cbSanPham.SelectedIndex = 0;
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            cbSanPham.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDSSPNhap.SelectedRows.Count > 0)
            {
                int selectedIndex = dtgvDSSPNhap.SelectedRows[0].Index;
                //Xóa hàng
                dtgvDSSPNhap.Rows.RemoveAt(selectedIndex);
            }
            else if (dtgvDSSPNhap.SelectedCells.Count > 0)
            {
                int rowIndex = dtgvDSSPNhap.SelectedCells[0].RowIndex; // Lấy chỉ số hàng
                if (rowIndex >= 0 && rowIndex < dtgvDSSPNhap.Rows.Count)
                {
                    // Xóa hàng với chỉ số rowIndex
                    dtgvDSSPNhap.Rows.RemoveAt(rowIndex);
                }
            }
            else 
            {
                MessageBox.Show("Hãy chọn dòng bạn muốn xóa!", "Error!");
            }
        }

        private void dtgvDSSPNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã bấm vào một ô hợp lệ hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dtgvDSSPNhap.Rows[e.RowIndex];
                // Lấy giá trị từ cột của hàng được chọn và hiển thị nó trong các TextBox
                cbSanPham.Text = selectedRow.Cells[1].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells[2].Value.ToString();
                txtGiaNhap.Text = selectedRow.Cells[3].Value.ToString();
                cbNhaCungCap.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void dtgvDSSPNhap_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dtgvDSSPNhap.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dtgvDSSPNhap.SelectedRows[0];
                // Lấy giá trị từ cột của hàng được chọn và hiển thị nó trong các TextBox
                cbSanPham.Text = selectedRow.Cells[1].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells[2].Value.ToString();
                txtGiaNhap.Text = selectedRow.Cells[3].Value.ToString();
                cbNhaCungCap.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (dtgvDSSPNhap.Rows.Count > 0)
            {
                if (float.Parse(txtTamUng.Text) != 0)
                {
                    float tamung = 0;
                    foreach (DataGridViewRow row in dtgvDSSPNhap.Rows)
                    {
                        tamung += float.Parse(row.Cells[3].Value.ToString())*int.Parse(row.Cells[2].Value.ToString());
                    }
                    if (float.Parse(txtTamUng.Text) != tamung)
                    {
                        MessageBox.Show("Tạm ứng phải bằng tổng tiền hàng nhập hoặc bằng 0!", "Thông báo");
                        return;
                    }
                }
                PHIEUNHAPKHO p = new PHIEUNHAPKHO();
                p.MaNhaCungCap = NhaCungCapBUS.Instance.getMaNhaCungCap(cbNhaCungCap.Text);
                p.TamUng = float.Parse(txtTamUng.Text);
                p.NgayThanhToan = dtpNgayThanhToan.Value;
                p.MaNhanVien = NhanVienBUS.Instance.getMaNhanVien(sdt);
                PhieuNhapKhoBUS.Instance.Them(p);
                string sop = PhieuNhapKhoBUS.Instance.getSoPhieuNhapKho();
                foreach (DataGridViewRow row in dtgvDSSPNhap.Rows)
                {
                    CHITIETPHIEUNHAP c = new CHITIETPHIEUNHAP();
                    c.MaSanPham = row.Cells[0].Value.ToString();
                    c.SoLuongNhap = int.Parse(row.Cells[2].Value.ToString());
                    c.SoPhieuNhapKho = int.Parse(sop);
                    c.GiaNhap = float.Parse(row.Cells[3].Value.ToString());
                    ChiTietPhieuNhapBUS.Instance.Them(c);
                }
                MessageBox.Show("Nhập kho thành công!", "Thông báo");
                reset();
            }
            else
            {
                MessageBox.Show("Vui lòng thêm thông tin sản phẩm vào danh sách!", "Error!");
            }
        }
    }
}
