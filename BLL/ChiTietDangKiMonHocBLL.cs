using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using DTO.Object;
using DAL.List_Object;

namespace BLL
{
    public class ChiTietDangKiMonHocBLL
    {
        ListChiTietDangKiMonHoc dsChiTietDangKiMonHoc = new ListChiTietDangKiMonHoc();

        public List<ChiTietDangKiMonHoc> Load()
        {
            return dsChiTietDangKiMonHoc.Load();
        }

        public static bool AddRegisSubjectDetail(string pLecID, string pSubID, string pStuID)
        {

            return true;
        }
    }
}
