using OfficeOpenXml;
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
    public partial class frmThongKe : Form
    {
        private string madh;
        public frmThongKe()
        {
            InitializeComponent();
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

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DonMuaBUS.Instance.ThongKe(dtgvDSDonHang);
            cbThang.SelectedIndex = 0;
            laTong.Text = KetNoiSql.Instance.getTongDoanhThu().ToString("N0").Replace(",", ".") + " VND";
            laTongkh.Text = KetNoiSql.Instance.getTongKhachHang() + " Người";
            laTongDon.Text = KetNoiSql.Instance.getTongDonMua() + " Đơn";
            laTongsp.Text = KetNoiSql.Instance.getTongSanPham() + " SP";
        }
        
        private void btnrefresh_Click(object sender, EventArgs e)
        {

            DonMuaBUS.Instance.ThongKe(dtgvDSDonHang);
            cbThang.SelectedIndex = 0;
            laTong.Text = KetNoiSql.Instance.getTongDoanhThu().ToString("N0").Replace(",", ".") + " VND";
            laTongkh.Text = KetNoiSql.Instance.getTongKhachHang() + " Người";
            laTongDon.Text = KetNoiSql.Instance.getTongDonMua() + " Đơn";
            laTongsp.Text = KetNoiSql.Instance.getTongSanPham() + " SP";
            txtNam.Text = "";
            txtNam.Focus();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
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
                    ExportToExcel(dtgvDSDonHang, filePath);
                }
            }
        }

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    DonMuaBUS.Instance.Tim(dtgvDSDonHang, txtTimKiem.Text);
        //}

        private void dtgvDSDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã bấm vào một ô hợp lệ hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dtgvDSDonHang.Rows[e.RowIndex];
                // Kiểm tra xem có đủ số cột không
                if (selectedRow.Cells.Count > 1)
                {
                    btnXemCTDH.Visible = true;
                    // Lấy dữ liệu của cột thứ 1
                    madh = selectedRow.Cells[0].Value.ToString();
                }
            }
        }

        private void btnXemCTDH_Click(object sender, EventArgs e)
        {
            frmChiTietDon a = new frmChiTietDon(madh);
            a.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtNam.Text == "")
            {
                MessageBox.Show("Năm không được để trống!", "Error");
                return;
            }
            int currentYear = DateTime.Now.Year;
            if (!Regex.IsMatch(txtNam.Text, @"^\d+(\.\d+)?$") || int.Parse(txtNam.Text)>currentYear)
            {
                MessageBox.Show("Năm phải nhỏ hơn hoặc bằng năm hiện tại!", "Error");
                return;
            }
            if (cbThang.Text == "All")
            {
                DonMuaBUS.Instance.ThongKeTheoNam(dtgvDSDonHang,int.Parse(txtNam.Text));
                laTong.Text = KetNoiSql.Instance.getTongDoanhThuTheoNam(int.Parse(txtNam.Text)).ToString("N0").Replace(",", ".") + " VND";
                laTongkh.Text = KetNoiSql.Instance.getTongKhachHangTheoNam(int.Parse(txtNam.Text)) + " Người";
                laTongDon.Text = KetNoiSql.Instance.getTongDonMuaTheoNam(int.Parse(txtNam.Text)) + " Đơn";
                laTongsp.Text = KetNoiSql.Instance.getTongSanPhamTheoNam(int.Parse(txtNam.Text)) + " SP";
                cbThang.SelectedIndex = 0;
                txtNam.Text = "";
                txtNam.Focus();
            }
            else
            {
                DonMuaBUS.Instance.ThongKeTheoNamThang(dtgvDSDonHang, int.Parse(txtNam.Text), int.Parse(cbThang.Text));
                laTong.Text = KetNoiSql.Instance.getTongDoanhThuTheoNamThang(int.Parse(txtNam.Text), int.Parse(cbThang.Text)).ToString("N0") + " VND";
                laTongkh.Text = KetNoiSql.Instance.getTongKhachHangTheoNamThang(int.Parse(txtNam.Text), int.Parse(cbThang.Text)) + " Người";
                laTongDon.Text = KetNoiSql.Instance.getTongDonMuaTheoNamThang(int.Parse(txtNam.Text), int.Parse(cbThang.Text)) + " Đơn";
                laTongsp.Text = KetNoiSql.Instance.getTongSanPhamTheoNamThang(int.Parse(txtNam.Text), int.Parse(cbThang.Text)) + " SP";
                cbThang.SelectedIndex = 0;
                txtNam.Text = "";
                txtNam.Focus();
            }
        }
    }
}
