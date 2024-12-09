using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Model
{
    internal class HinhAnh
    {
        private string tenhinhanh;
        private byte[] anh;

        public HinhAnh()
        {
        }

        public HinhAnh(string tenhinhanh, byte[] anh)
        {
            this.tenhinhanh = tenhinhanh;
            Anh = anh;
        }


        public string Tenhinhanh { get => tenhinhanh; set => tenhinhanh = value; }
        public byte[] Anh { get => anh; set => anh = value; }
    }
}
