namespace GUI2
{
    partial class AddActivityForm
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
            this.lbMssv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSemesID = new System.Windows.Forms.TextBox();
            this.txtActivID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMSSV1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMssv
            // 
            this.lbMssv.AutoSize = true;
            this.lbMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMssv.Location = new System.Drawing.Point(11, 11);
            this.lbMssv.Name = "lbMssv";
            this.lbMssv.Size = new System.Drawing.Size(0, 26);
            this.lbMssv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSemesID);
            this.groupBox1.Controls.Add(this.txtActivID);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtStuID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbMSSV1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(525, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enterring Information";
            // 
            // txtSemesID
            // 
            this.txtSemesID.Location = new System.Drawing.Point(160, 233);
            this.txtSemesID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSemesID.Name = "txtSemesID";
            this.txtSemesID.Size = new System.Drawing.Size(244, 32);
            this.txtSemesID.TabIndex = 6;
            // 
            // txtActivID
            // 
            this.txtActivID.Location = new System.Drawing.Point(161, 143);
            this.txtActivID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtActivID.Name = "txtActivID";
            this.txtActivID.Size = new System.Drawing.Size(244, 32);
            this.txtActivID.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(160, 317);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(245, 55);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Add Activity";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(161, 66);
            this.txtStuID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(244, 32);
            this.txtStuID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "SemesterID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ActivityID:";
            // 
            // lbMSSV1
            // 
            this.lbMSSV1.AutoSize = true;
            this.lbMSSV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMSSV1.Location = new System.Drawing.Point(6, 72);
            this.lbMSSV1.Name = "lbMSSV1";
            this.lbMSSV1.Size = new System.Drawing.Size(115, 26);
            this.lbMSSV1.TabIndex = 0;
            this.lbMSSV1.Text = "StudentID:";
            // 
            // AddActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMssv);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddActivityForm";
            this.Text = "Add Activity";
            this.Load += new System.EventHandler(this.AddActivityForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMssv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMSSV1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSemesID;
        private System.Windows.Forms.TextBox txtActivID;
        private System.Windows.Forms.TextBox txtStuID;
    }
}