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
    public class GiangVien_MonHocBLL
    {
        ListGiangVien_MonHoc dsGiangVien_MonHoc = new ListGiangVien_MonHoc();

        public List<GiangVien_MonHoc> Load()
        {
            return dsGiangVien_MonHoc.Load();
        }

        public static bool checkExitLecIDSubID(string pLecID, string pSubID, List<GiangVien_MonHoc> lsLecSub)
        {
            return lsLecSub.Any(x => x.MaGV_GVMH == pLecID && x.MaMH_GVMH == pSubID);
        }
    }
}
