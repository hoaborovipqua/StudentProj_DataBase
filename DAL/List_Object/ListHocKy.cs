using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTO;
using DTO.Object;

namespace DAL.List_Object
{
    public class ListHocKy
    {
        public List<HocKy> list_hocky = new List<HocKy>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListHocKy()
        {

        }

        public List<HocKy> Load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HocKy", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                HocKy hocky = new HocKy();
                hocky.MaHK1 = rd["MaHK"].ToString();
                hocky.TenHK1 = rd["TenHK"].ToString();
                hocky.NamHoc1 = int.Parse(rd["NamHoc"].ToString());
                list_hocky.Add(hocky);
            }
            conn.Close();
            return list_hocky;
        }
    }
}
