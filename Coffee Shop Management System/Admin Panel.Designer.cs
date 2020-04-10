namespace Coffee_Shop_Management_System
{
    partial class Admin_Panel
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
            this.salesman = new System.Windows.Forms.Button();
            this.waiter = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN PANEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // salesman
            // 
            this.salesman.Location = new System.Drawing.Point(107, 218);
            this.salesman.Name = "salesman";
            this.salesman.Size = new System.Drawing.Size(75, 23);
            this.salesman.TabIndex = 1;
            this.salesman.Text = "SALESMAN";
            this.salesman.UseVisualStyleBackColor = true;
            this.salesman.Click += new System.EventHandler(this.salesman_Click);
            // 
            // waiter
            // 
            this.waiter.Location = new System.Drawing.Point(610, 218);
            this.waiter.Name = "waiter";
            this.waiter.Size = new System.Drawing.Size(75, 23);
            this.waiter.TabIndex = 2;
            this.waiter.Text = "WAITER";
            this.waiter.UseVisualStyleBackColor = true;
            this.waiter.Click += new System.EventHandler(this.waiter_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(66, 369);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.waiter);
            this.Controls.Add(this.salesman);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Panel";
            this.Text = "Admin_Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salesman;
        private System.Windows.Forms.Button waiter;
        private System.Windows.Forms.Button back;
    }
}