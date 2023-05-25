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

        public static bool AddSubjectRegisDetail(string pLecID, string pSubID, string pStuID)
        {

            return ListChiTietDangKiMonHoc.AddSubjectRegisDetail(pLecID, pSubID, pStuID);
        }

        public static List<ChiTietDangKiMonHoc> getListSubjectRegiteredDetail(string pstuID)
        {
            return ListChiTietDangKiMonHoc.getListSubjectRegiteredDetail(pstuID);
        }

        public static bool deleteSubjectRegistered(string psubRegisteredID, string pstuID)
        {
            // kiểm tra cã 3 mã có tồn tại không? 
            ListChiTietDangKiMonHoc listChiTietDangKiMonHoc = new ListChiTietDangKiMonHoc();
            List<ChiTietDangKiMonHoc> chiTietDangKiMonHocs = listChiTietDangKiMonHoc.Load();

            if(chiTietDangKiMonHocs.Exists(x => x.MaGV_CTDKMH == psubRegisteredID.Substring(0, 5) && x.MaMH_CTDKMH == psubRegisteredID.Substring(5, 5) && x.MaSV_CTDKMH == pstuID))
            {
                return ListChiTietDangKiMonHoc.DeleteSubjectRegisDetail(psubRegisteredID.Substring(0, 5), psubRegisteredID.Substring(5, 5), pstuID);
            }
            else
            {
                return false;
            }
        }
    }
}
