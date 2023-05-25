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

        private void addActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // gọi luôn bảng hoạt động 
            ShowActivities showActivities = new ShowActivities();
            showActivities.Show();
            AddActivityForm addActivity = new AddActivityForm();
            addActivity.Show();
        }

        private void addSubjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegisterCourseForm register = new RegisterCourseForm();
            register.Show();
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStudentID_RegisSub inputStudentID = new InputStudentID_RegisSub();
            inputStudentID.Show();
        }

        private void editSubjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputStudentID_EditSub inputStudentID_EditSub = new InputStudentID_EditSub();
            inputStudentID_EditSub.Show();
        }

        private void addStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void activityInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Avtivities student_Avtivities = new Student_Avtivities();
            student_Avtivities.Show();
        }
    }
}
