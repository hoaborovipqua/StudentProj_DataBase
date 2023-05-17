using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DTO
{
    public class MonHoc
    {
        string MaMH, TenMonHoc, MaKhoa;
        

        public MonHoc() { }

        public MonHoc(string maMH, string tenMonHoc, string maKhoa)
        {
            MaMH = maMH;
            TenMonHoc = tenMonHoc;
            MaKhoa = maKhoa;
        }

        public string MaMH1 { get => MaMH; set => MaMH = value; }
        public string TenMonHoc1 { get => TenMonHoc; set => TenMonHoc = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }



        //public void xuat_MH_Console()
        //{
        //    Console.Write("{0} ", this.maMH);
        //    Console.Write("{0} ", this.tenMH);
        //    Console.Write("{0} ", this.soTinChi);
        //    this.Diem_MH.xuat_Diem_Console();
        //}


        //public string xem_va_chon_TietHoc(string filePath)
        //{
        //    List<string> list_Tiet = new List<string>();
        //    StreamReader reader = new StreamReader(filePath);
        //    string line;
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        string[] time = line.Split(',');
        //        Console.WriteLine(time[0]);
        //        list_Tiet.Add(time[0]);
        //    }
        //    Console.WriteLine("Chon cac tiet hoc theo thu tu 1 - 5");
        //    int n = Console.Read();
        //    return list_Tiet[n - 1];
        //}
    }
}
