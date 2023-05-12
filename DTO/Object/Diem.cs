using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class Diem
    {
        double diem_ChuyenCan, diem_Quatrinh, diem_CuoiKy;

        public Diem() { }
        public Diem(double diem_ChuyenCan, double diem_Quatrinh, double diem_CuoiKy)
        {
            this.Diem_ChuyenCan = diem_ChuyenCan;
            this.Diem_Quatrinh = diem_Quatrinh;
            this.Diem_CuoiKy = diem_CuoiKy;
        }

        public double Diem_ChuyenCan { get => diem_ChuyenCan; set => diem_ChuyenCan = value; }
        public double Diem_Quatrinh { get => diem_Quatrinh; set => diem_Quatrinh = value; }
        public double Diem_CuoiKy { get => diem_CuoiKy; set => diem_CuoiKy = value; }

        public void nhap_Diem_Console()
        {
            Console.Write("Nhap vao diem chuyen can: ");
            this.diem_ChuyenCan = Console.Read();
            Console.Write("Nhap vao diem qua trinh: ");
            this.diem_Quatrinh = Console.Read();
            Console.Write("Nhap vao diem cuoi ky: ");
            this.Diem_CuoiKy = Console.Read();
        }

        public void xuat_Diem_Console()
        {
            Console.Write("{0} / {1} / {2}", this.diem_ChuyenCan, this.diem_Quatrinh, this.diem_CuoiKy);
        }
    }
}
