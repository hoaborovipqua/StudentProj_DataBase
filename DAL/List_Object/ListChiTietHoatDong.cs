using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
using DTO.Object;

namespace DAL.List_Object
{
    public class ListChiTietHoatDong
    {
        public List<ChiTietHoatDong> list_cthd = new List<ChiTietHoatDong>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListChiTietHoatDong()
        {

        }

        public List<ChiTietHoatDong> Load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ChiTietHoatDong", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ChiTietHoatDong cthd = new ChiTietHoatDong();
                cthd.MaSV_CTHD1 = rd["MaSV"].ToString();
                cthd.MaHK_CTHD1 = rd["MaHK"].ToString();
                cthd.MaHD_CTHD1 = rd["MaHD"].ToString();
                list_cthd.Add(cthd);
            }
            conn.Close();
            return list_cthd;
        }

        public static bool AddActivityDetail(string maSV, string maHK, string maHD)
        {
            try
            {
                // Kết nối tới cơ sở dữ liệu
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    // Bắt đầu giao dịch
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Tạo câu truy vấn INSERT
                            string query = "INSERT INTO ChiTietHoatDong (MaSV, MaHK, MaHD) VALUES (@MaSV, @MaHK, @MaHD)";

                            // Tạo đối tượng SqlCommand và truyền tham số
                            using (SqlCommand command = new SqlCommand(query, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@MaSV", maSV);
                                command.Parameters.AddWithValue("@MaHK", maHK);
                                command.Parameters.AddWithValue("@MaHD", maHD);

                                // Thực thi câu truy vấn
                                int rowsAffected = command.ExecuteNonQuery();

                                // Kiểm tra xem có thành công hay không
                                if (rowsAffected > 0)
                                {
                                    // Hoàn tất giao dịch
                                    transaction.Commit();
                                    return true; // Thêm đối tượng thành công
                                }
                                else
                                {
                                    // Hủy giao dịch
                                    transaction.Rollback();
                                    return false; // Thêm đối tượng thất bại
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hủy giao dịch nếu có lỗi xảy ra
                            transaction.Rollback();
                            Console.WriteLine("Lỗi khi thêm đối tượng vào cơ sở dữ liệu: " + ex.Message);
                            return false; // Thêm đối tượng thất bại
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (exception)
                Console.WriteLine("Lỗi khi kết nối đến cơ sở dữ liệu: " + ex.Message);
                return false; // Thêm đối tượng thất bại
            }
        }

        public static List<ChiTietHoatDong> GetListStudentActivities(string pstuID)
        {
            return ListChiTietHoatDong.GetListStudentActivities(pstuID);
        }

    }
}
