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
    public partial class TrainingPointsInformation : Form
    {
        public TrainingPointsInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lấy cái mã hoc ky xuong tra voi cai ma sv 

            var result = SinhVien_DiemRL_BLL.GetTrainingPoint(LoadALLData.inputStuID, textBoxSemesterID.Text);
            if(result == ("", "", 0))
            {
                MessageBox.Show("Semester Id is not Exist!");
            }
            else
            {
                textBoxDisplayStuID.Text = LoadALLData.inputStuID;
                textBoxDisplayStuName.Text = result.Item1;
                textBoxDisplaySemester.Text = result.Item2;
                textBoxDisplayTrainingPoint.Text = result.Item3.ToString();
            }

        }
    }
}
