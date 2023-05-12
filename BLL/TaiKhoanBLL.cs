using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();

        // 
        public string CheckLoggin(TaiKhoan taiKhoan)
        {
            // kiểm tra nghiệp vụ 
            if(taiKhoan.sTaiKhoan == "")
            {
                return "required_taikhoan";
            }

            if (taiKhoan.sMatKhau == "")
            {
                return "required_matkhau";
            }

            string info = tkAccess.CheckLoggin(taiKhoan);

            return info;
        }

    }
}
