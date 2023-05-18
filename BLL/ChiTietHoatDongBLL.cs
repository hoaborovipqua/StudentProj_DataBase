using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using DTO.Object;
using DAL.List_Object;

namespace BLL
{
    public class ChiTietHoatDongBLL
    {
        ListChiTietHoatDong dsChiTietHoatDong = new ListChiTietHoatDong();

        public List<ChiTietHoatDong> Load()
        {
            return dsChiTietHoatDong.Load();
        }
    }
}
