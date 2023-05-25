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
using System.Linq;

namespace GUI2
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butAddClass_Click(object sender, EventArgs e)
        {
            LoadALLData.Load_dsSinhVien();
            if(SinhVienBLL.checkExitStuID(textStuID.Text, LoadALLData.dsSinhVien) && LopHocBLL.CheckClassIDExist(textClassID.Text))
            {
                // them ma lop vao cho sinh vien 
                if(!SinhVienBLL.AddClassIDToStudent(textStuID.Text, textClassID.Text))
                {
                    MessageBox.Show("Add Failure!");
                }
                else
                {
                    MessageBox.Show("Add Successfully!");
                }
            }
            else
            {
                MessageBox.Show("Student Id or Class Id Not Exist!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewListClass viewListClass = new ViewListClass();
            viewListClass.Show();
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            // lấy hết các thông tin cơ bản ra 
            // ten, gioi tinh, nam sinh 

            // đẩy xuống cơ sở dữ liệu 
            
            if(SinhVienBLL.addNewStudent(texFullName.Text, textGender.Text, int.Parse(textYearOfBirth.Text)))
            {
                LoadALLData.Load_dsSinhVien();
                textNewStuID.Text = LoadALLData.dsSinhVien.Max(x => x.MaSV1);
                textStuID.Text = textNewStuID.Text;
            }
            else
            {
                MessageBox.Show("Add Failure!");
            }

            // tính tiếp 

        }
    }
}
