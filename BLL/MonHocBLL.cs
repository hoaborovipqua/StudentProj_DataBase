using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using DTO.Object;
using DAL.List_Object;


namespace BLL
{
    public class MonHocBLL
    {
        ListMonHoc dsMonHoc = new ListMonHoc();

        public List<MonHoc> Load()
        {
            return dsMonHoc.Load();
        }
    }
}
