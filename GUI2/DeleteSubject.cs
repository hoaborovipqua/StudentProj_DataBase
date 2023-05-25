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
    public partial class DeleteSubject : Form
    {
        public DeleteSubject()
        {
            InitializeComponent();
        }

        private void butDeleteSubject_Click(object sender, EventArgs e)
        {
            LoadALLData.subjectRegisteredID = textBoxSubRegisteredID.Text;
            // hàm kiểm tra sau đó thì xóa 
            if(ChiTietDangKiMonHocBLL.deleteSubjectRegistered(textBoxSubRegisteredID.Text, LoadALLData.inputStuID))
            {
                MessageBox.Show("Delete Successfully!");
            }
            else
            {
                MessageBox.Show("Delete Failure!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowListSubject showListSubject = new ShowListSubject();
            showListSubject.Show();
        }
    }
}
