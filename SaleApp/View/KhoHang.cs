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
    public partial class frmKhoHang : Form
    {
        private string sdt;
        public frmKhoHang()
        {
            InitializeComponent();
            LoadForm();
        }
        public frmKhoHang(string sdt)
        {
            this.sdt = sdt;
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            // Tạo các Form con
            frmHangTon form1 = new frmHangTon();
            frmNhapHang form2 = new frmNhapHang(sdt);
            frmXuatKho form3 = new frmXuatKho(sdt);

            // Gắn Form cha cho các Form con
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;

            form3.TopLevel = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;

            // Thêm Form con vào các TabPages
            tHangTon.Controls.Add(form1);
            tNhapKho.Controls.Add(form2);
            tXuatKho.Controls.Add(form3);

            //Hirn thị form
            form1.Show();
            form2.Show();
            form3.Show();
        }
    }
}
