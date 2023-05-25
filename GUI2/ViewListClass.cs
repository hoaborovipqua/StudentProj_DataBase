using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI2
{
    public partial class ViewListClass : Form
    {
        public ViewListClass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewListClass_Load(object sender, EventArgs e)
        {
            LoadALLData.Load_dsLop();
            dataGridView1.DataSource = LoadALLData.dsLop;
            dataGridView1.Columns["MaLop1"].HeaderText = "ClassID";
            dataGridView1.Columns["TenLop1"].HeaderText = "ClassName";
            dataGridView1.Columns["MaKhoa1"].HeaderText = "FacultyID";

            dataGridView1.Columns["SoThuTu1"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewListFaculty viewListFaculty = new ViewListFaculty();
            viewListFaculty.Show();
        }
    }
}
