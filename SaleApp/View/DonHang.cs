using SaleApp.Business;
using SaleApp.DAO;
using SaleApp.Model;
using SaleApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp
{
  
    public partial class frmDonHang : Form
    {
        private string sdt;
        DataTable dt = new DataTable();
        public frmDonHang()
        {
            InitializeComponent();
            LoadSanPham();
            //LoadData();
        }
        public frmDonHang(string sdt)
        {
            this.sdt = sdt;
            InitializeComponent();
            LoadSanPham();
            //LoadData();
        }

        #region Events



        //void loadNhanVien()
        //{
        //    List<ModelSanPham> listmodel = DanhSachSPDAO.Instance.loadDanhSachSP();
        //    foreach (ModelSanPham item in listmodel)
        //    {
        //        ModelSanPham model = new ModelSanPham();
        //        flpDanhSachSanPham.Controls.Add(model);
        //    }
        //}

        void InsertInforKhachHang()
        {
            string sql = "insert into KHACHHANG (makhachhang,hoten,sodienthoai) values ( @makh, @hoten, @sodienthoai ) ";

            KHACHHANG kh = new KHACHHANG();
            kh.MaKhachHang = txbMaKH.Text.Trim();
            kh.HoTen = txtHoTen.Text.Trim();
            kh.SoDienThoai = txtSDT.Text.Trim();
            Object[] p = new object[] { kh.MaKhachHang, kh.HoTen, kh.SoDienThoai };
            DataProvider.Instance.execNonSql(sql, p);
        }
        void LoadSanPham()
        {
            string query = "select s.masanpham,s.tensanpham,l.tenloaihang,k.soluong,s.giaban, s.anh \r\nfrom sanpham s \r\ninner join loaihang l on l.maloaihang=s.maloaihang\r\ninner join kho k on k.masanpham=s.masanpham where k.soluong>0";
           
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                byte[] imagearray = SanPhamBUS.Instance.getAnh(item["MaSanPham"].ToString());
           
                AddSanPham(item["MaSanPham"].ToString(), item["TenLoaiHang"].ToString(), item["TenSanPham"].ToString(), float.Parse(item["GiaBan"].ToString()), imagearray, int.Parse(item["SoLuong"].ToString()));
                
            }
            
        }

        void AddSanPham(string MaSP, string tenloai, string TenSP, float GiaSP, byte[] AnhSP,int sl)
        {
            bool productExists = false;
            var S = new ModelSanPham()
            {

                TenSanPham = TenSP,
                MaLoaiHang = LoaiHangBUS.Instance.getMaLoaiHang(tenloai),
                GiaBan = GiaSP,
                Anh = AnhSP,
                MaSanPham = MaSP,
                SoLuong = sl
            };
            flpDanhSachSanPham.Controls.Add(S);


            SanPhamBUS.Instance.ActionModelSanPham(S,dataGridView1,txbTongBill,dt);
         
        }
        #endregion


        
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            flpDanhSachSanPham.Controls.Clear();
            LoadSanPham();
        }
        private void txbKhachDua_TextChanged(object sender, EventArgs e)
        {
            // tính tiền thừa
            txbTienThua.Text = SanPhamBUS.Instance.CalcTienThua(sender, txbKhachDua, txbTongBill);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // tim kiem
            int flag = 0;
            foreach (var item in flpDanhSachSanPham.Controls)
            {                var pro = (ModelSanPham)item;
                pro.Visible = pro.TenSanPham.ToLower().Contains(txtTimKiem.Text.Trim().ToLower());
                flag++;
                if (flag == 0)
                {
                    Label lb = new Label();
                    lb.Text = "Sản phầm không tồn tại";
                    flpDanhSachSanPham.Controls.Add(lb);
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các sản phẩm hiện tại
            flpDanhSachSanPham.Controls.Clear();
            LoadSanPham();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SanPhamBUS.Instance.ActionWithDVG(dataGridView1, e);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //txbKhachDua.Enabled = true;
            SanPhamBUS.Instance.CalcTongTien(dataGridView1,e);
            SanPhamBUS.Instance.GetTongBill(txbTongBill, dataGridView1);
        }

       
        private void btnInDon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (txtHoTen.Text == "" || txtSDT.Text == "" || txbMaKH.Text == "" || txbKhachDua.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                    return;
                }
                //@"^(03|07|08|09|01[2-9])[0-9]{8}$" Kiểm tra 1 chuỗi có phải là số điện thoại @"^\d+$"
                if (!Regex.IsMatch(txtSDT.Text, @"^(03|07|08|09|01[2-9])[0-9]{8}$"))
                {
                    MessageBox.Show("Số điện thoại không đúng");
                    return;
                }
                InsertInforKhachHang();
                string sql = "insert into DONMUA (makhachhang,manhanvien,tongtien) values ( @makh, @manv, @tong ) ";
                Object[] p = new object[] { txbMaKH.Text, NhanVienBUS.Instance.getMaNhanVien(sdt), decimal.Parse(txbTongBill.Text) };
                DataProvider.Instance.execNonSql(sql, p);

                string madm = DonMuaBUS.Instance.getMaDonMua();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    CHITIETDONMUA c = new CHITIETDONMUA();
                    c.MaDonMua = int.Parse(madm);
                    c.MaSanPham = row.Cells[0].Value.ToString();
                    c.SoLuong = int.Parse(row.Cells[2].Value.ToString());
                    c.DonGia = decimal.Parse(row.Cells[3].Value.ToString());
                    ChiTietDonMuaBUS.Instance.Them(c);
                }
                SanPhamBUS.Instance.LoadData(dt, dataGridView1);
                XuatHoaDon a = new XuatHoaDon(txbTongBill.Text, txbKhachDua.Text, txbTienThua.Text, txbMaKH.Text, txtHoTen.Text, txtSDT.Text, dt, NhanVienBUS.Instance.getMaNhanVien(sdt), madm, DateTime.Now.ToString());
                a.ShowDialog();
                dataGridView1.Rows.Clear();
                txbTienThua.Text = "";
                txbTongBill.Text = "0";
                txbKhachDua.Text = " ";
                txtHoTen.Text = "";
                txtSDT.Text = "";
                txbMaKH.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào danh sách!", "Error!");
            }

            
        }

        private void txbTongBill_TextChanged(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if(txb.Text != "0")
            {
                txbKhachDua.Enabled = true;
            }
            else
            {
                txbKhachDua.Enabled = false;
            }
        }
    }
}
