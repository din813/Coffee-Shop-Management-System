namespace Coffee_Shop_Management_System
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Button();
            this.salesman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome To Browny Cafe";
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(103, 341);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(75, 23);
            this.admin.TabIndex = 3;
            this.admin.Text = "ADMIN";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // salesman
            // 
            this.salesman.Location = new System.Drawing.Point(652, 340);
            this.salesman.Name = "salesman";
            this.salesman.Size = new System.Drawing.Size(75, 23);
            this.salesman.TabIndex = 4;
            this.salesman.Text = "SALESMAN";
            this.salesman.UseVisualStyleBackColor = true;
            this.salesman.Click += new System.EventHandler(this.salesman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salesman);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Welcome Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button salesman;
    }
}

