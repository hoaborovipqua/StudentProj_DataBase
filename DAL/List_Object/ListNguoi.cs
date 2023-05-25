using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTO;


namespace DAL.List_Object
{
    public class ListNguoi
    {
        List<Nguoi> list_Ng = new List<Nguoi>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListNguoi()
        {

        }

        public List<Nguoi> Load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Nguoi", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Nguoi ng = new Nguoi();
                ng.MaDD1 = rd["MaDD"].ToString();
                ng.HoTen1 = rd["HoTen"].ToString();
                ng.NamSinh1 = int.Parse(rd["NamSinh"].ToString());
                ng.GioiTinh1 = rd["GioiTinh"].ToString();
                list_Ng.Add(ng);
            }

            conn.Close();
            return list_Ng;
        }

        public static string MakeNewPersonID(string pmaxID)
        {
            string curNumber = pmaxID.Substring(2);
            int nextNumber = int.Parse(curNumber) + 1;
            string newID = "DD" + nextNumber.ToString("D3"); // Tạo mã mới với số được định dạng thành chuỗi 3 chữ số (VD: SV003)
            return newID;
        }

        // them 1 người mới vào 
        public static bool AddPersonInfo(string maDD, string hoTen, int namSinh, string gioiTinh)
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
                            string query = "INSERT INTO Nguoi (MaDD, HoTen, NamSinh, GioiTinh) VALUES (@MaDD, @HoTen, @NamSinh, @GioiTinh)";

                            // Tạo đối tượng SqlCommand và truyền tham số
                            using (SqlCommand command = new SqlCommand(query, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@MaDD", maDD);
                                command.Parameters.AddWithValue("@HoTen", hoTen);
                                command.Parameters.AddWithValue("@NamSinh", namSinh);
                                command.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                                // Thực thi câu truy vấn
                                int rowsAffected = command.ExecuteNonQuery();

                                // Kiểm tra xem có thành công hay không
                                if (rowsAffected > 0)
                                {
                                    // Hoàn tất giao dịch
                                    transaction.Commit();
                                    return true; // Thêm người thành công
                                }
                                else
                                {
                                    // Hủy giao dịch
                                    transaction.Rollback();
                                    return false; // Thêm người thất bại
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hủy giao dịch nếu có lỗi xảy ra
                            transaction.Rollback();
                            Console.WriteLine("Lỗi khi thêm thông tin người vào cơ sở dữ liệu: " + ex.Message);
                            return false; // Thêm người thất bại
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (exception)
                Console.WriteLine("Lỗi khi kết nối đến cơ sở dữ liệu: " + ex.Message);
                return false; // Thêm người thất bại
            }
        }



    }
}
