using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using DTO.Object;
using DAL.List_Object;

namespace BLL
{
    public class KhoaBLL
    {
        public List<Khoa> list_Khoa = new List<Khoa>();

        ListKhoa dsKhoa = new ListKhoa();

        public List<Khoa> Load()
        {
            return dsKhoa.Load();
        }
    }
}
