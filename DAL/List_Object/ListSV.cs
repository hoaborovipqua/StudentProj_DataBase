using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using DTO;
using DTO.Object;
using DAL.List_Object;
using System.Linq;


namespace DAL
{
    public class ListSV
    {
        
        public List<SinhVien> list_SV = new List<SinhVien>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListSV()
        {

        }

        public List<SinhVien> Load()
        {
            list_SV.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SinhVien", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                SinhVien sv = new SinhVien();
                sv.MaSV1 = rd["MaSV"].ToString();
                sv.Sv_maDD = rd["MaDD"].ToString();
                sv.Sv_MaLop = rd["MaLop"].ToString();
                list_SV.Add(sv);
            }
            conn.Close();
            return list_SV;
        }

        public static (string , int? , string , string , string ) GetStudentInfor(string pstuID)
        {
            ListSV listSV = new ListSV();
            ListNguoi listNguoi = new ListNguoi();
            ListLop listLop = new ListLop();
            ListKhoa listKhoa = new ListKhoa();

            List<SinhVien> sinhViens = listSV.Load();
            List<Nguoi> nguois = listNguoi.Load();
            List<Lop> lops = listLop.Load();
            List<Khoa> khoas = listKhoa.Load();

            string stuName = "";

            string ssn = sinhViens.FirstOrDefault(x => x.MaSV1 == pstuID)?.Sv_maDD;
            stuName = nguois.FirstOrDefault(x => x.MaDD1 == ssn)?.HoTen1;
            int yerofBirth = nguois.FirstOrDefault(x => x.MaDD1 == ssn).NamSinh1;
            string gender = nguois.FirstOrDefault(x => x.MaDD1 == ssn)?.GioiTinh1;


            string classID = sinhViens.FirstOrDefault(x => x.MaSV1 == pstuID)?.Sv_MaLop;
            string className = lops.FirstOrDefault(x => x.MaLop1 == classID)?.TenLop1;


            string facultyID = lops.FirstOrDefault(x => x.MaLop1 == classID)?.MaKhoa1;
            string facultyName = khoas.FirstOrDefault(x => x.MaKhoa1 == facultyID)?.TenKhoa1;

            
            return (stuName, yerofBirth, gender, className, facultyName);
        }


        public static bool AddStudentWithID(string maSV, string maDD)
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
                            string query = "INSERT INTO SinhVien (MaSV, MaDD) VALUES (@MaSV, @MaDD)";

                            // Tạo đối tượng SqlCommand và truyền tham số
                            using (SqlCommand command = new SqlCommand(query, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@MaSV", maSV);
                                command.Parameters.AddWithValue("@MaDD", maDD);

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
                            return false; // Thêm sinh viên thất bại
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (exception)
                return false; // Thêm sinh viên thất bại
            }
        }


        public static string MakeNewStuID(string pmaxID)
        {
            string curNumber = pmaxID.Substring(2); 
            int nextNumber = int.Parse(curNumber) + 1; 
            string newID = "SV" + nextNumber.ToString("D3"); // Tạo mã mới với số được định dạng thành chuỗi 3 chữ số (VD: SV003)
            return newID;
        }
        


        public static bool addNewStudent(string pname, string pgen, int pyob)
        {
            ListNguoi listNguoi = new ListNguoi();
            List<Nguoi> nguois = listNguoi.Load();
            string maxID = nguois.Max(ng => ng.MaDD1);

            string newPersonID = ListNguoi.MakeNewPersonID(maxID);
            if(ListNguoi.AddPersonInfo(newPersonID, pname, pyob, pgen))
            {
                ListSV listSV = new ListSV();
                List<SinhVien> sinhViens = listSV.Load();
                string maxStuID = sinhViens.Max(sv => sv.MaSV1);
                string newStuID = MakeNewStuID(maxStuID);
                return AddStudentWithID(newStuID, newPersonID);
            }
            else
            {
                return false;
            }
        }

        public static bool AddClassIDToStudent(string maSV, string maLop)
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
                            // Tạo câu truy vấn UPDATE
                            string query = "UPDATE SinhVien SET MaLop = @MaLop WHERE MaSV = @MaSV";

                            // Tạo đối tượng SqlCommand và truyền tham số
                            using (SqlCommand command = new SqlCommand(query, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@MaLop", maLop);
                                command.Parameters.AddWithValue("@MaSV", maSV);

                                // Thực thi câu truy vấn
                                int rowsAffected = command.ExecuteNonQuery();

                                // Kiểm tra xem có thành công hay không
                                if (rowsAffected > 0)
                                {
                                    // Hoàn tất giao dịch
                                    transaction.Commit();
                                    return true; // Thêm mã lớp cho sinh viên thành công
                                }
                                else
                                {
                                    // Hủy giao dịch
                                    transaction.Rollback();
                                    return false; // Thêm mã lớp cho sinh viên thất bại
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hủy giao dịch nếu có lỗi xảy ra
                            transaction.Rollback();
                            return false; // Thêm mã lớp cho sinh viên thất bại
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (exception)
                return false; // Thêm mã lớp cho sinh viên thất bại
            }
        }



    }
}
