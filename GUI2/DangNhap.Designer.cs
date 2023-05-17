
namespace GUI2
{
    public partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.lb_acc = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.bt_loggin = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_acc
            // 
            this.lb_acc.AutoSize = true;
            this.lb_acc.Location = new System.Drawing.Point(76, 56);
            this.lb_acc.Name = "lb_acc";
            this.lb_acc.Size = new System.Drawing.Size(93, 23);
            this.lb_acc.TabIndex = 0;
            this.lb_acc.Text = "Tài Khoản:";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(77, 112);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(92, 23);
            this.lb_pass.TabIndex = 1;
            this.lb_pass.Text = "Mật Khẩu:";
            // 
            // bt_loggin
            // 
            this.bt_loggin.Location = new System.Drawing.Point(187, 152);
            this.bt_loggin.Name = "bt_loggin";
            this.bt_loggin.Size = new System.Drawing.Size(136, 37);
            this.bt_loggin.TabIndex = 2;
            this.bt_loggin.Text = "Đăng Nhập";
            this.bt_loggin.UseVisualStyleBackColor = true;
            this.bt_loggin.Click += new System.EventHandler(this.bt_Loggin_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(329, 152);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(94, 37);
            this.bt_Exit.TabIndex = 3;
            this.bt_Exit.Text = "Thoát";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(187, 56);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(236, 30);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(187, 105);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(236, 30);
            this.txtMatKhau.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.bt_Exit);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.bt_loggin);
            this.groupBox1.Controls.Add(this.lb_acc);
            this.groupBox1.Controls.Add(this.lb_pass);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(308, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 241);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(188, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng nhập hệ thống quản lý sinh viên";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DangNhap";
            this.Text = "5";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_acc;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Button bt_loggin;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}