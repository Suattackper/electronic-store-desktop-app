using DocumentFormat.OpenXml.Vml;
using OfficeOpenXml;
using SaleApp.Business;
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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace SaleApp.View
{
    public partial class frmNhapSP : Form
    {
        public frmNhapSP()
        {
            InitializeComponent();
        }

        private void reset()
        {
            txtMaSP.Text = "";
            txtGiaBan.Text = "";
            txtTenSP.Text = "";
            txtMaSP.Focus();
            pbHinhAnh.Image = null;
            cbLoaiSP.SelectedIndex = 0;
            SanPhamBUS.Instance.Xem(dtgvDSSP);
        }
        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                //tạo một workbook Excel mới
                using (var package = new ExcelPackage())
                {
                    //tạo trang tinh sheet1 và gán chp workbook
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                    // Ghi dữ liệu từ DataGridView vào Excel worksheet
                    for (int i = 1; i <= dataGridView.Columns.Count; i++)
                    {
                        // Ghi tiêu đề cột
                        worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                        worksheet.Cells[1, i].Style.Font.Bold = true;
                        // Đặt độ rộng cột bằng chiều dài của tiêu đề cột
                        worksheet.Column(i).AutoFit();
                    }
                    //Ghi dữ liệu vào woekbook từ datagridview
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            if (dataGridView[j, i].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGridView[j, i].Value.ToString();
                            }
                        }
                    }

                    // Lưu workbook ra tệp Excel
                    package.SaveAs(new FileInfo(filePath));

                    MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmNhapSP_Load(object sender, EventArgs e)
        {
            LoaiHangBUS.Instance.getDataLoaiHang(cbLoaiSP);
            SanPhamBUS.Instance.Xem(dtgvDSSP);
        }

        private void dtgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã bấm vào một ô hợp lệ hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dtgvDSSP.Rows[e.RowIndex];
                // Lấy giá trị từ cột của hàng được chọn và hiển thị nó trong các TextBox
                txtMaSP.Text = selectedRow.Cells[0].Value.ToString();
                txtTenSP.Text = selectedRow.Cells[1].Value.ToString();
                cbLoaiSP.Text = selectedRow.Cells[2].Value.ToString();
                //txtGiaBan.Text = decimal.Parse(selectedRow.Cells[3].Value.ToString()).ToString("N0") + " VND";
                txtGiaBan.Text = selectedRow.Cells[3].Value.ToString();
                txtMoTa.Text = selectedRow.Cells[4].Value.ToString();
                byte[] imageData = SanPhamBUS.Instance.getAnh(selectedRow.Cells[0].Value.ToString());
                if (imageData != null)
                {
                    //Chỉnh ảnh phù hợp với pbHinhAnh
                    pbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    // Đặt hình ảnh cho PictureBox
                    pbHinhAnh.Image = Image.FromStream(new MemoryStream(imageData));

                }
                else pbHinhAnh.Image = null;
            }
        }

        private void dtgvDSSP_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dtgvDSSP.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dtgvDSSP.SelectedRows[0];
                // Lấy giá trị từ cột của hàng được chọn và hiển thị nó trong các TextBox
                txtMaSP.Text = selectedRow.Cells[0].Value.ToString();
                txtTenSP.Text = selectedRow.Cells[1].Value.ToString();
                cbLoaiSP.Text = selectedRow.Cells[2].Value.ToString();
                txtGiaBan.Text = selectedRow.Cells[3].Value.ToString();
                txtMoTa.Text = selectedRow.Cells[4].Value.ToString();
                byte[] imageData = SanPhamBUS.Instance.getAnh(selectedRow.Cells[0].Value.ToString());
                if (imageData != null)
                {
                    //Chỉnh ảnh phù hợp với pbHinhAnh
                    pbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    // Đặt hình ảnh cho PictureBox
                    pbHinhAnh.Image = Image.FromStream(new MemoryStream(imageData));
                }
                else pbHinhAnh.Image = null;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtGiaBan.Text, @"^\d+(\.\d+)?$"))
            {
                MessageBox.Show("Giá bán không hợp lệ!", "Error");
                return;
            }
            SANPHAM sp = new SANPHAM();
            sp.MaSanPham = txtMaSP.Text;
            sp.TenSanPham = txtTenSP.Text;
            sp.MaLoaiHang = LoaiHangBUS.Instance.getMaLoaiHang(cbLoaiSP.Text);
            sp.GiaBan = float.Parse(txtGiaBan.Text);
            sp.MoTa = txtMoTa.Text;
            byte[] anh = null;
            //Chuyển ảnh thành mảng byte
            using (MemoryStream memoryStream = new MemoryStream())
            {
                if (pbHinhAnh.Image == null)
                {
                    MessageBox.Show("Ảnh không được để trống!", "Error");
                    return;
                }
                else
                {
                    pbHinhAnh.Image.Save(memoryStream, pbHinhAnh.Image.RawFormat);
                    anh = memoryStream.ToArray();
                }
            }
            sp.Anh = anh;
            string check = SanPhamBUS.Instance.Them(sp);
            switch (check)
            {
                case "errorTen":
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Error");
                    return;
                case "errorMa":
                    MessageBox.Show("Mã sản phẩm không được để trống!", "Error");
                    return;
                case "errorMal":
                    MessageBox.Show("Loại hàng không được để trống!", "Error");
                    return;
                case "errorAnh":
                    MessageBox.Show("Ảnh không được để trống!", "Error");
                    return;
                case "errorMot":
                    MessageBox.Show("Mô tả không được để trống!", "Error");
                    return;
                case "errorGia":
                    MessageBox.Show("Giá bán không được để trống!", "Error");
                    return;
                case "errorGia2":
                    MessageBox.Show("Giá bán không hợp lệ!", "Error");
                    return;
                case "errorGia1":
                    MessageBox.Show("Giá bán phải lớn hơn 0!", "Error");
                    return;
                case "error1":
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Error");
                    return;
            }

            MessageBox.Show("Thêm thành công!", "Thông báo");
            reset();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //Đặt tiêu đề cho hộp thoại openFileDialog
                openFileDialog.Title = "Chọn ảnh";
                //Đặt bộ lọc cho các tệp ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn đến tệp đã chọn
                    string selectedImagePath = openFileDialog.FileName;
                    //Chỉnh ảnh phù hợp với pbHinhAnh
                    pbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    //Hiển thị ảnh
                    pbHinhAnh.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (SanPhamBUS.Instance.Xoa(dtgvDSSP))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                SanPhamBUS.Instance.Xem(dtgvDSSP);
            }

            else MessageBox.Show("Xóa không thành công", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txtGiaBan.Text, @"^\d+(\.\d+)?$")){
                MessageBox.Show("Giá bán không hợp lệ!", "Error");
                return;
            }
            SANPHAM sp = new SANPHAM();
            sp.MaSanPham = txtMaSP.Text;
            sp.TenSanPham = txtTenSP.Text;
            sp.MaLoaiHang = LoaiHangBUS.Instance.getMaLoaiHang(cbLoaiSP.Text);
            sp.GiaBan = float.Parse(txtGiaBan.Text);
            sp.MoTa = txtMoTa.Text;
            byte[] anh = null;
            //Chuyển ảnh thành mảng byte
            using (MemoryStream memoryStream = new MemoryStream())
            {
                if (pbHinhAnh.Image == null)
                {
                    MessageBox.Show("Ảnh không được để trống!", "Error");
                    return;
                }
                else
                {
                    pbHinhAnh.Image.Save(memoryStream, pbHinhAnh.Image.RawFormat);
                    anh = memoryStream.ToArray();
                }
            }
            sp.Anh = anh;
            // Lấy hàng hiện tại (current row)
            int rowIndex = dtgvDSSP.CurrentCell.RowIndex;
            // Lấy giá trị từ ô hiện tại
            string macuahang = dtgvDSSP.Rows[rowIndex].Cells[0].Value.ToString();
            if (macuahang != txtMaSP.Text)
            {
                MessageBox.Show("Mã sản phẩm không được thay đổi!", "Error");
                return;
            }
            string check = SanPhamBUS.Instance.Sua(sp);
            switch (check)
            {
                case "errorTen":
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Error");
                    return;
                case "errorMa":
                    MessageBox.Show("Mã sản phẩm không được để trống!", "Error");
                    return;
                case "errorMal":
                    MessageBox.Show("Loại hàng không được để trống!", "Error");
                    return;
                case "errorAnh":
                    MessageBox.Show("Ảnh không được để trống!", "Error");
                    return;
                case "errorMot":
                    MessageBox.Show("Mô tả không được để trống!", "Error");
                    return;
                case "errorGia":
                    MessageBox.Show("Giá bán không được để trống!", "Error");
                    return;
                case "errorGia2":
                    MessageBox.Show("Giá bán không hợp lệ!", "Error");
                    return;
                case "errorGia1":
                    MessageBox.Show("Giá bán phải lớn hơn 0!", "Error");
                    return;
                case "error1":
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Error");
                    return;
            }
            MessageBox.Show("Sửa thành công!", "Thông báo");
            reset();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SanPhamBUS.Instance.Tim(dtgvDSSP, txtTimKiem.Text);
        }

        private void btnLưu_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";
                //hiển thị hộp thoại lưu cho người dùng
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Chọn vị trí lưu tệp Excel
                    string filePath = saveFileDialog.FileName;

                    // Viết dữ liệu vào tệp Excel
                    ExportToExcel(dtgvDSSP, filePath);
                }
            }
        }
    }
}
