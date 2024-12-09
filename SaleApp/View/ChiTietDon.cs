using SaleApp.Business;
using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp.View
{
    public partial class frmChiTietDon : Form
    {
        private int madm;
        public frmChiTietDon()
        {
            InitializeComponent();
        }
        public frmChiTietDon(string madh)
        {
            this.madm = int.Parse(madh);
            InitializeComponent();
        }
        private void HienThi(int ma)
        {
            DONMUA d = new DONMUA();
            d = DonMuaBUS.Instance.TimTheoMadm(ma);
            lMaDon.Text = d.MaDonMua.ToString();
            lMaNV.Text = d.MaNhanVien;
            lTong.Text = d.TongTien.ToString("N0").Replace(",",".") +" VND";
            lMaKH.Text = d.MaKhachHang;
            lNgayMua.Text = d.NgayTao.ToString("dd/MM/yyyy");
            KHACHHANG k = new KHACHHANG();
            k = KhachHangBUS.Instance.TimTheoMakh(d.MaKhachHang);
            lSdt.Text = k.SoDienThoai;
            lHoTen.Text = k.HoTen;
            DonMuaBUS.Instance.XemChiTietDon(dtgrvHienThiListSPChon,ma);
        }

        private void frmChiTietDon_Load(object sender, EventArgs e)
        {
            HienThi(madm);
        }
    }
}
