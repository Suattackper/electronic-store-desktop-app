using DocumentFormat.OpenXml.Spreadsheet;
using SaleApp.Business;
using SaleApp.DAO;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp.View
{
    public partial class frmXuatKho : Form
    {
        private string sdt="0369787811";
        public frmXuatKho()
        {
            InitializeComponent();
        }
        public frmXuatKho(string sdt)
        {
            this.sdt = sdt;
            InitializeComponent();
        }
        private void reset()
        {
            txtLiDo.Text = "";
            cbSanPham.SelectedIndex = 0;
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtLiDo.Focus();
            dtgvDSSPXuat.Rows.Clear();
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            SanPhamBUS.Instance.getDataSanPham(cbSanPham);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLiDo.Text == "")
            {
                MessageBox.Show("Lý do không được để trống!", "Error");
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
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Đơn giá không được để trống!", "Error");
                return;
            }
            if (!Regex.IsMatch(txtDonGia.Text, @"^\d+(\.\d+)?$") || float.Parse(txtDonGia.Text) <= 0)
            {
                MessageBox.Show("Giá nhập không đúng!", "Error");
                return;
            }
            foreach (DataGridViewRow row in dtgvDSSPXuat.Rows)
            {
                if (row.Cells[1].Value.ToString() == cbSanPham.Text)
                {
                    MessageBox.Show($"Sản phẩm {cbSanPham.Text} đã được thêm!", "Error");
                    return;
                }
            }
            dtgvDSSPXuat.Rows.Add(SanPhamBUS.Instance.getMaSanPham(cbSanPham.Text), cbSanPham.Text, txtSoLuong.Text, txtDonGia.Text);
            cbSanPham.SelectedIndex = 0;
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            cbSanPham.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDSSPXuat.SelectedRows.Count > 0)
            {
                int selectedIndex = dtgvDSSPXuat.SelectedRows[0].Index;
                //Xóa hàng
                dtgvDSSPXuat.Rows.RemoveAt(selectedIndex);
            }
            else if (dtgvDSSPXuat.SelectedCells.Count > 0)
            {
                int rowIndex = dtgvDSSPXuat.SelectedCells[0].RowIndex; // Lấy chỉ số hàng
                if (rowIndex >= 0 && rowIndex < dtgvDSSPXuat.Rows.Count)
                {
                    // Xóa hàng với chỉ số rowIndex
                    dtgvDSSPXuat.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn dòng bạn muốn xóa!", "Error!");
            }
        }

        private void dtgvDSSPXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã bấm vào một ô hợp lệ hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dtgvDSSPXuat.Rows[e.RowIndex];
                // Lấy giá trị từ cột của hàng được chọn và hiển thị nó trong các TextBox
                cbSanPham.Text = selectedRow.Cells[1].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells[2].Value.ToString();
                txtDonGia.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void dtgvDSSPXuat_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dtgvDSSPXuat.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dtgvDSSPXuat.SelectedRows[0];
                // Lấy giá trị từ cột của hàng được chọn và hiển thị nó trong các TextBox
                cbSanPham.Text = selectedRow.Cells[1].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells[2].Value.ToString();
                txtDonGia.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dtgvDSSPXuat.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvDSSPXuat.Rows)
                {
                    CHITIETPHIEUXUAT c = new CHITIETPHIEUXUAT();
                    c.MaSanPham = row.Cells[0].Value.ToString();
                    c.SoLuong = int.Parse(row.Cells[2].Value.ToString());
                    //kiểm tra mã sp đã tồn tại chưa
                    DataTable check = new DataTable();
                    check = KhoDAO.Instance.XemHangTon();
                    foreach (DataRow existingRow in check.Rows)
                    {
                        if (existingRow["MaSanPham"].ToString() == c.MaSanPham && int.Parse(existingRow["SoLuong"].ToString()) < c.SoLuong)
                        {
                            MessageBox.Show($"{existingRow["TenSanPham"]} không có đủ hàng tồn trong kho!", "Error!");
                            return;
                        }
                    }
                }

                PHIEUXUATKHO p = new PHIEUXUATKHO();
                p.LyDo = txtLiDo.Text;
                p.MaNhanVien = NhanVienBUS.Instance.getMaNhanVien(sdt);
                PhieuXuatKhoBUS.Instance.Them(p);
                string sop = PhieuXuatKhoBUS.Instance.getSoPhieuXuatKho();
                foreach (DataGridViewRow row in dtgvDSSPXuat.Rows)
                {
                    CHITIETPHIEUXUAT c = new CHITIETPHIEUXUAT();
                    c.MaSanPham = row.Cells[0].Value.ToString();
                    c.SoLuong = int.Parse(row.Cells[2].Value.ToString());
                    c.SoPhieuXuatKho = int.Parse(sop);
                    c.DonGia = float.Parse(row.Cells[3].Value.ToString());
                    ChiTietPhieuXuatBUS.Instance.Them(c);
                }
                MessageBox.Show("Xuất kho thành công!", "Thông báo");
                reset();
            }
            else
            {
                MessageBox.Show("Vui lòng thêm thông tin sản phẩm vào danh sách!", "Error!");
            }
        }
    }
}
