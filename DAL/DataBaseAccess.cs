using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTO;
using System.Data;


namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            // Tạo chuỗi kết nối cơ sở dữ liệu 
            string strcon = @"Data Source=LAPTOP-92VCKNC0\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
            // khởi tạo connect 
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }


        //string strcon = @"Data Source=LAPTOP-92VCKNC0\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
        //SqlConnection conn;
        //public SqlConnectionData()
        //{
        //    Conn = new SqlConnection(strcon);
        //}
        //public SqlConnection Conn { get => conn; set => conn = value; }
    }


    public class DatabaseAccess
    {
        public static string CheckLogginDTO(TaiKhoan taiKhoan)
        {
            string user = null;
            // hàm connect tới CSDL 
            SqlConnection conn = SqlConnectionData.Connect();

            conn.Open();
            SqlCommand command = new SqlCommand("proc_loggin", conn);
            //SqlCommand command = new SqlCommand("QuanLySinhVien.proc_loggin", conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taiKhoan.sTaiKhoan);
            command.Parameters.AddWithValue("@pass", taiKhoan.sMatKhau);


            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0); // lấy mã tài khoản 
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài Khoản hoặc mật khẩu không tồn tại!";
            }

            return user;
        }
    }

}
