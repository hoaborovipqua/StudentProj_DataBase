using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Object
{
    public class ChiTietDangKiMonHoc
    {
        string maGV_CTDKMH, maMH_CTDKMH, maSV_CTDKMH;

        public ChiTietDangKiMonHoc(string maGV_CTDKMH, string maMH_CTDKMH, string maSV_CTDKMH)
        {
            this.maGV_CTDKMH = maGV_CTDKMH;
            this.maMH_CTDKMH = maMH_CTDKMH;
            this.maSV_CTDKMH = maSV_CTDKMH;
        }
        public ChiTietDangKiMonHoc()
        {

        }

        public string MaGV_CTDKMH { get => maGV_CTDKMH; set => maGV_CTDKMH = value; }
        public string MaMH_CTDKMH { get => maMH_CTDKMH; set => maMH_CTDKMH = value; }
        public string MaSV_CTDKMH { get => maSV_CTDKMH; set => maSV_CTDKMH = value; }
    }
}
