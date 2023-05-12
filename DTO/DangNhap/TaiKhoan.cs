using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TaiKhoan
    {
        public string sMaTK { get; set; }
        public string sTaiKhoan { get; set; }
        public string sMatKhau { get; set; }
        public int FK_iMaQuyen { get; set; }
    }
}
