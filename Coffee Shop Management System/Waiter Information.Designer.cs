namespace Coffee_Shop_Management_System
{
    partial class Waiter_Information
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
            this.gvwaiter = new System.Windows.Forms.DataGridView();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblwaddress = new System.Windows.Forms.Label();
            this.lblwdob = new System.Windows.Forms.Label();
            this.lblwgender = new System.Windows.Forms.Label();
            this.btnwreset = new System.Windows.Forms.Button();
            this.btnwupdate = new System.Windows.Forms.Button();
            this.btnwremove = new System.Windows.Forms.Button();
            this.btnwinsert = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblwphone = new System.Windows.Forms.Label();
            this.lblwname = new System.Windows.Forms.Label();
            this.lblwid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvwaiter)).BeginInit();
            this.SuspendLayout();
            // 
            // gvwaiter
            // 
            this.gvwaiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwaiter.Location = new System.Drawing.Point(33, 196);
            this.gvwaiter.Name = "gvwaiter";
            this.gvwaiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwaiter.Size = new System.Drawing.Size(632, 150);
            this.gvwaiter.TabIndex = 39;
            this.gvwaiter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvwaiter_CellClick);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(447, 131);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(200, 20);
            this.txtaddress.TabIndex = 38;
            // 
            // lblwaddress
            // 
            this.lblwaddress.AutoSize = true;
            this.lblwaddress.Location = new System.Drawing.Point(378, 131);
            this.lblwaddress.Name = "lblwaddress";
            this.lblwaddress.Size = new System.Drawing.Size(51, 13);
            this.lblwaddress.TabIndex = 35;
            this.lblwaddress.Text = "Address :";
            // 
            // lblwdob
            // 
            this.lblwdob.AutoSize = true;
            this.lblwdob.Location = new System.Drawing.Point(358, 97);
            this.lblwdob.Name = "lblwdob";
            this.lblwdob.Size = new System.Drawing.Size(74, 13);
            this.lblwdob.TabIndex = 34;
            this.lblwdob.Text = "Date Of Birth :";
            // 
            // lblwgender
            // 
            this.lblwgender.AutoSize = true;
            this.lblwgender.Location = new System.Drawing.Point(381, 68);
            this.lblwgender.Name = "lblwgender";
            this.lblwgender.Size = new System.Drawing.Size(48, 13);
            this.lblwgender.TabIndex = 33;
            this.lblwgender.Text = "Gender :";
            // 
            // btnwreset
            // 
            this.btnwreset.Location = new System.Drawing.Point(686, 209);
            this.btnwreset.Name = "btnwreset";
            this.btnwreset.Size = new System.Drawing.Size(75, 23);
            this.btnwreset.TabIndex = 32;
            this.btnwreset.Text = "Reset";
            this.btnwreset.UseVisualStyleBackColor = true;
            this.btnwreset.Click += new System.EventHandler(this.btnwreset_Click);
            // 
            // btnwupdate
            // 
            this.btnwupdate.Location = new System.Drawing.Point(686, 131);
            this.btnwupdate.Name = "btnwupdate";
            this.btnwupdate.Size = new System.Drawing.Size(75, 23);
            this.btnwupdate.TabIndex = 31;
            this.btnwupdate.Text = "Update";
            this.btnwupdate.UseVisualStyleBackColor = true;
            this.btnwupdate.Click += new System.EventHandler(this.btnwupdate_Click);
            // 
            // btnwremove
            // 
            this.btnwremove.Location = new System.Drawing.Point(686, 171);
            this.btnwremove.Name = "btnwremove";
            this.btnwremove.Size = new System.Drawing.Size(75, 23);
            this.btnwremove.TabIndex = 30;
            this.btnwremove.Text = "Remove";
            this.btnwremove.UseVisualStyleBackColor = true;
            this.btnwremove.Click += new System.EventHandler(this.btnwremove_Click);
            // 
            // btnwinsert
            // 
            this.btnwinsert.Location = new System.Drawing.Point(686, 99);
            this.btnwinsert.Name = "btnwinsert";
            this.btnwinsert.Size = new System.Drawing.Size(75, 23);
            this.btnwinsert.TabIndex = 29;
            this.btnwinsert.Text = "Insert";
            this.btnwinsert.UseVisualStyleBackColor = true;
            this.btnwinsert.Click += new System.EventHandler(this.btnwinsert_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 28;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(190, 131);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(142, 20);
            this.txtphone.TabIndex = 27;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(190, 99);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(142, 20);
            this.txtname.TabIndex = 26;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(190, 68);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(142, 20);
            this.txtid.TabIndex = 25;
            // 
            // lblwphone
            // 
            this.lblwphone.AutoSize = true;
            this.lblwphone.Location = new System.Drawing.Point(120, 131);
            this.lblwphone.Name = "lblwphone";
            this.lblwphone.Size = new System.Drawing.Size(64, 13);
            this.lblwphone.TabIndex = 24;
            this.lblwphone.Text = "Phone No : ";
            // 
            // lblwname
            // 
            this.lblwname.AutoSize = true;
            this.lblwname.Location = new System.Drawing.Point(120, 97);
            this.lblwname.Name = "lblwname";
            this.lblwname.Size = new System.Drawing.Size(41, 13);
            this.lblwname.TabIndex = 23;
            this.lblwname.Text = "Name :";
            // 
            // lblwid
            // 
            this.lblwid.AutoSize = true;
            this.lblwid.Location = new System.Drawing.Point(120, 68);
            this.lblwid.Name = "lblwid";
            this.lblwid.Size = new System.Drawing.Size(24, 13);
            this.lblwid.TabIndex = 22;
            this.lblwid.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "WAITER INFORMATION";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.CustomFormat = " ";
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(447, 97);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 40;
            this.dateTimePickerDOB.ValueChanged += new System.EventHandler(this.dateTimePickerDOB_ValueChanged);
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxgender.Location = new System.Drawing.Point(447, 68);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(200, 21);
            this.comboBoxgender.TabIndex = 41;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(713, 415);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 42;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Waiter_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.gvwaiter);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lblwaddress);
            this.Controls.Add(this.lblwdob);
            this.Controls.Add(this.lblwgender);
            this.Controls.Add(this.btnwreset);
            this.Controls.Add(this.btnwupdate);
            this.Controls.Add(this.btnwremove);
            this.Controls.Add(this.btnwinsert);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblwphone);
            this.Controls.Add(this.lblwname);
            this.Controls.Add(this.lblwid);
            this.Controls.Add(this.label1);
            this.Name = "Waiter_Information";
            this.Text = "Waiter_Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Waiter_Information_FormClosed);
            this.Load += new System.EventHandler(this.Waiter_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvwaiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvwaiter;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblwaddress;
        private System.Windows.Forms.Label lblwdob;
        private System.Windows.Forms.Label lblwgender;
        private System.Windows.Forms.Button btnwreset;
        private System.Windows.Forms.Button btnwupdate;
        private System.Windows.Forms.Button btnwremove;
        private System.Windows.Forms.Button btnwinsert;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblwphone;
        private System.Windows.Forms.Label lblwname;
        private System.Windows.Forms.Label lblwid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.Button btnexit;
    }
}