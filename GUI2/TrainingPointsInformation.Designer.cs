
namespace GUI2
{
    partial class TrainingPointsInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSemesterID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDisplayTrainingPoint = new System.Windows.Forms.TextBox();
            this.textBoxDisplaySemester = new System.Windows.Forms.TextBox();
            this.textBoxDisplayStuName = new System.Windows.Forms.TextBox();
            this.textBoxDisplayStuID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semester ID: ";
            // 
            // textBoxSemesterID
            // 
            this.textBoxSemesterID.Location = new System.Drawing.Point(353, 48);
            this.textBoxSemesterID.Name = "textBoxSemesterID";
            this.textBoxSemesterID.Size = new System.Drawing.Size(284, 27);
            this.textBoxSemesterID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDisplayTrainingPoint);
            this.groupBox1.Controls.Add(this.textBoxDisplaySemester);
            this.groupBox1.Controls.Add(this.textBoxDisplayStuName);
            this.groupBox1.Controls.Add(this.textBoxDisplayStuID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(103, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 394);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Point Information";
            // 
            // textBoxDisplayTrainingPoint
            // 
            this.textBoxDisplayTrainingPoint.Location = new System.Drawing.Point(280, 309);
            this.textBoxDisplayTrainingPoint.Name = "textBoxDisplayTrainingPoint";
            this.textBoxDisplayTrainingPoint.Size = new System.Drawing.Size(211, 30);
            this.textBoxDisplayTrainingPoint.TabIndex = 7;
            // 
            // textBoxDisplaySemester
            // 
            this.textBoxDisplaySemester.Location = new System.Drawing.Point(280, 222);
            this.textBoxDisplaySemester.Name = "textBoxDisplaySemester";
            this.textBoxDisplaySemester.Size = new System.Drawing.Size(211, 30);
            this.textBoxDisplaySemester.TabIndex = 6;
            // 
            // textBoxDisplayStuName
            // 
            this.textBoxDisplayStuName.Location = new System.Drawing.Point(280, 141);
            this.textBoxDisplayStuName.Name = "textBoxDisplayStuName";
            this.textBoxDisplayStuName.Size = new System.Drawing.Size(211, 30);
            this.textBoxDisplayStuName.TabIndex = 5;
            // 
            // textBoxDisplayStuID
            // 
            this.textBoxDisplayStuID.Location = new System.Drawing.Point(281, 59);
            this.textBoxDisplayStuID.Name = "textBoxDisplayStuID";
            this.textBoxDisplayStuID.Size = new System.Drawing.Size(210, 30);
            this.textBoxDisplayStuID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Training Point:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Semester: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student ID: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(438, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainingPointsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 698);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSemesterID);
            this.Controls.Add(this.label1);
            this.Name = "TrainingPointsInformation";
            this.Text = "TrainingPointsInformation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSemesterID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDisplayTrainingPoint;
        private System.Windows.Forms.TextBox textBoxDisplaySemester;
        private System.Windows.Forms.TextBox textBoxDisplayStuName;
        private System.Windows.Forms.TextBox textBoxDisplayStuID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}