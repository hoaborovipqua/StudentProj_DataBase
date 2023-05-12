using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class PhongHoc
    {
        string maPhong, tenPhong, diaChi;

        public PhongHoc() { }
        public PhongHoc(string maPhong, string tenPhong, string diaChi)
        {
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.diaChi = diaChi;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public void nhap_PH_Console()
        {
            Console.Write("Nhap vao ma phong: ");
            this.maPhong = Console.ReadLine();
            Console.Write("Nhap vao ten phong: ");
            this.tenPhong = Console.ReadLine();
            Console.Write("Nhap vao dia chi: ");
            this.diaChi = Console.ReadLine();
        }

    }
}
