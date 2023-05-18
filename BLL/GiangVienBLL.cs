using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using DTO.Object;
using DAL.List_Object;

namespace BLL
{
    public class GiangVienBLL
    {
        ListGV dsGiangVien = new ListGV();

        public List<GiangVien> Load()
        {
            return dsGiangVien.Load();
        }
    }
}
