using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTO.Object;


namespace DAL.List_Object
{
    public class ListLop
    {
        public List<Lop> list_LH = new List<Lop>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListLop()
        {

        }

        public List<Lop> Load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Lop", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Lop lh = new Lop();
                lh.MaLop1 = rd["MaLop"].ToString();
                lh.TenLop1 = rd["TenLop"].ToString();
                lh.MaKhoa1 = rd["MaKhoa"].ToString();
                lh.SoThuTu1 = int.Parse(rd["SoThuTu"].ToString());
                list_LH.Add(lh);               
            }

            return list_LH;
        }

    }
}
