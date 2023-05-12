using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace SinhVien
{
    class ListSV
    {
        public List<SinhVien> list_SV = new List<SinhVien>();

        public void TaoList_SV()
        {
            int n;
            Console.WriteLine("Nhap vao so luong sinh vien can nhap: ");
            n = Console.Read();
            for(int i = 0; i < n; i++)
            {
                SinhVien tmp = new SinhVien();
                tmp.nhapSV_Console();
                this.list_SV.Add(tmp);
            }
        }

        public void Nhap(string filePath)
        {

            StreamReader reader = new StreamReader(filePath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] studentInfo = line.Split(',');
                Khoa tmp1 = new Khoa(studentInfo[1], studentInfo[2]);
                LopHoc tmp2 = new LopHoc(studentInfo[3], studentInfo[4]);
                SinhVien tmp = new SinhVien(studentInfo[0], tmp1, tmp2, studentInfo[5], studentInfo[6], studentInfo[7], studentInfo[8]);
                this.list_SV.Add(tmp);
            }
        }

        public void Xuat()
        {
            foreach(SinhVien x in this.list_SV)
            {
                x.xuat();
                Console.Write("\n");
            }
        }

        public bool check_id(string _pStudent_id)
        {
            if (this.list_SV.Exists(x => x.MaSV == _pStudent_id)) return true;
            else return false;
        }

        public SinhVien Tim(string _pStudent_id)
        {
            SinhVien result = list_SV.Find(
            delegate (SinhVien sv)
            {
                return sv.MaSV == _pStudent_id;
            }
            );
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
