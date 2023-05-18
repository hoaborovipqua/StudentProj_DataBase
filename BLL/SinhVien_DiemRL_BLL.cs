using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using DTO.Object;
using DAL.List_Object;

namespace BLL
{
    public class SinhVien_DiemRL_BLL
    {
        ListSinhVien_DiemRL_DiemRL dsSinhVien_DiemRL = new ListSinhVien_DiemRL_DiemRL();

        public List<SinhVien_DiemRL> Load()
        {
            return dsSinhVien_DiemRL.Load();
        }
    }
}
