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
    public partial class InputStudentID_RegisSub : Form
    {
        public InputStudentID_RegisSub()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadALLData.inputStuID = txtStudentIDInput.Text;
            LoadALLData.Load_dsSinhVien();
            if (SinhVienBLL.checkExitStuID(txtStudentIDInput.Text, LoadALLData.dsSinhVien))
            {
                Personal_Information personal_Information = new Personal_Information();
                personal_Information.Show();
            }
            else
            {
                MessageBox.Show("Student ID Not Exist!");
            }
            
        }
    }
}
