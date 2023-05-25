using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI2
{
    public partial class ShowActivities : Form
    {
        public ShowActivities()
        {
            InitializeComponent();
        }

        private void ShowActivities_Load(object sender, EventArgs e)
        {
            LoadALLData.Load_HoatDong();
            dataGridView1.DataSource = LoadALLData.dsHoatDong;

            dataGridView1.Columns["MaHD1"].HeaderText = "ActivityID";
            dataGridView1.Columns["TenHD1"].HeaderText = "ActivityName";
            dataGridView1.Columns["DiemCong1"].HeaderText = "Bonus Point";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
