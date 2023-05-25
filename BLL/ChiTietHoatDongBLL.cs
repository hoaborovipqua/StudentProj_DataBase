using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using DTO.Object;
using DAL.List_Object;
using System.Linq;

namespace BLL
{
    public class ChiTietHoatDongBLL
    {
        ListChiTietHoatDong dsChiTietHoatDong = new ListChiTietHoatDong();

        public List<ChiTietHoatDong> Load()
        {
            return dsChiTietHoatDong.Load();
        }

        public static bool AddActivityDetail(string maSV, string maHK, string maHD)
        {

            ListSV listSV = new ListSV();
            List<SinhVien> sinhViens = listSV.Load();

            if(SinhVienBLL.checkExitStuID(maSV, sinhViens) && HoatDongBLL.CheckActivityID(maHD) && HocKyBLL.CheckSemesterID(maHK))
            {
                return ListChiTietHoatDong.AddActivityDetail(maSV, maHK, maHD);
            }
            else
            {
                return false;
            }
        }

        public static List<ChiTietHoatDong> GetListStudentActivities(string pstuID)
        {
            ListChiTietHoatDong listChiTietHoatDong = new ListChiTietHoatDong();
            List<ChiTietHoatDong> chiTietHoatDongs = listChiTietHoatDong.Load();
            return chiTietHoatDongs.Where(x => x.MaSV_CTHD1 == pstuID).ToList();
        }

    }
}
