namespace Coffee_Shop_Management_System
{
    partial class SignIn_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.buttonsign = new System.Windows.Forms.Button();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.labelpass = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelsignin = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.buttonsign);
            this.panel1.Controls.Add(this.txtmail);
            this.panel1.Controls.Add(this.labelpass);
            this.panel1.Controls.Add(this.labelemail);
            this.panel1.Controls.Add(this.labelsignin);
            this.panel1.Location = new System.Drawing.Point(115, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 370);
            this.panel1.TabIndex = 8;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(135, 133);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 6;
            // 
            // buttonsign
            // 
            this.buttonsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonsign.Location = new System.Drawing.Point(160, 194);
            this.buttonsign.Name = "buttonsign";
            this.buttonsign.Size = new System.Drawing.Size(75, 23);
            this.buttonsign.TabIndex = 5;
            this.buttonsign.Text = "SignIn";
            this.buttonsign.UseVisualStyleBackColor = true;
            this.buttonsign.Click += new System.EventHandler(this.buttonsign_Click);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(136, 87);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 3;
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.BackColor = System.Drawing.Color.Transparent;
            this.labelpass.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelpass.Location = new System.Drawing.Point(19, 133);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(99, 25);
            this.labelpass.TabIndex = 2;
            this.labelpass.Text = "Password";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.BackColor = System.Drawing.Color.Transparent;
            this.labelemail.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelemail.Location = new System.Drawing.Point(19, 87);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(61, 25);
            this.labelemail.TabIndex = 1;
            this.labelemail.Text = "Email";
            // 
            // labelsignin
            // 
            this.labelsignin.AutoSize = true;
            this.labelsignin.BackColor = System.Drawing.Color.Transparent;
            this.labelsignin.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelsignin.Location = new System.Drawing.Point(130, 23);
            this.labelsignin.Name = "labelsignin";
            this.labelsignin.Size = new System.Drawing.Size(82, 38);
            this.labelsignin.TabIndex = 0;
            this.labelsignin.Text = "SignIn";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnexit.Location = new System.Drawing.Point(202, 334);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnback.Location = new System.Drawing.Point(24, 334);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // SignIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee_Shop_Management_System.Properties.Resources.registration1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SignIn_Form";
            this.Text = "SignIn_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignIn_Form_FormClosed);
            this.Load += new System.EventHandler(this.SignIn_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonsign;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelsignin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
    }
}