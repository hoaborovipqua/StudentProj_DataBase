using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class GiangVien : Nguoi
    {
        string maGV;
        Khoa khoa_GV = new Khoa();

        public GiangVien() { }

        public GiangVien(string maGV, Khoa khoa_GV, string pSsn, string pHoTen, string pNgaySinh, string pDiaChi):base(pSsn, pHoTen, pNgaySinh,  pDiaChi)
        {
            this.MaGV = maGV;
            this.Khoa_GV = khoa_GV;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        internal Khoa Khoa_GV { get => khoa_GV; set => khoa_GV = value; }

        public void nhap_GV_Console()
        {
            Console.Write("Nhap vao ma GV: ");
            this.maGV = Console.ReadLine();
            this.khoa_GV.nhap_Khoa_Console();
        }
        public override void xuat()
        {
            Console.Write("{0} /", this.maGV);
            this.khoa_GV.xuat();
            base.xuat();
        }

        
    }
}
