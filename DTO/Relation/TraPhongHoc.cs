using System;
using System.Collections.Generic;
using System.Text;


// phuc vu cho viec tra cuu sinh vien tu phong hoc 
namespace DTO
{
    public class TraPhongHoc
    {
        // maph_mamh la khoa chinh
        string MaPH_MaMH, tietHoc;

        public TraPhongHoc(string maPH_MaMH, string tietHoc)
        {
            MaPH_MaMH = maPH_MaMH;
            this.tietHoc = tietHoc;
        }

        public TraPhongHoc() { }

        public string MaPH_MaMH1 { get => MaPH_MaMH; set => MaPH_MaMH = value; }
        public string TietHoc { get => tietHoc; set => tietHoc = value; }
    }
}
