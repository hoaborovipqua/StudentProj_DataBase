using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Object
{
    public class ChiTietHoatDong
    {
        string MaSV_CTHD, MaHK_CTHD, MaHD_CTHD;

        public ChiTietHoatDong(string maSV_CTHD, string maHK_CTHD, string maHD_CTHD)
        {
            MaSV_CTHD = maSV_CTHD;
            MaHK_CTHD = maHK_CTHD;
            MaHD_CTHD = maHD_CTHD;
        }
        public ChiTietHoatDong() { }

        public string MaSV_CTHD1 { get => MaSV_CTHD; set => MaSV_CTHD = value; }
        public string MaHK_CTHD1 { get => MaHK_CTHD; set => MaHK_CTHD = value; }
        public string MaHD_CTHD1 { get => MaHD_CTHD; set => MaHD_CTHD = value; }
    }
}
