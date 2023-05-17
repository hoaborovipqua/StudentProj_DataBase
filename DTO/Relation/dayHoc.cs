using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DTO
{
    public class dayHoc
    {
        string maSV_maGV_maMH, tietHoc;
        PhongHoc phong_hoc = new PhongHoc();

        public dayHoc() { }
        public dayHoc(string maSV_maGV_maMH, string tietHoc, PhongHoc phong_hoc)
        {
            this.maSV_maGV_maMH = maSV_maGV_maMH;
            this.tietHoc = tietHoc;
            this.phong_hoc = phong_hoc;
        }

        public string MaSV_maGV_maMH { get => maSV_maGV_maMH; set => maSV_maGV_maMH = value; }
        public string TietHoc { get => tietHoc; set => tietHoc = value; }



        //public void DangKy_HP(string _pStudent_id, ListMonHoc CL_list_MH, ListSV CL_list_SV, ListGV CL_list_GV)
        //{
        //    SinhVien sv = CL_list_SV.tim_SV(_pStudent_id);
        //    if(sv != null)
        //    {
        //        string filePath = Path.Combine("../../../../", "fileinput", "input_listMonhoc.txt");
        //        CL_list_MH.nhap_list_MonHoc_FrFile(filePath);
        //        sv.xem_va_chon(CL_list_MH);
        //        CL_list_GV.XuatList_GV();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Khong ton tai sinh vien co ma la: {0} ", _pStudent_id);
        //    }
        //}

    }
}
