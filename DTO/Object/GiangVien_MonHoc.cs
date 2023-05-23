using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Object
{
    public class GiangVien_MonHoc
    {
        string maGV_GVMH, maMH_GVMH;

        public GiangVien_MonHoc(string maGV_GVMH, string maMH_GVMH)
        {
            this.maGV_GVMH = maGV_GVMH;
            this.maMH_GVMH = maMH_GVMH;
        }

        public GiangVien_MonHoc()
        {

        }

        public string MaGV_GVMH { get => maGV_GVMH; set => maGV_GVMH = value; }
        public string MaMH_GVMH { get => maMH_GVMH; set => maMH_GVMH = value; }
    }
}
