using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using DAL.List_Object;

namespace BLL
{
    public class NguoiBLL
    {
        ListNguoi dsNguoi = new ListNguoi();

        public List<Nguoi> Load()
        {
            return dsNguoi.Load();
        }

        // them mot nguoi moi 
    }
}
