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
    public class HocKyBLL
    {
        ListHocKy dsHocKy = new ListHocKy();

        public List<HocKy> Load()
        {
            return dsHocKy.Load();
        }

        public static bool CheckSemesterID(string psemesterID)
        {
            ListHocKy listHocKy = new ListHocKy();
            List<HocKy> hocKies = listHocKy.Load();
            return hocKies.Exists(x => x.MaHK1 == psemesterID);
        }
    }
}
