using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ListKhoa
    {
        public List<Khoa> list_Khoa = new List<Khoa>();


        // xem list khoa và chọn 
        //public Khoa xem_va_chon()
        //{
        //    foreach (Khoa x in this.list_Khoa)
        //    {
        //        x.xuat();
        //    }
        //    Console.WriteLine("Chon mot khoa theo thu tu {0} - {1}", 0, this.list_Khoa.Count - 1);
        //    int n = int.Parse(Console.ReadLine());
        //    return this.list_Khoa[n - 1];
        //}

        //// hàm nhập list khoa từ file 
        //public void Nhap()
        //{

        //}
    }
}
