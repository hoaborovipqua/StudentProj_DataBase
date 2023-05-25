using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BLL;
using DTO.Object;

namespace GUI2
{
    public partial class InputSubject : Form
    {
        public InputSubject()
        {
            InitializeComponent();
        }

        private void but_Regis_Click(object sender, EventArgs e)
        {
            // xử lý nghiệp vụ đăng kí 
            LoadALLData.Load_GiangVien_MonHoc();
            string tmp = textBox_SubjectRegisID.Text;
            string t1 = tmp.Substring(0, 5).ToString();
            string t2 = tmp.Substring(5, 5).ToString();
            if(GiangVien_MonHocBLL.checkExitLecIDSubID(t1, t2, LoadALLData.dsGiangVien_MonHoc))
            {
                // thêm vào bảng chi tiết đăng kí môn học 
                if( ChiTietDangKiMonHocBLL.AddSubjectRegisDetail(t1, t2, LoadALLData.inputStuID))
                {
                    MessageBox.Show("Add Successfully!");
                    // làm form hiển thị ds mon hoc da dk hoc vao csdl check truc tiep du lieu da thêm vào 
                }
                else
                {
                    MessageBox.Show("Add Failure!");
                }
            }
            else
            {
                MessageBox.Show("Subject Register ID not Exist!");
            }
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
