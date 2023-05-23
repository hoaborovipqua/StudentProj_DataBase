using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string mssv = txtMSSV.Text;
            string maHD = txtMHD.Text;
            string maHK = txtMHK.Text;
        }

        private void AddActivityForm_Load(object sender, EventArgs e)
        {

        }
    }
}
