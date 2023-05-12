using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SinhVien
{
    class ListGV
    {
        public List<GiangVien> list_GV = new List<GiangVien>();

        public void Nhap(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string line;
            while ((line = reader.ReadLine()) != null) 
            {
                string[] lecInfo = line.Split(',');
                Khoa tmp1 = new Khoa(lecInfo[1], lecInfo[2]);
                GiangVien tmp = new GiangVien(lecInfo[0], tmp1, lecInfo[3], lecInfo[4], lecInfo[5], lecInfo[6]);
                this.list_GV.Add(tmp);
            }
        }

        public void Xuat()
        {
            foreach (GiangVien x in this.list_GV)
            {
                x.xuat();
            }
        }


        // xem list giảng viên và chọn 
        public GiangVien xem_va_chon(ListGV CL_list_GV)
        {
            foreach (GiangVien x in CL_list_GV.list_GV)
            {
                x.xuat();
            }
            Console.WriteLine("Chon cac mon hoc theo thu tu {0} - {1}", 0, CL_list_GV.list_GV.Count - 1);
            int n = int.Parse(Console.ReadLine());
            return CL_list_GV.list_GV[n - 1];
        }
    }
}
