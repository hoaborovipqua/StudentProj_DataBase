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
    public partial class InputStudentID_EditSub : Form
    {
        public InputStudentID_EditSub()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadALLData.Load_dsSinhVien();
            LoadALLData.inputStuID = textBoxStudentID_inputEdit.Text;
            if(SinhVienBLL.checkExitStuID(textBoxStudentID_inputEdit.Text, LoadALLData.dsSinhVien))
            {
                SubjectsRegistered_Student subjectsRegistered_Student = new SubjectsRegistered_Student();
                subjectsRegistered_Student.Show();
                // nhap vào mã môn học cần xóa 
                DeleteSubject deleteSubject = new DeleteSubject();
                deleteSubject.Show();
                
            }    
            else
            {
                MessageBox.Show("Student Id not Exist!");
            }
            
            
        }
    }
}
