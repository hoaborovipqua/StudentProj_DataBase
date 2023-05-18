using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Object
{
    public class SinhVien_DiemRL
    {
        string MaSV_DRL, MaHK_DRL;
        int DiemRl;

        public SinhVien_DiemRL(string maSV_DRL, string maHK_DRL, int diemRl)
        {
            MaSV_DRL = maSV_DRL;
            MaHK_DRL = maHK_DRL;
            DiemRl = diemRl;
        }
        public SinhVien_DiemRL() { }

        public string MaSV_DRL1 { get => MaSV_DRL; set => MaSV_DRL = value; }
        public string MaHK_DRL1 { get => MaHK_DRL; set => MaHK_DRL = value; }
        public int DiemRl1 { get => DiemRl; set => DiemRl = value; }

    }
}
