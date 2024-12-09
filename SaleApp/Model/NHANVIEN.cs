using System;
using System.Collections.Generic;

namespace SaleApp.Model
{

    internal class NHANVIEN
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string NgayVao { get; set; }
        public byte[] Anh { get; set; }
        public int MaQuyen { get; set; }
    }
}
