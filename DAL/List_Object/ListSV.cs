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




    }
}
