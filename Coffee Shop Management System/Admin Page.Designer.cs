namespace Coffee_Shop_Management_System
{
    partial class Admin_Page
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
            this.adpanel = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnwaiter = new System.Windows.Forms.Button();
            this.btnsalesman = new System.Windows.Forms.Button();
            this.btnbilling = new System.Windows.Forms.Button();
            this.lbladmin = new System.Windows.Forms.Label();
            this.adpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adpanel
            // 
            this.adpanel.Controls.Add(this.btnexit);
            this.adpanel.Controls.Add(this.btnback);
            this.adpanel.Controls.Add(this.btnwaiter);
            this.adpanel.Controls.Add(this.btnsalesman);
            this.adpanel.Controls.Add(this.btnbilling);
            this.adpanel.Controls.Add(this.lbladmin);
            this.adpanel.ForeColor = System.Drawing.Color.Crimson;
            this.adpanel.Location = new System.Drawing.Point(488, 35);
            this.adpanel.Name = "adpanel";
            this.adpanel.Size = new System.Drawing.Size(287, 313);
            this.adpanel.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnexit.Location = new System.Drawing.Point(190, 272);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnback.Location = new System.Drawing.Point(14, 272);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnwaiter
            // 
            this.btnwaiter.BackColor = System.Drawing.Color.Transparent;
            this.btnwaiter.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwaiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnwaiter.Location = new System.Drawing.Point(40, 142);
            this.btnwaiter.Name = "btnwaiter";
            this.btnwaiter.Size = new System.Drawing.Size(205, 37);
            this.btnwaiter.TabIndex = 3;
            this.btnwaiter.Text = "Waiter Information";
            this.btnwaiter.UseVisualStyleBackColor = false;
            this.btnwaiter.Click += new System.EventHandler(this.btnwaiter_Click);
            // 
            // btnsalesman
            // 
            this.btnsalesman.BackColor = System.Drawing.Color.Transparent;
            this.btnsalesman.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsalesman.Location = new System.Drawing.Point(40, 87);
            this.btnsalesman.Name = "btnsalesman";
            this.btnsalesman.Size = new System.Drawing.Size(205, 36);
            this.btnsalesman.TabIndex = 2;
            this.btnsalesman.Text = "Salesman Information";
            this.btnsalesman.UseVisualStyleBackColor = false;
            this.btnsalesman.Click += new System.EventHandler(this.btnsalesman_Click);
            // 
            // btnbilling
            // 
            this.btnbilling.BackColor = System.Drawing.Color.Transparent;
            this.btnbilling.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbilling.Location = new System.Drawing.Point(31, 206);
            this.btnbilling.Name = "btnbilling";
            this.btnbilling.Size = new System.Drawing.Size(225, 39);
            this.btnbilling.TabIndex = 1;
            this.btnbilling.Text = "Menu and Billing System";
            this.btnbilling.UseVisualStyleBackColor = false;
            this.btnbilling.Click += new System.EventHandler(this.btnbilling_Click);
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.BackColor = System.Drawing.Color.Transparent;
            this.lbladmin.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lbladmin.Location = new System.Drawing.Point(89, 22);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(120, 26);
            this.lbladmin.TabIndex = 0;
            this.lbladmin.Text = "ADMIN PANEL";
            // 
            // Admin_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee_Shop_Management_System.Properties.Resources.admin_page2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adpanel);
            this.Name = "Admin_Page";
            this.Text = "Admin_Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Page_FormClosed_1);
            this.Load += new System.EventHandler(this.Admin_Page_Load);
            this.adpanel.ResumeLayout(false);
            this.adpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adpanel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnwaiter;
        private System.Windows.Forms.Button btnsalesman;
        private System.Windows.Forms.Button btnbilling;
        private System.Windows.Forms.Label lbladmin;
    }
}