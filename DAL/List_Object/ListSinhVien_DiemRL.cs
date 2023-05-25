using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTO;
using DTO.Object;
using System.Linq;

namespace DAL.List_Object
{
    public class ListSinhVien_DiemRL_DiemRL
    {
        public List<SinhVien_DiemRL> list_sv_drl = new List<SinhVien_DiemRL>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListSinhVien_DiemRL_DiemRL()
        {

        }

        public List<SinhVien_DiemRL> Load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SinhVien_DiemRL", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                SinhVien_DiemRL sv_drl = new SinhVien_DiemRL();
                sv_drl.MaSV_DRL1 = rd["MaSV"].ToString();
                sv_drl.MaHK_DRL1 = rd["MaHK"].ToString();
                sv_drl.DiemRl1 = int.Parse(rd["DiemRL"].ToString());
                list_sv_drl.Add(sv_drl);
            }
            conn.Close();
            return list_sv_drl;
        }

        public static (string, string, int) GetTrainingPoint(string pstuID, string psemesterID)
        {
            ListSV listSV = new ListSV();
            List<SinhVien> sinhViens = listSV.Load();
            string ssn = sinhViens.FirstOrDefault(x => x.MaSV1 == pstuID)?.Sv_maDD;

            ListNguoi listNguoi = new ListNguoi();
            List<Nguoi> nguois = listNguoi.Load();

            ListHocKy listHocKy = new ListHocKy();
            List<HocKy> hocKies = listHocKy.Load();

            ListSinhVien_DiemRL_DiemRL listSinhVien_DiemRL_DiemRL = new ListSinhVien_DiemRL_DiemRL();
            List<SinhVien_DiemRL> sinhVien_DiemRLs1 = listSinhVien_DiemRL_DiemRL.Load();


            return (nguois.FirstOrDefault(x => x.MaDD1 == ssn)?.HoTen1, hocKies.FirstOrDefault(x => x.MaHK1 == psemesterID)?.TenHK1, 
                sinhVien_DiemRLs1.FirstOrDefault(x => x.MaSV_DRL1 == pstuID && x.MaHK_DRL1 == psemesterID).DiemRl1);
        }

    }
}
