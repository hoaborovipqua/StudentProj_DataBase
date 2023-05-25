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
    public partial class AddActivityForm : Form
    {
        public AddActivityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(ChiTietHoatDongBLL.AddActivityDetail(txtStuID.Text, txtSemesID.Text, txtActivID.Text))
            {
                MessageBox.Show("Add Successfully!");
            }
            else
            {
                MessageBox.Show("Add Failure!");
            }

        }

        private void AddActivityForm_Load(object sender, EventArgs e)
        {

        }
    }
}
