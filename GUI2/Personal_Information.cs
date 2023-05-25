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
    public partial class Personal_Information : Form
    {
        public Personal_Information()
        {
            InitializeComponent();
            
            var infor = SinhVienBLL.GetStudentInfor(LoadALLData.inputStuID);
            // ten , nam sinh, gioitinh, lop , khoa 
            textBoxStID.Text = LoadALLData.inputStuID;
            textBoxFullName.Text = infor.Item1;
            textBoxYOB.Text = infor.Item2.ToString();
            textBoxGender.Text = infor.Item3;
            textBoxClass.Text = infor.Item4;
            textBoxFaculty.Text = infor.Item5;

            textBoxFullName.ReadOnly = true;
            textBoxYOB.ReadOnly = true;
            textBoxGender.ReadOnly = true;
            textBoxClass.ReadOnly = true;
            textBoxFaculty.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubjectsRegistered_Student subjectsRegistered_Student = new SubjectsRegistered_Student();
            subjectsRegistered_Student.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrainingPointsInformation trainingPointsInformation = new TrainingPointsInformation();
            trainingPointsInformation.Show();
        }
    }
}
