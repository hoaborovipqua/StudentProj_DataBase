using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;

namespace DAL
{
    public class TaiKhoanAccess:DatabaseAccess
    {
        public string CheckLoggin(TaiKhoan taiKhoan)
        {
            string info = CheckLogginDTO(taiKhoan);
            return info;
        }
    }
}
