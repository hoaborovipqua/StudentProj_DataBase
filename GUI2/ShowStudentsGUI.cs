using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BLL;
using DTO.Object;

namespace GUI2
{
    public partial class ShowStudentsGUI : Form
    {
        public ShowStudentsGUI()
        {
            InitializeComponent();
        }

        private void ShowStudentsGUI_Load(object sender, EventArgs e)
        {
            LoadALLData.Load_dsLop();
            LoadALLData.Load_dsNguoi();
            LoadALLData.Load_dsSinhVien();
            LoadALLData.Load_Khoa();

            // Liên kết dữ liệu giữa DataGridView và danh sách đối tượng Sinh Viên 
            dataGridView1.DataSource = LoadALLData.dsSinhVien;


            // Tạo một cột mới trong DataGridView để hiển thị thông tin 
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "HoTen2";
            nameColumn.HeaderText = "Ho Ten";
            nameColumn.DataPropertyName = "MaDD1";

            dataGridView1.Columns.Add(nameColumn);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string maDD_sv = row.Cells["Sv_maDD"].Value.ToString();
                string hoTen_ng = LoadALLData.dsNguoi.FirstOrDefault(s => s.MaDD1 == maDD_sv)?.HoTen1;
                row.Cells["HoTen1"].Value = hoTen_ng;
            }

            //thêm cột giới tính 
            DataGridViewTextBoxColumn gender = new DataGridViewTextBoxColumn();
            gender.Name = "GioiTinh1";
            gender.HeaderText = "Giới Tính";
            gender.DataPropertyName = "GioiTinh1";

            dataGridView1.Columns.Add(gender);

            // đi kiểm tra rồi gán từng giá trị vào :(( 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string maDD_sv = row.Cells["Sv_maDD"].Value.ToString();
                string gioiTinh_ng = LoadALLData.dsNguoi.FirstOrDefault(s => s.MaDD1 == maDD_sv)?.GioiTinh1;
                row.Cells["GioiTinh1"].Value = gioiTinh_ng;
            }

            //thêm cột năm sinh 
            DataGridViewTextBoxColumn dob = new DataGridViewTextBoxColumn();
            dob.Name = "NamSinh1";
            dob.HeaderText = "Năm Sinh";
            dob.DataPropertyName = "NamSinh1";

            dataGridView1.Columns.Add(dob);

            // đi kiểm tra rồi gán từng giá trị vào :(( 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string maDD_sv = row.Cells["Sv_maDD"].Value.ToString();
                int? namSinh_ng = LoadALLData.dsNguoi.FirstOrDefault(s => s.MaDD1 == maDD_sv)?.NamSinh1;
                row.Cells["NamSinh1"].Value = namSinh_ng;
            }

            // thêm cột lớp 
            DataGridViewTextBoxColumn className = new DataGridViewTextBoxColumn();
            className.Name = "TenLop1";
            className.HeaderText = "Lớp";
            className.DataPropertyName = "MaLop1";

            dataGridView1.Columns.Add(className);

            // đi kiểm tra rồi gán từng giá trị vào :(( 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string maLop_sv = row.Cells["Sv_MaLop"].Value.ToString();
                string tenLop_Lop = LoadALLData.dsLop.FirstOrDefault(s => s.MaLop1 == maLop_sv)?.TenLop1;
                row.Cells["TenLop1"].Value = tenLop_Lop;
            }

            // thêm cột ten khoa
            DataGridViewTextBoxColumn falName = new DataGridViewTextBoxColumn();
            falName.Name = "TenKhoa2";
            falName.HeaderText = "Khoa";
            falName.DataPropertyName = "TenKhoa2";

            dataGridView1.Columns.Add(falName);

            // đi kiểm tra rồi gán từng giá trị vào :(( 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string maLop_SinhVien = row.Cells["Sv_MaLop"].Value.ToString();
                string maKhoa_Lop = LoadALLData.dsLop.FirstOrDefault(s => s.MaLop1 == maLop_SinhVien)?.MaKhoa1;

                
                string tenKhoa_Khoa = LoadALLData.dsKhoa.FirstOrDefault(s => s.MaKhoa1 == maKhoa_Lop)?.TenKhoa1;
                row.Cells["TenKhoa2"].Value = tenKhoa_Khoa;
            }


            // ẩn các cột 
            dataGridView1.Columns["Sv_maDD"].Visible = false;
            dataGridView1.Columns["Sv_MaLop"].Visible = false;
            dataGridView1.Columns["MaDD1"].Visible = false;
            dataGridView1.Columns["HoTen2"].Visible = false;
            dataGridView1.Columns["NamSinh1"].Visible = false;
            dataGridView1.Columns["GioiTinh1"].Visible = false;

            // Đổi tên các cột 
            dataGridView1.Columns["HoTen1"].HeaderText = "Họ Tên";
            dataGridView1.Columns["MaSV1"].HeaderText = "Ma SV";
            dataGridView1.Columns["GioiTinh1"].HeaderText = "Giới Tính";
            //dataGridView1.Columns["NamSinh2"].HeaderText = "Năm Sinh";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
