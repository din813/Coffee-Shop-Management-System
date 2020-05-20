namespace Coffee_Shop_Management_System
{
    partial class Register_Form
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
            this.fname = new System.Windows.Forms.Label();
            this.lblphonereg = new System.Windows.Forms.Label();
            this.lblmailreg = new System.Windows.Forms.Label();
            this.lblpassreg = new System.Windows.Forms.Label();
            this.lblcpassreg = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.clicklog = new System.Windows.Forms.Button();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtphonereg = new System.Windows.Forms.TextBox();
            this.txtpassreg = new System.Windows.Forms.TextBox();
            this.txtcpassreg = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.txtmailreg = new System.Windows.Forms.TextBox();
            this.lbladdressreg = new System.Windows.Forms.Label();
            this.txtaddressreg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER FORM";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(226, 56);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(66, 13);
            this.fname.TabIndex = 1;
            this.fname.Text = "First Name : ";
            // 
            // lblphonereg
            // 
            this.lblphonereg.AutoSize = true;
            this.lblphonereg.Location = new System.Drawing.Point(226, 127);
            this.lblphonereg.Name = "lblphonereg";
            this.lblphonereg.Size = new System.Drawing.Size(84, 13);
            this.lblphonereg.TabIndex = 2;
            this.lblphonereg.Text = "Phone Number :";
            // 
            // lblmailreg
            // 
            this.lblmailreg.AutoSize = true;
            this.lblmailreg.Location = new System.Drawing.Point(226, 162);
            this.lblmailreg.Name = "lblmailreg";
            this.lblmailreg.Size = new System.Drawing.Size(42, 13);
            this.lblmailreg.TabIndex = 3;
            this.lblmailreg.Text = "E-Mail :";
            // 
            // lblpassreg
            // 
            this.lblpassreg.AutoSize = true;
            this.lblpassreg.Location = new System.Drawing.Point(226, 201);
            this.lblpassreg.Name = "lblpassreg";
            this.lblpassreg.Size = new System.Drawing.Size(59, 13);
            this.lblpassreg.TabIndex = 4;
            this.lblpassreg.Text = "Password :";
            // 
            // lblcpassreg
            // 
            this.lblcpassreg.AutoSize = true;
            this.lblcpassreg.Location = new System.Drawing.Point(226, 236);
            this.lblcpassreg.Name = "lblcpassreg";
            this.lblcpassreg.Size = new System.Drawing.Size(97, 13);
            this.lblcpassreg.TabIndex = 5;
            this.lblcpassreg.Text = "Confirm Password :";
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(606, 191);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.register_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(697, 415);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // clicklog
            // 
            this.clicklog.Location = new System.Drawing.Point(293, 415);
            this.clicklog.Name = "clicklog";
            this.clicklog.Size = new System.Drawing.Size(199, 23);
            this.clicklog.TabIndex = 8;
            this.clicklog.Text = "Click here to Log In";
            this.clicklog.UseVisualStyleBackColor = true;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(332, 56);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(185, 20);
            this.txtfname.TabIndex = 9;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(332, 88);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(185, 20);
            this.txtlname.TabIndex = 10;
            // 
            // txtphonereg
            // 
            this.txtphonereg.Location = new System.Drawing.Point(331, 124);
            this.txtphonereg.Name = "txtphonereg";
            this.txtphonereg.Size = new System.Drawing.Size(186, 20);
            this.txtphonereg.TabIndex = 11;
            // 
            // txtpassreg
            // 
            this.txtpassreg.Location = new System.Drawing.Point(331, 198);
            this.txtpassreg.Name = "txtpassreg";
            this.txtpassreg.Size = new System.Drawing.Size(186, 20);
            this.txtpassreg.TabIndex = 12;
            // 
            // txtcpassreg
            // 
            this.txtcpassreg.Location = new System.Drawing.Point(331, 233);
            this.txtcpassreg.Name = "txtcpassreg";
            this.txtcpassreg.Size = new System.Drawing.Size(186, 20);
            this.txtcpassreg.TabIndex = 13;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(226, 91);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(67, 13);
            this.lname.TabIndex = 14;
            this.lname.Text = "Last Name : ";
            // 
            // txtmailreg
            // 
            this.txtmailreg.Location = new System.Drawing.Point(331, 162);
            this.txtmailreg.Name = "txtmailreg";
            this.txtmailreg.Size = new System.Drawing.Size(186, 20);
            this.txtmailreg.TabIndex = 15;
            // 
            // lbladdressreg
            // 
            this.lbladdressreg.AutoSize = true;
            this.lbladdressreg.Location = new System.Drawing.Point(226, 277);
            this.lbladdressreg.Name = "lbladdressreg";
            this.lbladdressreg.Size = new System.Drawing.Size(51, 13);
            this.lbladdressreg.TabIndex = 16;
            this.lbladdressreg.Text = "Address :";
            // 
            // txtaddressreg
            // 
            this.txtaddressreg.Location = new System.Drawing.Point(332, 270);
            this.txtaddressreg.Name = "txtaddressreg";
            this.txtaddressreg.Size = new System.Drawing.Size(186, 20);
            this.txtaddressreg.TabIndex = 17;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtaddressreg);
            this.Controls.Add(this.lbladdressreg);
            this.Controls.Add(this.txtmailreg);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.txtcpassreg);
            this.Controls.Add(this.txtpassreg);
            this.Controls.Add(this.txtphonereg);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.clicklog);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.lblcpassreg);
            this.Controls.Add(this.lblpassreg);
            this.Controls.Add(this.lblmailreg);
            this.Controls.Add(this.lblphonereg);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Name = "Register_Form";
            this.Text = "Register_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_Form_FormClosed);
            this.Load += new System.EventHandler(this.Register_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lblphonereg;
        private System.Windows.Forms.Label lblmailreg;
        private System.Windows.Forms.Label lblpassreg;
        private System.Windows.Forms.Label lblcpassreg;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button clicklog;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtphonereg;
        private System.Windows.Forms.TextBox txtpassreg;
        private System.Windows.Forms.TextBox txtcpassreg;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox txtmailreg;
        private System.Windows.Forms.Label lbladdressreg;
        private System.Windows.Forms.TextBox txtaddressreg;
    }
}