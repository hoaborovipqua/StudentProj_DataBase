using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
    public class SinhVienBLL
    {
        ListSV dsSV = new ListSV();

        public List<SinhVien> Load()
        {
            return dsSV.Load();
        }
    }
}
