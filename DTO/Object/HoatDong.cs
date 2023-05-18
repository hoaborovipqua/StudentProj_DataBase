using System;
using System.Collections.Generic;
using System.Text;



namespace DTO.Object
{
    public class HoatDong
    {
        string MaHD, TenHD;
        int DiemCong;

        public HoatDong()
        {

        }
        public HoatDong(string maHD, string tenHD, int diemCong)
        {
            MaHD = maHD;
            TenHD = tenHD;
            DiemCong = diemCong;
        }

        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public string TenHD1 { get => TenHD; set => TenHD = value; }
        public int DiemCong1 { get => DiemCong; set => DiemCong = value; }








    }
}
