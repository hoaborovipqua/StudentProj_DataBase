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

        


    }
}
