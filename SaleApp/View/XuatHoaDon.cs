using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
//using _Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;


namespace SaleApp.View
{
    public partial class XuatHoaDon : Form
    {
        private string Tong, KhachDua, Thua,MaKH,HoTen,SDT,manv,madonmua,ngaymua;

     


        private DataTable data;

        private void btnXuat_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
           

            //// Khởi động chương trình Excel
            //_Excel.Application exApp = new _Excel.Application();
            //_Excel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            //_Excel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            //_Excel.Range exRange;
            //string sql;
            //int hang = 0, cot = 0;
            ////DataTable tblThongtinHD, tblThongtinHang;
            //exBook = exApp.Workbooks.Add(_Excel.XlWBATemplate.xlWBATWorksheet);
            //exSheet = exBook.Worksheets[1];
            //// Định dạng chung
            //exRange = exSheet.Cells[1, 1];
            //exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            //exRange.Range["A1:B3"].Font.Size = 10;
            //exRange.Range["A1:B3"].Font.Bold = true;
            //exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            //exRange.Range["A1:A1"].ColumnWidth = 7;
            //exRange.Range["B1:B1"].ColumnWidth = 15;
            //exRange.Range["A1:B1"].MergeCells = true;
            //exRange.Range["A1:B1"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignCenter;

            //exRange.Range["C2:E2"].Font.Size = 16;
            //exRange.Range["C2:E2"].Font.Bold = true;
            //exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            //exRange.Range["C2:E2"].MergeCells = true;
            //exRange.Range["C2:E2"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C2:E2"].Value = "HÓA ĐƠN";

            //exRange.Range["B6:C9"].Font.Size = 12;
            //exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            //exRange.Range["C6:E6"].MergeCells = true;
            //exRange.Range["C6:E6"].Value = " ";
            //exRange.Range["B7:B7"].Value = "Mã Nhân Viên:";
            //exRange.Range["C7:E7"].MergeCells = true;
            //exRange.Range["C7:E7"].Value = " ";
            //exRange.Range["B8:B8"].Value = "Tên Khách Hàng:";
            //exRange.Range["C8:E8"].MergeCells = true;
            //exRange.Range["C8:E8"].Value = txtTenKH.Text;
            //exRange.Range["C8:E8"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignRight;
            //exRange.Range["B9:B9"].Value = "Điện thoại:";
            //exRange.Range["C9:E9"].MergeCells = true;
            //exRange.Range["C9:E9"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignRight;
            //exRange.Range["C9:E9"].Value = "(+84) " + txtSDT.Text.ToString();


            //exRange.Range["A11:F11"].Font.Bold = true;
            //exRange.Range["A11:F11"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C11:F11"].ColumnWidth = 17;
            //exRange.Range["A11:A11"].ColumnWidth = 7;
            //exRange.Range["A11:B11"].ColumnWidth = 18;
            //exRange.Range["A11:A11"].Value = "STT";
            //exRange.Range["B11:B11"].Value = "Mã hàng";
            //exRange.Range["C11:C11"].Value = "Tên Hàng";
            //exRange.Range["D11:D11"].Value = "Số Lượng";
            //exRange.Range["E11:E11"].Value = "Đơn Giá";
            //exRange.Range["F11:F11"].Value = "Thành tiền";
            //for (hang = 0; hang < data.Rows.Count; hang++)
            //{
            //    //Điền số thứ tự vào cột 1 từ dòng 12
            //    exSheet.Cells[1][hang + 12] = hang + 1;
            //    for (cot = 0; cot < data.Columns.Count; cot++)
            //    //Điền thông tin hàng từ cột thứ 2, dòng 12
            //    {
            //        exSheet.Cells[cot + 2][hang + 12] = data.Rows[hang][cot].ToString();
            //        //if ( cot==4 || cot ==5) exSheet.Cells[cot + 2][hang + 12] = data.Rows[hang][cot].ToString();
            //    }
            //}
            //// tong
            //exRange = exSheet.Cells[cot + 0][hang + 14];
            //exRange.Font.Bold = true;
            //exRange.Value2 = "Tổng tiền ";

            //exRange = exSheet.Cells[cot + 1][hang + 14];
            //exRange.Font.Bold = true;
            //exRange.Value2 = txbTongHoaDon.Text;
            //// khach tra
            //exRange = exSheet.Cells[cot + 0][hang + 15];
            //exRange.Font.Bold = true;
            //exRange.Font.Italic = true;
            //exRange.Value2 = "Khách Trả";
            //exRange = exSheet.Cells[cot + 1][hang + 16]; //Ô A1 
            //exRange.Font.Bold = true;
            //exRange.Font.Size = 9;
            //exRange.Value2 = txbKhachTra.Text;

            //// tien thua
            //exRange = exSheet.Cells[cot + 0][hang + 16];
            //exRange.Font.Bold = true;
            //exRange.Font.Italic = true;

            //exRange.Value2 = "Tiền Thừa";
            //exRange = exSheet.Cells[cot + 1][hang + 15]; //Ô A1 
            //exRange.Font.Bold = true;

            //exRange.Value2 = txbTienThua.Text;


            ////exRange.Range["A1:F1"].MergeCells = true;
            ////exRange.Range["A1:F1"].Font.Bold = true;
            ////exRange.Range["A1:F1"].Font.Italic = true;
            ////exRange.Range["A1:F1"].Value = txbKhachTra.Text;
            ////exRange.Range["A1:F1"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignRight;
            ////exRange.Range["A2:F2"].MergeCells = true;
            ////exRange.Range["A2:F2"].Font.Bold = true;
            ////exRange.Range["A2:F2"].Font.Italic = true;
            ////exRange.Range["A2:F2"].Font.Size = 9;
            ////exRange.Range["A2:F2"].Value = txbKhachTra.Text;
            ////exRange.Range["A2:F2"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignRight;
            ////exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(data.Rows[0][2].ToString());
            //exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            //exRange.Range["A1:C1"].MergeCells = true;
            //exRange.Range["A1:C1"].Font.Italic = true;
            //exRange.Range["A1:C1"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignCenter;
            //////DateTime d = Convert.ToDateTime(data.Rows[1][0]).ToString();
            //////exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            //exRange.Range["A2:C2"].MergeCells = true;
            //exRange.Range["A2:C2"].Font.Italic = true;
            //exRange.Range["A2:C2"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            //exRange.Range["A6:C6"].MergeCells = true;
            //exRange.Range["A6:C6"].Font.Italic = true;
            //exRange.Range["A6:C6"].HorizontalAlignment = _Excel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A6:C6"].Value = " ";// tên nhân viên
            //exSheet.Name = "Hóa đơn nhập";
            ////exApp.Visible = true;
        }

        //private DataTable data = new DataTable();
        public XuatHoaDon()
        {
            InitializeComponent();
           
        }
        private void btnInDon_Click(object sender, EventArgs e)
        {
           
                
        }
        //string TongHoaDon, string TienKhachDua, string TienThua,
        public XuatHoaDon( string TongHoaDon , string TienThua, String TienKhachDua ,string makh, string hoten, string sdt, DataTable da,string manv,string madonmua,string ngaymua)
        {
            InitializeComponent();
            this.Tong = TongHoaDon;
            this.Thua = TienThua;
            this.KhachDua = TienKhachDua;
            this.MaKH = makh;
            this.HoTen = hoten;
            this.SDT = sdt;
            this.manv = manv;
            this.madonmua = madonmua;
            this.ngaymua = ngaymua;
            data = da;
        
        }
        private void XuatHoaDon_Load(object sender, EventArgs e)
        {
            txbTongHoaDon.Text = Tong;
            txbKhachTra.Text = KhachDua;
            txbTienThua.Text = Thua;
            txtMaKH.Text = MaKH;
            txtTenKH.Text = HoTen;
            txtSDT.Text = SDT;
            txtMaNV.Text = manv;
            txtMaD.Text = madonmua;
            txtNgayMua.Text = ngaymua;
            dataGridView2.DataSource = data;
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        

    }
}
