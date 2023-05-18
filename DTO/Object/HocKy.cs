using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Object
{
    public class HocKy
    {
        string MaHK, TenHK;
        int NamHoc;

        public HocKy()
        {

        }

        public HocKy(string maHK, string tenHK, int namHoc)
        {
            MaHK = maHK;
            TenHK = tenHK;
            NamHoc = namHoc;
        }

        public string MaHK1 { get => MaHK; set => MaHK = value; }
        public string TenHK1 { get => TenHK; set => TenHK = value; }
        public int NamHoc1 { get => NamHoc; set => NamHoc = value; }



    }
}
