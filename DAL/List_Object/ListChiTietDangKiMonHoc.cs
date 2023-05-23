using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}
