using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTO;
using DTO.Object;

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

            return list_sv_drl;
        }
    }
}
