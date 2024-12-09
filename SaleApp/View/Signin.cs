using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleApp.DAO;
using SaleApp.Business;
using SaleApp.Model;

namespace SaleApp.View
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            QuyenBUS.Instance.getDataQuyen(cbRole);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Tạo và set giá trị cho TAIKHOAN
            TAIKHOAN tk = new TAIKHOAN();
            tk.MatKhau = txtPassword.Text;
            tk.SoDienThoai = txtUsername.Text;
            tk.MaQuyen = cbRole.SelectedIndex + 1;
            //Kiểm tra tài khoản có hợp lệ
            string check = TaiKhoanBUS.Instance.checkLogin(tk);
            switch (check)
            {
                case "errorTaikhoan":
                    MessageBox.Show("Tài khoản không được để trống!", "Error");
                    return;
                case "errorMatkhau":
                    MessageBox.Show("Mật khẩu không được để trống!", "Error");
                    return;
                case "error":
                    MessageBox.Show("Thông tin đăng nhập không chính xác!", "Error");
                    return;
            }
            MessageBox.Show(cbRole.Text + " đăng nhập thành công!", "Success");
            //Chuyển sang form Home
            frmHome2 dashboard = new frmHome2(cbRole.Text,txtUsername.Text);
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
