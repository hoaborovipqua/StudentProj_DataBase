using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Khoa
    {
        string MaKhoa, TenKhoa;
        int NamThanhLap;

        public Khoa() { }

        public Khoa(string maKhoa, string tenKhoa, int namThanhLap)
        {
            MaKhoa1 = maKhoa;
            TenKhoa1 = tenKhoa;
            NamThanhLap1 = namThanhLap;
        }

        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string TenKhoa1 { get => TenKhoa; set => TenKhoa = value; }
        public int NamThanhLap1 { get => NamThanhLap; set => NamThanhLap = value; }




    }
}

