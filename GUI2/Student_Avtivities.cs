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
    public partial class Student_Avtivities : Form
    {
        public Student_Avtivities()
        {
            InitializeComponent();
            LoadALLData.inputStuID = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadALLData.Load_dsSinhVien();
            if(SinhVienBLL.checkExitStuID(textInputStudentID.Text, LoadALLData.dsSinhVien))
            {
                LoadALLData.inputStuID = textInputStudentID.Text;
                dataGridView1.DataSource = ChiTietHoatDongBLL.GetListStudentActivities(LoadALLData.inputStuID);
                dataGridView1.Columns["MaSV_CTHD1"].HeaderText = "StudentID";
                dataGridView1.Columns["MaHK_CTHD1"].HeaderText = "SemesterID";
                dataGridView1.Columns["MaHD_CTHD1"].HeaderText = "ActivityID";
            }
            else
            {
                MessageBox.Show("Student Id not Exist!");
            }
            
        }

        private void Student_Avtivities_Load(object sender, EventArgs e)
        {

        }
    }
}
