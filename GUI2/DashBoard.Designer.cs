
namespace GUI2
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.udateStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regisCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editSubjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lookUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookUpStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.regisCourseToolStripMenuItem,
            this.lookUpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(996, 57);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsToolStripMenuItem,
            this.addActivityToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
            this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(136, 53);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem1,
            this.deleteStudentToolStripMenuItem1,
            this.udateStudentToolStripMenuItem1});
            this.viewStudentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStudentsToolStripMenuItem.Image")));
            this.viewStudentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(201, 38);
            this.viewStudentsToolStripMenuItem.Text = "Edit Student";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem1
            // 
            this.addStudentToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStripMenuItem1.Image")));
            this.addStudentToolStripMenuItem1.Name = "addStudentToolStripMenuItem1";
            this.addStudentToolStripMenuItem1.Size = new System.Drawing.Size(207, 30);
            this.addStudentToolStripMenuItem1.Text = "Add Student";
            // 
            // deleteStudentToolStripMenuItem1
            // 
            this.deleteStudentToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteStudentToolStripMenuItem1.Image")));
            this.deleteStudentToolStripMenuItem1.Name = "deleteStudentToolStripMenuItem1";
            this.deleteStudentToolStripMenuItem1.Size = new System.Drawing.Size(207, 30);
            this.deleteStudentToolStripMenuItem1.Text = "Delete Student";
            // 
            // udateStudentToolStripMenuItem1
            // 
            this.udateStudentToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("udateStudentToolStripMenuItem1.Image")));
            this.udateStudentToolStripMenuItem1.Name = "udateStudentToolStripMenuItem1";
            this.udateStudentToolStripMenuItem1.Size = new System.Drawing.Size(207, 30);
            this.udateStudentToolStripMenuItem1.Text = "Udate Student";
            // 
            // addActivityToolStripMenuItem
            // 
            this.addActivityToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addActivityToolStripMenuItem.Image")));
            this.addActivityToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addActivityToolStripMenuItem.Name = "addActivityToolStripMenuItem";
            this.addActivityToolStripMenuItem.Size = new System.Drawing.Size(201, 38);
            this.addActivityToolStripMenuItem.Text = "Add Activity";
            this.addActivityToolStripMenuItem.Click += new System.EventHandler(this.addActivityToolStripMenuItem_Click);
            // 
            // regisCourseToolStripMenuItem
            // 
            this.regisCourseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSubjectToolStripMenuItem});
            this.regisCourseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regisCourseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regisCourseToolStripMenuItem.Image")));
            this.regisCourseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.regisCourseToolStripMenuItem.Name = "regisCourseToolStripMenuItem";
            this.regisCourseToolStripMenuItem.Size = new System.Drawing.Size(172, 53);
            this.regisCourseToolStripMenuItem.Text = "Regis Course";
            this.regisCourseToolStripMenuItem.Click += new System.EventHandler(this.regisCourseToolStripMenuItem_Click);
            // 
            // addSubjectToolStripMenuItem
            // 
            this.addSubjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSubjectToolStripMenuItem1,
            this.editSubjectToolStripMenuItem1});
            this.addSubjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addSubjectToolStripMenuItem.Image")));
            this.addSubjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addSubjectToolStripMenuItem.Name = "addSubjectToolStripMenuItem";
            this.addSubjectToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.addSubjectToolStripMenuItem.Text = "Subject";
            // 
            // addSubjectToolStripMenuItem1
            // 
            this.addSubjectToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addSubjectToolStripMenuItem1.Image")));
            this.addSubjectToolStripMenuItem1.Name = "addSubjectToolStripMenuItem1";
            this.addSubjectToolStripMenuItem1.Size = new System.Drawing.Size(189, 30);
            this.addSubjectToolStripMenuItem1.Text = "Add Subject";
            this.addSubjectToolStripMenuItem1.Click += new System.EventHandler(this.addSubjectToolStripMenuItem1_Click);
            // 
            // editSubjectToolStripMenuItem1
            // 
            this.editSubjectToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editSubjectToolStripMenuItem1.Image")));
            this.editSubjectToolStripMenuItem1.Name = "editSubjectToolStripMenuItem1";
            this.editSubjectToolStripMenuItem1.Size = new System.Drawing.Size(189, 30);
            this.editSubjectToolStripMenuItem1.Text = "Edit Subject";
            // 
            // lookUpToolStripMenuItem
            // 
            this.lookUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookUpStudentToolStripMenuItem});
            this.lookUpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lookUpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lookUpToolStripMenuItem.Image")));
            this.lookUpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lookUpToolStripMenuItem.Name = "lookUpToolStripMenuItem";
            this.lookUpToolStripMenuItem.Size = new System.Drawing.Size(141, 53);
            this.lookUpToolStripMenuItem.Text = "Look Up";
            // 
            // lookUpStudentToolStripMenuItem
            // 
            this.lookUpStudentToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lookUpStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInformationToolStripMenuItem,
            this.activityInformationToolStripMenuItem,
            this.listStudentsToolStripMenuItem});
            this.lookUpStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lookUpStudentToolStripMenuItem.Image")));
            this.lookUpStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lookUpStudentToolStripMenuItem.Name = "lookUpStudentToolStripMenuItem";
            this.lookUpStudentToolStripMenuItem.Size = new System.Drawing.Size(286, 56);
            this.lookUpStudentToolStripMenuItem.Text = "Student Information";
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personalInformationToolStripMenuItem.Image")));
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.personalInformationToolStripMenuItem.Text = "Personal information";
            // 
            // activityInformationToolStripMenuItem
            // 
            this.activityInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activityInformationToolStripMenuItem.Image")));
            this.activityInformationToolStripMenuItem.Name = "activityInformationToolStripMenuItem";
            this.activityInformationToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.activityInformationToolStripMenuItem.Text = "Activity Information";
            // 
            // listStudentsToolStripMenuItem
            // 
            this.listStudentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listStudentsToolStripMenuItem.Image")));
            this.listStudentsToolStripMenuItem.Name = "listStudentsToolStripMenuItem";
            this.listStudentsToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.listStudentsToolStripMenuItem.Text = "List Students";
            this.listStudentsToolStripMenuItem.Click += new System.EventHandler(this.listStudentsToolStripMenuItem_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(996, 556);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regisCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookUpStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem udateStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editSubjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listStudentsToolStripMenuItem;
    }
}