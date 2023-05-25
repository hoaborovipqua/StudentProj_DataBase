using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTO;
using DTO.Object;

namespace DAL.List_Object
{
    public class ListHoatDong
    {
        public List<HoatDong> list_hd = new List<HoatDong>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListHoatDong()
        {

        }

        public List<HoatDong> Load()
        {
            list_hd.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoatDong", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                HoatDong hd = new HoatDong();
                hd.MaHD1 = rd["MaHD"].ToString();
                hd.TenHD1 = rd["TenHD"].ToString();
                hd.DiemCong1 = int.Parse(rd["DiemCong"].ToString());
                list_hd.Add(hd);
            }
            conn.Close();
            return list_hd;
        }
    }
}
