using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp.Model
{


    public partial class ModelSanPham : UserControl
    {
        public ModelSanPham()
        {
            InitializeComponent();
        }


        // ham dung 
        public ModelSanPham(string masp , string tensp, float gia , byte[] anh, int soluong)
        {
            this.MaSanPham = masp;
            //this.MaLoaiHang = maloai;
            this.TenSanPham = tensp;
            this.GiaBan = gia;
            this.Anh = anh;
            this.SoLuong = soluong;
        }

        public ModelSanPham(DataRow row)
        {
            this.MaSanPham = row["masanpham"].ToString();
            //this.MaLoaiHang = int.Parse(row["maloaihang"].ToString());
            this.TenSanPham = row["tensanpham"].ToString();
            this.GiaBan = float.Parse(row["giaban"].ToString());

            this.SoLuong = int.Parse(row["soluong"].ToString());
            //Byte[] imagearray = (byte[])row["Anh"];
            //byte[] imagebytearray = imagearray;
            this.Anh = (byte[])row["anh"];
            //this.SoLuong =
        }

        //public GetSoLuong()
        //{

        //}

        public event EventHandler onSelect = null;
        public string MaSanPham { get; set; }

        public string MaLoaiHang { get; set; }

        private float giaBan;

        public float GiaBan
        {
            get { return float.Parse(lbGia.Text); }
            set { lbGia.Text = value.ToString("N0"); }
        }

        //public float GiaBan {
        //    get {return giaBan; }
        //    set { lbGia.Text = value.ToString("N0")  + " VND"; }
        //}

        //public string GiaBanFormatted
        //{
        //    get { return GiaBan.ToString("N0") + " VND"; }
        //    set { }
        //}

        public string DanhSachSanPham { get; set; }

        public int SoLuong 
        {
            get { return int.Parse(lbHienCo.Text); }
            set { lbHienCo.Text = value.ToString(); }
        }    
        public string TenSanPham
        {
            //get; set;
            get { return lbTenSanPham.Text; }
            set { lbTenSanPham.Text = value; }
        }


        public byte[] Anh
        {
        
            get
            {
                // Chuyển hình ảnh thành mảng byte
                if (ptbAnh.Image != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        ptbAnh.Image.Save(memoryStream, ptbAnh.Image.RawFormat);
                        return memoryStream.ToArray();
                    }
                }
                return null; // Trả về null nếu hình ảnh là null
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    try
                    {
                        // Chuyển mảng byte thành hình ảnh và gán cho ptbAnh.Image
                        using (MemoryStream memoryStream = new MemoryStream(value))
                        {
                            ptbAnh.Image = Image.FromStream(memoryStream);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        // Xử lý lỗi nếu mảng byte không hợp lệ
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                }
                else
                {
                    ptbAnh.Image = null; // Gán hình ảnh là null nếu mảng byte là null hoặc rỗng
                }
            }
        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {
          
            onSelect?.Invoke(this, e);

        }
    }
}
