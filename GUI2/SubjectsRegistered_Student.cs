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
    public partial class SubjectsRegistered_Student : Form
    {
        public SubjectsRegistered_Student()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SubjectsRegistered_Student_Load(object sender, EventArgs e)
        {
            dataGridViewSubjectRegistered.DataSource = ChiTietDangKiMonHocBLL.getListSubjectRegiteredDetail(LoadALLData.inputStuID);

            LoadALLData.Load_MonHoc();
            LoadALLData.Load_dsGiangVien();
            LoadALLData.Load_dsNguoi();

            

            // Tạo một cột mới trong DataGridView để hiển thị thông tin 
            DataGridViewTextBoxColumn regisID = new DataGridViewTextBoxColumn();
            regisID.Name = "regisID";
            regisID.HeaderText = "RegisID";
            regisID.DataPropertyName = "regisID";

            dataGridViewSubjectRegistered.Columns.Add(regisID);

            foreach (DataGridViewRow row in dataGridViewSubjectRegistered.Rows)
            {
                string t = row.Cells["MaGV_CTDKMH"].Value.ToString() + row.Cells["MaMH_CTDKMH"].Value.ToString();
                row.Cells["regisID"].Value = t;
            }

            //thêm cột Tên giảng viên  
            DataGridViewTextBoxColumn lecname = new DataGridViewTextBoxColumn();
            lecname.Name = "lecName";
            lecname.HeaderText = "LectureName";
            lecname.DataPropertyName = "lecName";

            dataGridViewSubjectRegistered.Columns.Add(lecname);

            // đi kiểm tra rồi gán từng giá trị vào :(( 
            foreach (DataGridViewRow row in dataGridViewSubjectRegistered.Rows)
            {
                string maGV_ctdkmh = row.Cells["MaGV_CTDKMH"].Value.ToString();
                string maDD_gv = LoadALLData.dsGiangVien.FirstOrDefault(s => s.MaGV1 == maGV_ctdkmh)?.MaDD_GV1;
                string ten_gv = LoadALLData.dsNguoi.FirstOrDefault(s => s.MaDD1 == maDD_gv)?.HoTen1;
                row.Cells["lecName"].Value = ten_gv;
            }

            //thêm cột Tên Môn học
            DataGridViewTextBoxColumn subname = new DataGridViewTextBoxColumn();
            subname.Name = "subName";
            subname.HeaderText = "SubjectName";
            subname.DataPropertyName = "subName";

            dataGridViewSubjectRegistered.Columns.Add(subname);

            // đi kiểm tra rồi gán từng giá trị vào :(( 
            foreach (DataGridViewRow row in dataGridViewSubjectRegistered.Rows)
            {
                string maMH_ctdkmh = row.Cells["MaMH_CTDKMH"].Value.ToString();
                string tenMH_mh = LoadALLData.dsMonHoc.FirstOrDefault(s => s.MaMH1 == maMH_ctdkmh)?.TenMonHoc1;

                row.Cells["subName"].Value = tenMH_mh;
            }


            // ẩn các cột 
            dataGridViewSubjectRegistered.Columns["MaGV_CTDKMH"].Visible = false;
            dataGridViewSubjectRegistered.Columns["MaMH_CTDKMH"].Visible = false;
            dataGridViewSubjectRegistered.Columns["MaSV_CTDKMH"].Visible = false;

            dataGridViewSubjectRegistered.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubjectRegistered.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
