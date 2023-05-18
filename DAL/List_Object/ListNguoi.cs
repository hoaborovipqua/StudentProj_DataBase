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

            return list_Ng;
        }
    }
}
