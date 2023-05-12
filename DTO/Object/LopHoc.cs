using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class LopHoc
    {
        string maLH, tenLH;
        GiangVien gvCoVan = new GiangVien();

        public LopHoc() { }
        public LopHoc(string maLH, string tenLH, GiangVien gvCoVan)
        {
            this.maLH = maLH;
            this.tenLH = tenLH;
            this.GvCoVan = gvCoVan;
        }
        public LopHoc(string maLH, string tenLH)
        {
            this.maLH = maLH;
            this.tenLH = tenLH;
        }

        public string MaLH { get => maLH; set => maLH = value; }
        public string TenLH { get => tenLH; set => tenLH = value; }
        internal GiangVien GvCoVan { get => gvCoVan; set => gvCoVan = value; }

        public void nhap_LH_Console()
        {
            Console.Write("Nhap vao ma Lop Hoc: ");
            this.maLH = Console.ReadLine();
            Console.Write("Nhap vao ten Lop Hoc: ");
            this.tenLH = Console.ReadLine();
            this.GvCoVan.nhap_GV_Console();
        }

        public void xuat_LopHoc_Console()
        {
            Console.Write("{0} / {1}", this.maLH, this.tenLH, this.gvCoVan.HoTen); // co the xuat gvCoVan O day
        }
    }
}
