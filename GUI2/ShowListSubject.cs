using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BLL;
using DTO.Object;

namespace GUI2
{
    public partial class ShowListSubject : Form
    {
        public ShowListSubject()
        {
            InitializeComponent();
        }

        private void ShowListSubject_Load(object sender, EventArgs e)
        {
            LoadALLData.Load_GiangVien_MonHoc();
            LoadALLData.Load_MonHoc();
            LoadALLData.Load_dsGiangVien();
            LoadALLData.Load_dsNguoi();

            dataGridViewSubject.DataSource = LoadALLData.dsGiangVien_MonHoc;

            // Tạo một cột mới trong DataGridView để hiển thị thông tin 
            DataGridViewTextBoxColumn regisID = new DataGridViewTextBoxColumn();
            regisID.Name = "regisID";
            regisID.HeaderText = "RegisID";
            regisID.DataPropertyName = "regisID";

            dataGridViewSubject.Columns.Add(regisID);

            foreach (DataGridViewRow row in dataGridViewSubject.Rows)
            {
                string t = row.Cells["MaGV_GVMH"].Value.ToString() + row.Cells["MaMH_GVMH"].Value.ToString();
                row.Cells["regisID"].Value = t;
            }

            //thêm cột Tên giảng viên  
            DataGridViewTextBoxColumn lecname = new DataGridViewTextBoxColumn();
            lecname.Name = "lecName";
            lecname.HeaderText = "LectureName";
            lecname.DataPropertyName = "lecName";

            dataGridViewSubject.Columns.Add(lecname);

            // đi kiểm tra rồi gán từng giá trị vào :(( 
            foreach (DataGridViewRow row in dataGridViewSubject.Rows)
            {
                string maGV_gvmh = row.Cells["MaGV_GVMH"].Value.ToString();
                string maDD_gv = LoadALLData.dsGiangVien.FirstOrDefault(s => s.MaGV1 == maGV_gvmh)?.MaDD_GV1;
                string ten_gv = LoadALLData.dsNguoi.FirstOrDefault(s => s.MaDD1 == maDD_gv)?.HoTen1;
                row.Cells["lecName"].Value = ten_gv;
            }

            //thêm cột Tên Môn học
            DataGridViewTextBoxColumn subname = new DataGridViewTextBoxColumn();
            subname.Name = "subName";
            subname.HeaderText = "SubjectName";
            subname.DataPropertyName = "subName";

            dataGridViewSubject.Columns.Add(subname);

            // đi kiểm tra rồi gán từng giá trị vào :(( 
            foreach (DataGridViewRow row in dataGridViewSubject.Rows)
            {
                string maMH_gvmh = row.Cells["MaMH_GVMH"].Value.ToString();
                string tenMH_mh = LoadALLData.dsMonHoc.FirstOrDefault(s => s.MaMH1 == maMH_gvmh)?.TenMonHoc1;
                
                row.Cells["subName"].Value = tenMH_mh;
            }


            // ẩn các cột 
            dataGridViewSubject.Columns["MaGV_GVMH"].Visible = false;
            dataGridViewSubject.Columns["MaMH_GVMH"].Visible = false;

            dataGridViewSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void But_SelectSubj_Click(object sender, EventArgs e)
        {
            InputSubject inputSubject = new InputSubject();
            inputSubject.Show();
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
