using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DTO.Object;
using DAL;
using DAL.List_Object;

namespace BLL
{
    public class HoatDongBLL
    {
        ListHoatDong dsHoatDong = new ListHoatDong();

        public List<HoatDong> Load()
        {
            return dsHoatDong.Load();
        }

        public static bool CheckActivityID(string pActivID)
        {
            ListHoatDong listHoatDong = new ListHoatDong();
            List<HoatDong> hoatDongs = listHoatDong.Load();

            return hoatDongs.Exists(x => x.MaHD1 == pActivID);
        }
    }
}
