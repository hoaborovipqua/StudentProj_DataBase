using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI2
{
    public partial class ViewListFaculty : Form
    {
        public ViewListFaculty()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewListFaculty_Load(object sender, EventArgs e)
        {
            LoadALLData.Load_Khoa();
            dataGridView1.DataSource = LoadALLData.dsKhoa;

            dataGridView1.Columns["MaKhoa1"].HeaderText = "FacultyID";
            dataGridView1.Columns["TenKhoa1"].HeaderText = "FacultyName";
            dataGridView1.Columns["NamThanhLap1"].HeaderText = "FoundedYear";


        }
    }
}
