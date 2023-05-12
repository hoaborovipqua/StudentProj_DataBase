using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class SinhVien:Nguoi
    {
        string maSV;
        List<MonHoc> list_MH_SV = new List<MonHoc>();
        Khoa khoa_sv = new Khoa();
        LopHoc LH_sv = new LopHoc();
        public static string tenTruong = "HUFI";

        public SinhVien() { }

        public SinhVien(string maSV, List<MonHoc> list_MH_SV, Khoa khoa_sv, LopHoc lH_sv, string pSsn, string pHoTen, string pNgaySinh, string pDiaChi):base(pSsn, pHoTen, pNgaySinh, pDiaChi)
        {
            this.maSV = maSV;
            this.list_MH_SV = list_MH_SV;
            this.khoa_sv = khoa_sv;
            LH_sv = lH_sv;
        }
        public SinhVien(string maSV, Khoa khoa_sv, LopHoc lH_sv, string pSsn, string pHoTen, string pNgaySinh, string pDiaChi) : base(pSsn, pHoTen, pNgaySinh, pDiaChi)
        {
            this.maSV = maSV;
            this.khoa_sv = khoa_sv;
            LH_sv = lH_sv;
        }
        public string MaSV { get => maSV; set => maSV = value; }

        public void nhapSV_Console()
        {
            Console.Write("Nhap vao ma so sinh vien: ");
            this.maSV = Console.ReadLine();
            this.khoa_sv.nhap_Khoa_Console();
            this.LH_sv.nhap_LH_Console();
            Console.Write("Nhap vao ma so dinh danh: ");
            this.Ssn = Console.ReadLine();
            Console.Write("Nhap vao ho ten: ");
            this.HoTen = Console.ReadLine();
            Console.Write("Nhap vao ngay sinh(dd/mm/yyyy): ");
            this.NgaySinh = Console.ReadLine();
            Console.Write("Nhap vao dia chi: ");
            this.DiaChi = Console.ReadLine();
        }


        public override void xuat()
        {
            Console.Write("{0} /", this.maSV);
            this.khoa_sv.xuat();
            this.LH_sv.xuat_LopHoc_Console();
            base.xuat();
        }

        // xem list mon học và chọn 
        public MonHoc xem_va_chon(ListMonHoc CL_list_MH)
        {
            foreach (MonHoc x in CL_list_MH.list_MH)
            {
                x.xuat_MH_Console();
            }
            Console.WriteLine("Chon cac mon hoc theo thu tu {0} - {1}", 0, CL_list_MH.list_MH.Count - 1);
            int n = Console.Read();
            return CL_list_MH.list_MH[n - 1];
        }

        

        

    }
}
