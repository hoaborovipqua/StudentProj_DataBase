using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class GiangVien : Nguoi
    {
        string MaGV, MaKhoa, MaDD;

        public string MaGV1 { get => MaGV; set => MaGV = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string MaDD2 { get => MaDD; set => MaDD = value; }

        public GiangVien(string maGV, string maKhoa, string maDD)
        {
            this.MaGV1 = maGV;
            MaKhoa1 = maKhoa;
            MaDD2 = maDD;
        }

        public GiangVien() { }

        //public void nhap_GV_Console()
        //{
        //    Console.Write("Nhap vao ma GV: ");
        //    this.maGV = Console.ReadLine();
        //    this.khoa_GV.nhap_Khoa_Console();
        //}
        //public override void xuat()
        //{
        //    Console.Write("{0} /", this.maGV);
        //    this.khoa_GV.xuat();
        //    base.xuat();
        //}

        
    }
}
