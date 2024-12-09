using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleApp.Model;

namespace SaleApp.DAO
{
    internal class KetNoiSql
    {
        private static KetNoiSql instance;
        string connsql = @"Data Source=VvV\ANHTAN;Initial Catalog=QUAN_LY_BAN_HANG;Integrated Security=True";
        public KetNoiSql()
        {
        }

        public static KetNoiSql Instance
        {
            get
            {
                if (instance == null)
                    instance = new KetNoiSql();
                return instance;
            }
        }

        public List<QUYEN> getDataQuyen()
        {
            List<QUYEN> quyens = new List<QUYEN>();
            DataTable dataTable = new DataTable();
            String sql = "Select * from QUYEN";
            //Kết nối sql
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Truy vấn sql
            SqlCommand command = new SqlCommand(sql, conn);
            //Lưu dữ liệu vào adapter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Lấy dữ liệu vào datatable
            adapter.Fill(dataTable);
            conn.Close();
            //Sao chép dữ liệu từ datatable vào list QUYEN
            foreach (DataRow row in dataTable.Rows)
            {
                QUYEN quyen = new QUYEN();
                // Sao chép giá trị từ các cột tương ứng trong bảng QUYEN
                quyen.TenQuyen = row["TenQuyen"].ToString();
                quyen.MaQuyen = Convert.ToInt32(row["MaQuyen"]);
                quyens.Add(quyen);
            }

            return quyens;
        }
        public List<LOAIHANG> getDataLoaiHang()
        {
            List<LOAIHANG> quyens = new List<LOAIHANG>();
            DataTable dataTable = new DataTable();
            String sql = "Select * from LOAIHANG";
            //Kết nối sql
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Truy vấn sql
            SqlCommand command = new SqlCommand(sql, conn);
            //Lưu dữ liệu vào adapter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Lấy dữ liệu vào datatable
            adapter.Fill(dataTable);
            conn.Close();
            //Sao chép dữ liệu từ datatable vào list QUYEN
            foreach (DataRow row in dataTable.Rows)
            {
                LOAIHANG quyen = new LOAIHANG();
                // Sao chép giá trị từ các cột tương ứng trong bảng QUYEN
                quyen.TenLoaiHang = row["TenLoaiHang"].ToString();
                quyen.MaLoaiHang = row["MaLoaiHang"].ToString();
                quyens.Add(quyen);
            }

            return quyens;
        }
        public List<SANPHAM> getDataSanPham()
        {
            List<SANPHAM> quyens = new List<SANPHAM>();
            DataTable dataTable = new DataTable();
            String sql = "Select * from SANPHAM";
            //Kết nối sql
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Truy vấn sql
            SqlCommand command = new SqlCommand(sql, conn);
            //Lưu dữ liệu vào adapter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Lấy dữ liệu vào datatable
            adapter.Fill(dataTable);
            conn.Close();
            //Sao chép dữ liệu từ datatable vào list QUYEN
            foreach (DataRow row in dataTable.Rows)
            {
                SANPHAM quyen = new SANPHAM();
                // Sao chép giá trị từ các cột tương ứng trong bảng QUYEN
                quyen.TenSanPham = row["TenSanPham"].ToString();
                quyen.MaSanPham = row["MaLoaiHang"].ToString();
                quyens.Add(quyen);
            }

            return quyens;
        }
        public List<NHACUNGCAP> getDataNhaCungCap()
        {
            List<NHACUNGCAP> quyens = new List<NHACUNGCAP>();
            DataTable dataTable = new DataTable();
            String sql = "Select * from NHACUNGCAP";
            //Kết nối sql
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Truy vấn sql
            SqlCommand command = new SqlCommand(sql, conn);
            //Lưu dữ liệu vào adapter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Lấy dữ liệu vào datatable
            adapter.Fill(dataTable);
            conn.Close();
            //Sao chép dữ liệu từ datatable vào list QUYEN
            foreach (DataRow row in dataTable.Rows)
            {
                NHACUNGCAP quyen = new NHACUNGCAP();
                // Sao chép giá trị từ các cột tương ứng trong bảng QUYEN
                quyen.TenNhaCungCap = row["TenNhaCungCap"].ToString();
                quyen.MaNhaCungCap = row["MaNhaCungCap"].ToString();
                quyens.Add(quyen);
            }

            return quyens;
        }
        public string checkLogin(TAIKHOAN taikhoan)
        {
            string user = null;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_checkLogin", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@sodienthoai", taikhoan.SoDienThoai);
            command.Parameters.AddWithValue("@matkhau", taikhoan.MatKhau);
            command.Parameters.AddWithValue("@maquyen", taikhoan.MaQuyen);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    user = reader.GetString(0); //lấy dữ liệu cột đầu tiên
                }
            }
            else return "error";
            reader.Close();
            conn.Close();
            return user;
        }
        public decimal getTongDoanhThu()
        {
            decimal tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongDoanhThu", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    tong = reader.GetDecimal(0); //lấy dữ liệu cột đầu tiên
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public decimal getTongDoanhThuTheoNam(int n)
        {
            decimal tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongDoanhThuTheoNam", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", n);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    if (!reader.IsDBNull(0)) // Kiểm tra xem cột có giá trị NULL hay không
                    {
                        tong = reader.GetDecimal(0); // Lấy dữ liệu cột đầu tiên
                    }
                    else
                    {
                        tong = 0; // Gán giá trị mặc định
                    }
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public decimal getTongDoanhThuTheoNamThang(int n,int t)
        {
            decimal tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongDoanhThuTheoNamThang", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", n);
            command.Parameters.AddWithValue("@t", t);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read()) // Đọc dữ liệu
                {
                    if (!reader.IsDBNull(0)) // Kiểm tra xem cột có giá trị NULL hay không
                    {
                        tong = reader.GetDecimal(0); // Lấy dữ liệu cột đầu tiên
                    }
                    else
                    {
                        tong = 0; // Gán giá trị mặc định
                    }
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public int getTongSanPham()
        {
            int tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongSanPham", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    tong = reader.GetInt32(0); //lấy dữ liệu cột đầu tiên
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public int getTongSanPhamTheoNam(int n)
        {
            int tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongSanPhamTheoNam", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", n);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    if (!reader.IsDBNull(0)) // Kiểm tra xem cột có giá trị NULL hay không
                    {
                        tong = reader.GetInt32(0); //lấy dữ liệu cột đầu tiên
                    }
                    else
                    {
                        tong = 0; // Gán giá trị mặc định
                    }
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public int getTongSanPhamTheoNamThang(int n, int t)
        {
            int tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongSanPhamTheoNamThang", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", n);
            command.Parameters.AddWithValue("@t", t);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    if (!reader.IsDBNull(0)) // Kiểm tra xem cột có giá trị NULL hay không
                    {
                        tong = reader.GetInt32(0); //lấy dữ liệu cột đầu tiên
                    }
                    else
                    {
                        tong = 0; // Gán giá trị mặc định
                    }
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public int getTongKhachHang()
        {
            int tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongKhachHang", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    tong = reader.GetInt32(0); //lấy dữ liệu cột đầu tiên
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public int getTongKhachHangTheoNam(int n)
        {
            int tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongKhachHangTheoNam", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", n);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    if (!reader.IsDBNull(0)) // Kiểm tra xem cột có giá trị NULL hay không
                    {
                        tong = reader.GetInt32(0); //lấy dữ liệu cột đầu tiên
                    }
                    else
                    {
                        tong = 0; // Gán giá trị mặc định
                    }
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public int getTongKhachHangTheoNamThang(int n, int t)
        {
            int tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongKhachHangTheoNamThang", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", n);
            command.Parameters.AddWithValue("@t", t);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    if (!reader.IsDBNull(0)) // Kiểm tra xem cột có giá trị NULL hay không
                    {
                        tong = reader.GetInt32(0); //lấy dữ liệu cột đầu tiên
                    }
                    else
                    {
                        tong = 0; // Gán giá trị mặc định
                    }
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public int getTongDonMua()
        {
            int tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongDonMua", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    tong = reader.GetInt32(0); //lấy dữ liệu cột đầu tiên
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public int getTongDonMuaTheoNam(int n)
        {
            int tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongDonMuaTheoNam", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", n);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    if (!reader.IsDBNull(0)) // Kiểm tra xem cột có giá trị NULL hay không
                    {
                        tong = reader.GetInt32(0); //lấy dữ liệu cột đầu tiên
                    }
                    else
                    {
                        tong = 0; // Gán giá trị mặc định
                    }
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        public int getTongDonMuaTheoNamThang(int n, int t)
        {
            int tong = 0;
            SqlConnection conn = new SqlConnection(connsql);
            conn.Open();
            //Tạo command tên sp_checkLogin để truy vấn csdl
            SqlCommand command = new SqlCommand("sp_getTongDonMuaTheoNamThang", conn);
            //Chọn loại command
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@n", n);
            command.Parameters.AddWithValue("@t", t);
            command.Connection = conn;
            //Thực hiện truy vấn csdl
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)     //có dữ liệu
            {
                while (reader.Read())   //đọc dữ liệu
                {
                    if (!reader.IsDBNull(0)) // Kiểm tra xem cột có giá trị NULL hay không
                    {
                        tong = reader.GetInt32(0); //lấy dữ liệu cột đầu tiên
                    }
                    else
                    {
                        tong = 0; // Gán giá trị mặc định
                    }
                }
            }
            else return 0;
            reader.Close();
            conn.Close();
            return tong;
        }
        // SELECT ....
        public DataTable execSql(string sql, params Object[] args)
        {
            DataTable dat = new DataTable();
            using (SqlConnection connection = new SqlConnection(connsql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(' ');
                    List<string> paramList = new List<string>();
                    foreach (string s in processSql)
                        if (s.StartsWith("@"))
                        {
                            if (s.EndsWith(","))
                                paramList.Add(s.Remove(s.Length - 1));
                            else paramList.Add(s);
                        }
                    for (int i = 0; i < args.Length; i++)
                        command.Parameters.AddWithValue(paramList[i], args[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dat);
                connection.Close();
            }
            return dat;
        }

        // INSERT, UPDATE, DELETE ....
        public int execNonSql(string sql, params Object[] args)
        {
            int effectedRows;
            using (SqlConnection connection = new SqlConnection(connsql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(' ');
                    List<string> paramList = new List<string>();
                    foreach (string s in processSql)
                        if (s.StartsWith("@"))
                        {
                            if (s.EndsWith(","))
                                paramList.Add(s.Remove(s.Length - 1));
                            else paramList.Add(s);
                        }
                    for (int i = 0; i < args.Length; i++)
                        command.Parameters.AddWithValue(paramList[i], args[i]);
                }
                effectedRows = command.ExecuteNonQuery();
                connection.Close();
            }
            return effectedRows;
        }
    }
}
