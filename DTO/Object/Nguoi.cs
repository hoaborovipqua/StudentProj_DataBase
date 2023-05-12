using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class Nguoi
    {
        string ssn, hoTen, ngaySinh, diaChi;

        public static string gioiTinh = "NU";

        public Nguoi() { }
        public Nguoi(string ssn, string hoTen, string ngaySinh, string diaChi)
        {
            this.ssn = ssn;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
        }
        public string Ssn { get => ssn; set => ssn = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public virtual void xuat()
        {
            Console.WriteLine("{0} / {1} / {2} / {3} ", this.ssn, this.hoTen, this.ngaySinh, this.diaChi);
        }


    }
}
