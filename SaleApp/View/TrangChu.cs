using SaleApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SaleApp.View
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            lblTongDoanhThu.Text = KetNoiSql.Instance.getTongDoanhThu().ToString("N0").Replace(",", ".") + " VND";
            //lblTongDoanhThu.Text = KetNoiSql.Instance.getTongDoanhThu() + " VND";
            lblTongSPDaBan.Text = KetNoiSql.Instance.getTongSanPham() + " SP";
            lblTongKH.Text = KetNoiSql.Instance.getTongKhachHang() + " Người";
        }
    }
}
