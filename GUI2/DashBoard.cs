using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI2
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regisCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void udateStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsGUI show = new ShowStudentsGUI();
            show.Show();

        }
    }
}
