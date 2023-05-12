using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SinhVien
{
    class MonHoc
    {
        string maMH, tenMH;
        int soTinChi;
        Diem diem_MH = new Diem(); // có bỏ trong này không?? 

        public MonHoc() { }

        public MonHoc(string maMH, string tenMH, int soTinChi, Diem diem_MH)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTinChi = soTinChi;
            this.Diem_MH = diem_MH;
        }
        public MonHoc(string maMH, string tenMH, int soTinChi)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTinChi = soTinChi;
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        internal Diem Diem_MH { get => diem_MH; set => diem_MH = value; }

        public void xuat_MH_Console()
        {
            Console.Write("{0} ", this.maMH);
            Console.Write("{0} ", this.tenMH);
            Console.Write("{0} ", this.soTinChi);
            this.Diem_MH.xuat_Diem_Console();
        }

       
        public string xem_va_chon_TietHoc(string filePath)
        {
            List<string> list_Tiet = new List<string>();
            StreamReader reader = new StreamReader(filePath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] time = line.Split(',');
                Console.WriteLine(time[0]);
                list_Tiet.Add(time[0]);
            }
            Console.WriteLine("Chon cac tiet hoc theo thu tu 1 - 5");
            int n = Console.Read();
            return list_Tiet[n - 1];
        }
    }
}
