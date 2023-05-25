using System;
using System.Collections.Generic;
using System.Text;
using DAL.List_Object;
using DTO.Object;

namespace BLL
{
    public class LopHocBLL
    {
        ListLop dsLop = new ListLop();

        public List<Lop> Load()
        {
            return dsLop.Load();
        }

        public static bool CheckClassIDExist(string pclassID)
        {
            ListLop listLop = new ListLop();
            List<Lop> lops = listLop.Load();

            return lops.Exists(x => x.MaLop1 == pclassID);
        }
    }
}
