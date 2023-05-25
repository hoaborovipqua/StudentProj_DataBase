
namespace GUI2
{
    partial class InputSubject
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
            this.textBox_SubjectRegisID = new System.Windows.Forms.TextBox();
            this.but_Regis = new System.Windows.Forms.Button();
            this.but_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SubjectRegisID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_SubjectRegisID
            // 
            this.textBox_SubjectRegisID.Location = new System.Drawing.Point(236, 44);
            this.textBox_SubjectRegisID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SubjectRegisID.Name = "textBox_SubjectRegisID";
            this.textBox_SubjectRegisID.Size = new System.Drawing.Size(238, 23);
            this.textBox_SubjectRegisID.TabIndex = 1;
            // 
            // but_Regis
            // 
            this.but_Regis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but_Regis.Location = new System.Drawing.Point(236, 125);
            this.but_Regis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Regis.Name = "but_Regis";
            this.but_Regis.Size = new System.Drawing.Size(82, 33);
            this.but_Regis.TabIndex = 2;
            this.but_Regis.Text = "Register";
            this.but_Regis.UseVisualStyleBackColor = true;
            this.but_Regis.Click += new System.EventHandler(this.but_Regis_Click);
            // 
            // but_Exit
            // 
            this.but_Exit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but_Exit.Location = new System.Drawing.Point(392, 125);
            this.but_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(82, 33);
            this.but_Exit.TabIndex = 3;
            this.but_Exit.Text = "Exit";
            this.but_Exit.UseVisualStyleBackColor = true;
            this.but_Exit.Click += new System.EventHandler(this.but_Exit_Click);
            // 
            // InputSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 219);
            this.Controls.Add(this.but_Exit);
            this.Controls.Add(this.but_Regis);
            this.Controls.Add(this.textBox_SubjectRegisID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputSubject";
            this.Text = "InputSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SubjectRegisID;
        private System.Windows.Forms.Button but_Regis;
        private System.Windows.Forms.Button but_Exit;
    }
}