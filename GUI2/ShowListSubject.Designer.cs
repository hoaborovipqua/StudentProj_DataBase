
namespace GUI2
{
    partial class ShowListSubject
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
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.But_SelectSubj = new System.Windows.Forms.Button();
            this.but_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Location = new System.Drawing.Point(125, 44);
            this.dataGridViewSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.RowHeadersWidth = 51;
            this.dataGridViewSubject.RowTemplate.Height = 29;
            this.dataGridViewSubject.Size = new System.Drawing.Size(539, 213);
            this.dataGridViewSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subjects:";
            // 
            // But_SelectSubj
            // 
            this.But_SelectSubj.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.But_SelectSubj.Location = new System.Drawing.Point(190, 283);
            this.But_SelectSubj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.But_SelectSubj.Name = "But_SelectSubj";
            this.But_SelectSubj.Size = new System.Drawing.Size(116, 33);
            this.But_SelectSubj.TabIndex = 2;
            this.But_SelectSubj.Text = "SelectSubject";
            this.But_SelectSubj.UseVisualStyleBackColor = true;
            this.But_SelectSubj.Click += new System.EventHandler(this.But_SelectSubj_Click);
            // 
            // but_Exit
            // 
            this.but_Exit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but_Exit.Location = new System.Drawing.Point(418, 283);
            this.but_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(82, 33);
            this.but_Exit.TabIndex = 3;
            this.but_Exit.Text = "Exit";
            this.but_Exit.UseVisualStyleBackColor = true;
            this.but_Exit.Click += new System.EventHandler(this.but_Exit_Click);
            // 
            // ShowListSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.but_Exit);
            this.Controls.Add(this.But_SelectSubj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSubject);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowListSubject";
            this.Text = "ListSubject";
            this.Load += new System.EventHandler(this.ShowListSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_SelectSubj;
        private System.Windows.Forms.Button but_Exit;
    }
}