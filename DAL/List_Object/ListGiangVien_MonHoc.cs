using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
using DTO.Object;

namespace DAL.List_Object
{
    public class ListGiangVien_MonHoc
    {
        public List<GiangVien_MonHoc> list_gvmh = new List<GiangVien_MonHoc>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListGiangVien_MonHoc()
        {

        }

        public List<GiangVien_MonHoc> Load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from GiangVien_MonHoc", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                GiangVien_MonHoc gvmh = new GiangVien_MonHoc();
                gvmh.MaGV_GVMH = rd["MaGV"].ToString();
                gvmh.MaMH_GVMH = rd["MaMH"].ToString();
                list_gvmh.Add(gvmh);
            }
            conn.Close();
            return list_gvmh;
        }

        public bool AddRegisSubjectDetail(string maGiangVien, string maMonHoc, string maSinhVien)
        {
            try
            {
                // Kết nối tới cơ sở dữ liệu
                using (SqlConnection conn =  SqlConnectionData.Connect())
                {
                    conn.Open();

                    // Tạo câu truy vấn INSERT
                    string query = "INSERT INTO ChiTietDangKiMonHoc (MaGV, MaMH, MaSV) VALUES (@MaGiangVien, @MaMonHoc, @MaSinhVien)";

                    // Tạo đối tượng SqlCommand và truyền tham số
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                        command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                        command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                        

                        // Thực thi câu truy vấn
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có thành công hay không
                        if (rowsAffected > 0)
                        {
                            return true; // Thêm sinh viên thành công
                        }
                        else
                        {
                            return false; // Thêm sinh viên thất bại
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (exception)
                Console.WriteLine("Lỗi khi thêm sinh viên vào cơ sở dữ liệu: " + ex.Message);
                return false; // Thêm sinh viên thất bại
            }
        }


    }
}
