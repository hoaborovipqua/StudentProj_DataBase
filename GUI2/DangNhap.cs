using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI2
{
    public partial class DangNhap : Form
    {
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public DangNhap()
        {
            InitializeComponent();
        }


        private void bt_Loggin_Click(object sender, EventArgs e)
        {
            taiKhoan.sTaiKhoan = txtTaiKhoan.Text;
            taiKhoan.sMatKhau = txtMatKhau.Text;

            string getuser = taiKhoanBLL.CheckLoggin(taiKhoan);

            // Trả lại kết quả nếu nghiệp vụ không đúng 
            switch(getuser)
            {
                case "required_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống!");
                    return;
                case "required_matkhau":
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                case "Tài Khoản hoặc mật khẩu không tồn tại!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }
            MessageBox.Show("Đăng nhập thành công!");
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }
    }
}
