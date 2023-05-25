using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Linq;

namespace BLL
{
    public class SinhVienBLL
    {
        ListSV dsSV = new ListSV();

        public List<SinhVien> Load()
        {
            return dsSV.Load();
        }

        public static bool checkExitStuID(string pstuid, List<SinhVien> lsstu)
        {
            return lsstu.Any(x => x.MaSV1 == pstuid);
        }

        public static (string, int?, string, string, string) GetStudentInfor(string pstuID)
        {

            return ListSV.GetStudentInfor(pstuID);
        }

        public static bool addNewStudent(string pname, string pgen, int pyob)
        {
            if (pname.Length > 100 || (pgen != "Nam" && pgen != "Nữ") || (pyob < 1990 || pyob > 2010))
            {
                return false;
            }
            else
            {
                return ListSV.addNewStudent(pname, pgen, pyob);
            }
        }

        public static bool AddClassIDToStudent(string pstuID, string pclassID)
        {
            return ListSV.AddClassIDToStudent(pstuID,pclassID);
        }
    }
}
