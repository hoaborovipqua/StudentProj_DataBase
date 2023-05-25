using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DTO
{
    public class MonHoc
    {
        string MaMH, TenMonHoc, MaKhoa;
        

        public MonHoc() { }

        public MonHoc(string maMH, string tenMonHoc, string maKhoa)
        {
            MaMH = maMH;
            TenMonHoc = tenMonHoc;
            MaKhoa = maKhoa;
        }

        public string MaMH1 { get => MaMH; set => MaMH = value; }
        public string TenMonHoc1 { get => TenMonHoc; set => TenMonHoc = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }




    }
}
