using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using BLL;
using DTO.Object;


namespace GUI2
{
    public static class LoadALLData
    {
        public static LopHocBLL dt = new LopHocBLL();
        public static NguoiBLL dt2 = new NguoiBLL();
        public static SinhVienBLL dt3 = new SinhVienBLL();
        public static ChiTietHoatDongBLL dt4 = new ChiTietHoatDongBLL();
        public static GiangVienBLL dt5 = new GiangVienBLL();
        public static HoatDongBLL dt6 = new HoatDongBLL();
        public static HocKyBLL dt7 = new HocKyBLL();
        public static KhoaBLL dt8 = new KhoaBLL();
        public static MonHocBLL dt9 = new MonHocBLL();
        public static SinhVien_DiemRL_BLL dt10 = new SinhVien_DiemRL_BLL();
        public static ChiTietDangKiMonHocBLL dt11 = new ChiTietDangKiMonHocBLL();
        public static GiangVien_MonHocBLL dt12 = new GiangVien_MonHocBLL();


        public static List<Lop> dsLop = new List<Lop>();
        public static List<Nguoi> dsNguoi = new List<Nguoi>();
        public static List<SinhVien> dsSinhVien = new List<SinhVien>();
        public static List<ChiTietHoatDong> dsChiTietHoatDong = new List<ChiTietHoatDong>();
        public static List<GiangVien> dsGiangVien = new List<GiangVien>();
        public static List<HoatDong> dsHoatDong = new List<HoatDong>();
        public static List<HocKy> dsHocKy = new List<HocKy>();
        public static List<Khoa> dsKhoa = new List<Khoa>();
        public static List<MonHoc> dsMonHoc = new List<MonHoc>();
        public static List<SinhVien_DiemRL> dsSinhVien_DiemRL = new List<SinhVien_DiemRL>();
        public static List<ChiTietDangKiMonHoc> dsChiTietDangKiMonHoc = new List<ChiTietDangKiMonHoc>();
        public static List<GiangVien_MonHoc> dsGiangVien_MonHoc = new List<GiangVien_MonHoc>();


        public static string  inputStuID = "";
        public static string subjectRegisteredID = "";
        

        public static void Load_dsLop()
        {
            dsLop = dt.Load();
        }
        public static void Load_dsNguoi()
        {
            dsNguoi = dt2.Load();
        }
        public static void Load_dsSinhVien()
        {
            dsSinhVien = dt3.Load();
        }

        public static void Load_dsChiTietHoatDong()
        {
            dsChiTietHoatDong = dt4.Load();
        }
        public static void Load_dsGiangVien()
        {
            dsGiangVien = dt5.Load();
        }
        public static void Load_HoatDong()
        {
            dsHoatDong = dt6.Load();
        }
        public static void Load_HocKy()
        {
            dsHocKy = dt7.Load();
        }
        public static void Load_Khoa()
        {
            dsKhoa = dt8.Load();
        }
        public static void Load_MonHoc()
        {
            dsMonHoc = dt9.Load();
        }

        public static void Load_SinhVien_DiemRL()
        {
            dsSinhVien_DiemRL = dt10.Load();
        }

        public static void Load_ChiTietDangKiMonHoc()
        {
            dsChiTietDangKiMonHoc = dt11.Load();
        }

        public static void Load_GiangVien_MonHoc()
        {
            dsGiangVien_MonHoc = dt12.Load();
        }


    }
}
