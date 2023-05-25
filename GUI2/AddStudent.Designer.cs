
namespace GUI2
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSubmit = new System.Windows.Forms.Button();
            this.textYearOfBirth = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.TextBox();
            this.texFullName = new System.Windows.Forms.TextBox();
            this.textNewStuID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textClassID = new System.Windows.Forms.TextBox();
            this.butAddClass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textStuID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butSubmit);
            this.groupBox1.Controls.Add(this.textYearOfBirth);
            this.groupBox1.Controls.Add(this.textGender);
            this.groupBox1.Controls.Add(this.texFullName);
            this.groupBox1.Controls.Add(this.textNewStuID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(33, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Information";
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(260, 309);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(75, 35);
            this.butSubmit.TabIndex = 9;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // textYearOfBirth
            // 
            this.textYearOfBirth.Location = new System.Drawing.Point(260, 222);
            this.textYearOfBirth.Name = "textYearOfBirth";
            this.textYearOfBirth.Size = new System.Drawing.Size(199, 27);
            this.textYearOfBirth.TabIndex = 8;
            // 
            // textGender
            // 
            this.textGender.Location = new System.Drawing.Point(260, 134);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(199, 27);
            this.textGender.TabIndex = 7;
            // 
            // texFullName
            // 
            this.texFullName.Location = new System.Drawing.Point(260, 63);
            this.texFullName.Name = "texFullName";
            this.texFullName.Size = new System.Drawing.Size(199, 27);
            this.texFullName.TabIndex = 6;
            // 
            // textNewStuID
            // 
            this.textNewStuID.Location = new System.Drawing.Point(260, 403);
            this.textNewStuID.Name = "textNewStuID";
            this.textNewStuID.Size = new System.Drawing.Size(199, 27);
            this.textNewStuID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "New student id: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year Of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textStuID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textClassID);
            this.groupBox2.Controls.Add(this.butAddClass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(692, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 430);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Class ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "ViewListClass";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textClassID
            // 
            this.textClassID.Location = new System.Drawing.Point(215, 134);
            this.textClassID.Name = "textClassID";
            this.textClassID.Size = new System.Drawing.Size(297, 27);
            this.textClassID.TabIndex = 7;
            // 
            // butAddClass
            // 
            this.butAddClass.Location = new System.Drawing.Point(215, 317);
            this.butAddClass.Name = "butAddClass";
            this.butAddClass.Size = new System.Drawing.Size(88, 27);
            this.butAddClass.TabIndex = 3;
            this.butAddClass.Text = "Add";
            this.butAddClass.UseVisualStyleBackColor = true;
            this.butAddClass.Click += new System.EventHandler(this.butAddClass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Class ID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "StudentID: ";
            // 
            // textStuID
            // 
            this.textStuID.Location = new System.Drawing.Point(215, 56);
            this.textStuID.Name = "textStuID";
            this.textStuID.Size = new System.Drawing.Size(297, 27);
            this.textStuID.TabIndex = 10;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textYearOfBirth;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.TextBox texFullName;
        private System.Windows.Forms.TextBox textNewStuID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textClassID;
        private System.Windows.Forms.Button butAddClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.TextBox textStuID;
        private System.Windows.Forms.Label label6;
    }
}