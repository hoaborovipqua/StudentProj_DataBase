using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Object
{
    public class Lop
    {
        string MaLop, TenLop, MaKhoa;
        int SoThuTu;

        public Lop() { }

        public Lop(string maLop, string tenLop, string maKhoa, int soThuTu)
        {
            MaLop1 = maLop;
            TenLop1 = tenLop;
            MaKhoa1 = maKhoa;
            SoThuTu1 = soThuTu;
        }

        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string TenLop1 { get => TenLop; set => TenLop = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public int SoThuTu1 { get => SoThuTu; set => SoThuTu = value; }





    }
}
