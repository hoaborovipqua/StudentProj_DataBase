using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class GiangVien : Nguoi
    {
        string MaGV, MaKhoa, MaDD_GV;

        public GiangVien(string maGV, string maKhoa, string maDD_GV)
        {
            MaGV = maGV;
            MaKhoa = maKhoa;
            MaDD_GV = maDD_GV;
        }

        public string MaGV1 { get => MaGV; set => MaGV = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string MaDD_GV1 { get => MaDD_GV; set => MaDD_GV = value; }


        public GiangVien() { }

        
    }
}
