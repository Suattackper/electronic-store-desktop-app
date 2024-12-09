using SaleApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.DAO
{
    internal class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        internal static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                return instance;
            }
        }
        private NhaCungCapDAO() { }

        public DataTable Xem()
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            return KetNoiSql.Instance.execSql(sql);
        }
        public bool Them(NHACUNGCAP p)
        {
            string sql = "INSERT INTO NHACUNGCAP VALUES( @mancc, @tenncc, @sodienthoai, @diachi )";
            Object[] prms = new object[] { p.MaNhaCungCap, p.TenNhaCungCap, p.SoDienThoai, p.DiaChi };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool Xoa(string pCode)
        {
            string sql = "DELETE NHACUNGCAP WHERE MaNhaCungCap = @mancc";
            Object[] prms = new object[] { pCode };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public bool Sua(NHACUNGCAP ncc)
        {
            string sql = "UPDATE NHACUNGCAP SET TenNhaCungCap = @tenncc, SoDienThoai = @sdt, DiaChi = @diachi WHERE MaNhaCungCap = @mancc";
            Object[] prms = new object[] { ncc.TenNhaCungCap, ncc.SoDienThoai, ncc.DiaChi, ncc.MaNhaCungCap };
            return KetNoiSql.Instance.execNonSql(sql, prms) > 0;
        }
        public DataTable Tim(string name)
        {
            string sql = " SELECT * FROM NHACUNGCAP WHERE TenNhaCungCap LIKE @keyword ";
            Object[] prms = new object[] { "%" + name + "%" };
            return KetNoiSql.Instance.execSql(sql, prms);
        }
        public List<NHACUNGCAP> getDataNhaCungCap()
        {
            return KetNoiSql.Instance.getDataNhaCungCap();
        }
        public DataTable getMaNhaCungCap(string masp)
        {
            string sql = $"select MaNhaCungCap,TenNhaCungCap from NHACUNGCAP where TenNhaCungCap = '{masp}'";
            return KetNoiSql.Instance.execSql(sql);
        }
    }
}
