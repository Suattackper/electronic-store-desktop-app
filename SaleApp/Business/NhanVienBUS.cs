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
    internal class NhanVienBUS
    {
        private static NhanVienBUS instance;

        internal static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
        }
        private NhanVienBUS() { }
        public string getMaNhanVien(string sdt)
        {
            string ma = null;
            DataTable check = NhanVienDAO.Instance.getMaNhanVien(sdt);
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["SoDienThoai"].ToString() == sdt)
                {
                    return existingRow["MaNhanVien"].ToString();
                }
            }
            return ma;
        }
        public void Xem(DataGridView dgv)
        {
            dgv.DataSource = NhanVienDAO.Instance.Xem();
            //Đổi tên cột datafridview
            dgv.Columns[0].HeaderText = "Mã nhân viên";
            dgv.Columns[1].HeaderText = "Tên nhân viên";
            dgv.Columns[2].HeaderText = "Quyền";
            dgv.Columns[3].HeaderText = "CCCD";
            dgv.Columns[4].HeaderText = "SĐT";
            dgv.Columns[5].HeaderText = "Địa chỉ";
            dgv.Columns[6].HeaderText = "Email";
            dgv.Columns[7].HeaderText = "Ngày vào";
        }
        public byte[] getAnh(string masp)
        {
            byte[] image = null;
            DataTable check = NhanVienDAO.Instance.getAnh(masp);
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
        public string Them(NHANVIEN p)
        {
            if (p.MaNhanVien == "")
            {
                return "errorManv";
            }
            if (p.HoTen == "")
            {
                return "errorHoten";
            }
            if (p.MaQuyen == null)
            {
                return "errorMaq";
            }
            if (p.Anh == null)
            {
                return "errorAnh";
            }
            if (p.SoDienThoai == "")
            {
                return "errorSđt";
            }
            if (p.DiaChi == "")
            {
                return "errorDiachi";
            }
            if (p.Email == "")
            {
                return "errorEmail";
            }
            if (p.CCCD == "")
            {
                return "errorCccd";
            }
            if(!Regex.IsMatch(p.Email, @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)*(\.[a-z]{2,7})$", RegexOptions.IgnoreCase))
            {
                return "errorEmail1";
            }
            if(!Regex.IsMatch(p.CCCD, @"^\d+$"))
            {
                return "errorCccd1";
            }
            if (!Regex.IsMatch(p.SoDienThoai, @"^(03|07|08|09|01[2-9])[0-9]{8}$"))
            {
                return "errorSdt1";
            }
            //kiểm tra mã nv,cccd,sdt,email đã tồn tại chưa
            DataTable check = NhanVienDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["MaNhanVien"].ToString() == p.MaNhanVien)
                {
                    return "error1";
                }
                if (existingRow["CCCD"].ToString() == p.CCCD)
                {
                    return "error2";
                }
                if (existingRow["SoDienThoai"].ToString() == p.SoDienThoai)
                {
                    return "error3";
                }
                if (existingRow["Email"].ToString() == p.Email)
                {
                    return "error4";
                }
            }
            NhanVienDAO.Instance.Them(p);
            return "";
        }
        public bool Xoa(DataGridView dgv)
        {
            //lấy dữ liệu cột đầu đang được chọn
            string code = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value + "";
            //kiem tra xem masp có tồn tại trong chi tiet phieu nhap, phieu xuat kho, don mua không
            DataTable check = PhieuNhapKhoDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["MaNhanVien"].ToString() == code)
                {
                    MessageBox.Show("Không thể xóa nhân viên này!", "Thông báo!");
                    return false;
                    break;
                }
            }
            DataTable check1 = PhieuXuatKhoDAO.Instance.Xem();
            foreach (DataRow existingRow in check1.Rows)
            {
                if (existingRow["MaNhanVien"].ToString() == code)
                {
                    MessageBox.Show("Không thể xóa nhân viên này!", "Thông báo!");
                    return false;
                    break;
                }
            }
            DataTable check2 = DonMuaDAO.Instance.Xem();
            foreach (DataRow existingRow in check2.Rows)
            {
                if (existingRow["MaNhanVien"].ToString() == code)
                {
                    MessageBox.Show("Không thể xóa nhân viên này!", "Thông báo!");
                    return false;
                    break;
                }
            }
            return NhanVienDAO.Instance.Xoa(code);
        }
        public string Sua(NHANVIEN p,string sdt,string email,string cccd)
        {
            if (p.MaNhanVien == "")
            {
                return "errorManv";
            }
            if (p.HoTen == "")
            {
                return "errorHoten";
            }
            if (p.MaQuyen == null)
            {
                return "errorMaq";
            }
            if (p.Anh == null)
            {
                return "errorAnh";
            }
            if (p.SoDienThoai == "")
            {
                return "errorSđt";
            }
            if (p.DiaChi == "")
            {
                return "errorDiachi";
            }
            if (p.Email == "")
            {
                return "errorEmail";
            }
            if (p.CCCD == "")
            {
                return "errorCccd";
            }
            if (!Regex.IsMatch(p.Email, @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)*(\.[a-z]{2,7})$", RegexOptions.IgnoreCase))
            {
                return "errorEmail1";
            }
            if (!Regex.IsMatch(p.CCCD, @"^\d+$"))
            {
                return "errorCccd1";
            }
            if (!Regex.IsMatch(p.SoDienThoai, @"^(03|07|08|09|01[2-9])[0-9]{8}$"))
            {
                return "errorSdt1";
            }
            //kiểm tra mã nv,cccd,sdt,email đã tồn tại chưa
            DataTable check = NhanVienDAO.Instance.Xem();
            foreach (DataRow existingRow in check.Rows)
            {
                if (existingRow["CCCD"].ToString() == p.CCCD && existingRow["CCCD"].ToString() != cccd)
                {
                    return "error2";
                }
                if (existingRow["SoDienThoai"].ToString() == p.SoDienThoai && existingRow["SoDienThoai"].ToString() != sdt)
                {
                    return "error3";
                }
                if (existingRow["Email"].ToString() == p.Email && existingRow["Email"].ToString() != email)
                {
                    return "error4";
                }
            }
            NhanVienDAO.Instance.Sua(p);
            return "";
        }
        //public void Tim(DataGridView dgv, string tenncc)
        //{
        //    dgv.DataSource = SanPhamDAO.Instance.Tim(tenncc);
        //    //Đổi tên cột datafridview
        //    dgv.Columns[0].HeaderText = "Mã sản phẩm";
        //    dgv.Columns[1].HeaderText = "Tên sản phẩm";
        //    dgv.Columns[2].HeaderText = "Loại hàng";
        //    dgv.Columns[3].HeaderText = "Giá bán";
        //}
    }
}
