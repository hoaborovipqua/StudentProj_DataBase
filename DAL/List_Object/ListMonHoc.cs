using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ListMonHoc
    {
        public List<MonHoc> list_mh = new List<MonHoc>();

        SqlConnection conn = SqlConnectionData.Connect();

        public ListMonHoc()
        {

        }

        public List<MonHoc> Load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from MonHoc", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                MonHoc mh = new MonHoc();
                mh.MaMH1 = rd["MaMH"].ToString();
                mh.TenMonHoc1 = rd["TenMonHoc"].ToString();
                mh.MaKhoa1 = rd["MaKhoa"].ToString();
                list_mh.Add(mh);
            }

            return list_mh;
        }

        //public void Nhap(string filePath)
        //{
        //    StreamReader reader = new StreamReader(filePath);
        //    string line;
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        string[] t_monhoc = line.Split(',');
        //        MonHoc mh = new MonHoc(t_monhoc[0], t_monhoc[1], int.Parse(t_monhoc[2]));
        //        list_MH.Add(mh);
        //    }
        //}


    }
}
