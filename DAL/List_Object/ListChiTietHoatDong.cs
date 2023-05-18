using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
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

            return list_cthd;
        }
    }
}
