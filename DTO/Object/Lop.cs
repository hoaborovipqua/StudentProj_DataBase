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




        //public void nhap_LH_Console()
        //{
        //    Console.Write("Nhap vao ma Lop Hoc: ");
        //    this.maLH = Console.ReadLine();
        //    Console.Write("Nhap vao ten Lop Hoc: ");
        //    this.tenLH = Console.ReadLine();
        //    this.GvCoVan.nhap_GV_Console();
        //}

        //public void xuat_Lop_Console()
        //{
        //    Console.Write("{0} / {1}", this.maLH, this.tenLH, this.gvCoVan.HoTen); // co the xuat gvCoVan O day
        //}
    }
}
