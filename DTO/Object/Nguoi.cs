using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Nguoi
    {
        protected string MaDD, HoTen, GioiTinh;
        private int NamSinh;

        public string MaDD1 { get => MaDD; set => MaDD = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public int NamSinh1 { get => NamSinh; set => NamSinh = value; }

        public Nguoi(string maDD, string hoTen, int namSinh, string gioiTinh)
        {
            this.MaDD1 = maDD;
            this.HoTen1 = hoTen;
            NamSinh1 = namSinh;
            GioiTinh1 = gioiTinh;
        }

        public Nguoi() { }
        


        //public virtual void xuat()
        //{
        //    Console.WriteLine("{0} / {1} / {2} / {3} ", this.MaDD, this.hoTen, this.ngaySinh, this.diaChi);
        //}


    }
}
