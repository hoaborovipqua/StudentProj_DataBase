using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DTO.Object;

namespace GUI2
{
    public partial class RegisterCourseForm : Form
    {
        public RegisterCourseForm()
        {
            InitializeComponent();
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoadALLData.inputStuID = txtStdID.Text;
            LoadALLData.Load_dsSinhVien();
            if (SinhVienBLL.checkExitStuID(txtStdID.Text, LoadALLData.dsSinhVien))
            {
                ShowListSubject showListSubject = new ShowListSubject();
                showListSubject.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai mã số sinh viên");
            }
        }

        private void RegisterCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void txtStdID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
