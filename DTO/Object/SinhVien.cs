using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class SinhVien:Nguoi
    {
        string MaSV, sv_MaLop, sv_maDD;

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string Sv_MaLop { get => sv_MaLop; set => sv_MaLop = value; }
        public string Sv_maDD { get => sv_maDD; set => sv_maDD = value; }

        public SinhVien() { }

        public SinhVien(string maDD, string hoTen, int namSinh, string gioiTinh, string maSV, string sv_MaLop):base(maDD, hoTen, namSinh, gioiTinh)
        {
            MaSV = maSV;
            this.sv_MaLop = sv_MaLop;
            this.sv_maDD = maDD;
        }

        public SinhVien(string maSV, string sv_MaLop, string sv_maDD)
        {
            MaSV = maSV;
            this.sv_MaLop = sv_MaLop;
            this.sv_maDD = sv_maDD;
        }




        //public void nhapSV_Console()
        //{
        //    Console.Write("Nhap vao ma so sinh vien: ");
        //    this.maSV = Console.ReadLine();
        //    this.khoa_sv.nhap_Khoa_Console();
        //    this.LH_sv.nhap_LH_Console();
        //    Console.Write("Nhap vao ma so dinh danh: ");
        //    this.Ssn = Console.ReadLine();
        //    Console.Write("Nhap vao ho ten: ");
        //    this.HoTen = Console.ReadLine();
        //    Console.Write("Nhap vao ngay sinh(dd/mm/yyyy): ");
        //    this.NgaySinh = Console.ReadLine();
        //    Console.Write("Nhap vao dia chi: ");
        //    this.DiaChi = Console.ReadLine();
        //}


        //public override void xuat()
        //{
        //    Console.Write("{0} /", this.maSV);
        //    this.khoa_sv.xuat();
        //    this.LH_sv.xuat_LopHoc_Console();
        //    base.xuat();
        //}

        //// xem list mon học và chọn 
        //public MonHoc xem_va_chon(ListMonHoc CL_list_MH)
        //{
        //    foreach (MonHoc x in CL_list_MH.list_MH)
        //    {
        //        x.xuat_MH_Console();
        //    }
        //    Console.WriteLine("Chon cac mon hoc theo thu tu {0} - {1}", 0, CL_list_MH.list_MH.Count - 1);
        //    int n = Console.Read();
        //    return CL_list_MH.list_MH[n - 1];
        //}





    }
}
