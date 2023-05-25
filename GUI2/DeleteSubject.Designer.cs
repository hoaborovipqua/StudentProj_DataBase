
namespace GUI2
{
    partial class DeleteSubject
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
            this.textBoxSubRegisteredID = new System.Windows.Forms.TextBox();
            this.butDeleteSubject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.butAddNewSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SubjectRegisteredID:";
            // 
            // textBoxSubRegisteredID
            // 
            this.textBoxSubRegisteredID.Location = new System.Drawing.Point(300, 111);
            this.textBoxSubRegisteredID.Name = "textBoxSubRegisteredID";
            this.textBoxSubRegisteredID.Size = new System.Drawing.Size(268, 23);
            this.textBoxSubRegisteredID.TabIndex = 1;
            // 
            // butDeleteSubject
            // 
            this.butDeleteSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butDeleteSubject.Location = new System.Drawing.Point(300, 209);
            this.butDeleteSubject.Name = "butDeleteSubject";
            this.butDeleteSubject.Size = new System.Drawing.Size(91, 32);
            this.butDeleteSubject.TabIndex = 2;
            this.butDeleteSubject.Text = "Delete";
            this.butDeleteSubject.UseVisualStyleBackColor = true;
            this.butDeleteSubject.Click += new System.EventHandler(this.butDeleteSubject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delete Registered Subject";
            // 
            // butAddNewSubject
            // 
            this.butAddNewSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butAddNewSubject.Location = new System.Drawing.Point(421, 209);
            this.butAddNewSubject.Name = "butAddNewSubject";
            this.butAddNewSubject.Size = new System.Drawing.Size(147, 32);
            this.butAddNewSubject.TabIndex = 4;
            this.butAddNewSubject.Text = "AddNewSubject";
            this.butAddNewSubject.UseVisualStyleBackColor = true;
            this.butAddNewSubject.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 307);
            this.Controls.Add(this.butAddNewSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butDeleteSubject);
            this.Controls.Add(this.textBoxSubRegisteredID);
            this.Controls.Add(this.label1);
            this.Name = "DeleteSubject";
            this.Text = "DeleteSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSubRegisteredID;
        private System.Windows.Forms.Button butDeleteSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butAddNewSubject;
    }
}