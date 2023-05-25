using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
using DTO.Object;

namespace DAL.List_Object
{
    public class ListChiTietDangKiMonHoc
    {
        public List<ChiTietDangKiMonHoc> list_ctdkmh = new List<ChiTietDangKiMonHoc>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListChiTietDangKiMonHoc()
        {

        }

        public List<ChiTietDangKiMonHoc> Load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ChiTietDangKiMonHoc", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ChiTietDangKiMonHoc ctdkmh = new ChiTietDangKiMonHoc();
                ctdkmh.MaSV_CTDKMH = rd["MaSV"].ToString();
                ctdkmh.MaGV_CTDKMH = rd["MaGV"].ToString();
                ctdkmh.MaMH_CTDKMH = rd["MaMH"].ToString();
                list_ctdkmh.Add(ctdkmh);
            }
            conn.Close();
            return list_ctdkmh;
        }

        

        public static bool AddSubjectRegisDetail(string maGiangVien, string maMonHoc, string maSinhVien)
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
                            string query = "INSERT INTO ChiTietDangKiMonHoc (MaGV, MaMH, MaSV) VALUES (@MaGiangVien, @MaMonHoc, @MaSinhVien)";

                            // Tạo đối tượng SqlCommand và truyền tham số
                            using (SqlCommand command = new SqlCommand(query, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                                command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);

                                // Thực thi câu truy vấn
                                int rowsAffected = command.ExecuteNonQuery();

                                // Kiểm tra xem có thành công hay không
                                if (rowsAffected > 0)
                                {
                                    // Hoàn tất giao dịch
                                    transaction.Commit();
                                    return true; // Thêm sinh viên thành công
                                }
                                else
                                {
                                    // Hủy giao dịch
                                    transaction.Rollback();
                                    return false; // Thêm sinh viên thất bại
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hủy giao dịch nếu có lỗi xảy ra
                            transaction.Rollback();
                            Console.WriteLine("Lỗi khi thêm sinh viên vào cơ sở dữ liệu: " + ex.Message);
                            return false; // Thêm sinh viên thất bại
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (exception)
                Console.WriteLine("Lỗi khi kết nối đến cơ sở dữ liệu: " + ex.Message);
                return false; // Thêm sinh viên thất bại
            }
        }

        public static List<ChiTietDangKiMonHoc> getListSubjectRegiteredDetail(string pstuID)
        {
            ListChiTietDangKiMonHoc listChiTietDangKiMonHoc = new ListChiTietDangKiMonHoc();
            List<ChiTietDangKiMonHoc> chiTietDangKiMonHocs = listChiTietDangKiMonHoc.Load();

            return chiTietDangKiMonHocs.Where(x => x.MaSV_CTDKMH == pstuID).ToList();
        }

        

        public static bool DeleteSubjectRegisDetail(string maGiangVien, string maMonHoc, string maSinhVien)
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
                            // Tạo câu truy vấn DELETE
                            string query = "DELETE FROM ChiTietDangKiMonHoc WHERE MaGV = @MaGiangVien AND MaMH = @MaMonHoc AND MaSV = @MaSinhVien";

                            // Tạo đối tượng SqlCommand và truyền tham số
                            using (SqlCommand command = new SqlCommand(query, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@MaGiangVien", maGiangVien);
                                command.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                                command.Parameters.AddWithValue("@MaSinhVien", maSinhVien);

                                // Thực thi câu truy vấn
                                int rowsAffected = command.ExecuteNonQuery();

                                // Kiểm tra xem có thành công hay không
                                if (rowsAffected > 0)
                                {
                                    // Hoàn tất giao dịch
                                    transaction.Commit();
                                    return true; // Xóa dòng dữ liệu thành công
                                }
                                else
                                {
                                    // Hủy giao dịch
                                    transaction.Rollback();
                                    return false; // Xóa dòng dữ liệu thất bại
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hủy giao dịch nếu có lỗi xảy ra
                            transaction.Rollback();
                            Console.WriteLine("Lỗi khi xóa dòng dữ liệu: " + ex.Message);
                            return false; // Xóa dòng dữ liệu thất bại
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (exception)
                Console.WriteLine("Lỗi khi kết nối đến cơ sở dữ liệu: " + ex.Message);
                return false; // Xóa dòng dữ liệu thất bại
            }
        }


    }
}
