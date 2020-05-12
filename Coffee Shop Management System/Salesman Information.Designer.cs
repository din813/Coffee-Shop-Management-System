namespace Coffee_Shop_Management_System
{
    partial class Salesman_Information
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
            this.lblsid = new System.Windows.Forms.Label();
            this.lblsphone = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.btnsinsert = new System.Windows.Forms.Button();
            this.btnsremove = new System.Windows.Forms.Button();
            this.btnsupdate = new System.Windows.Forms.Button();
            this.btnsreset = new System.Windows.Forms.Button();
            this.lblsname = new System.Windows.Forms.Label();
            this.lblsgender = new System.Windows.Forms.Label();
            this.lblsdob = new System.Windows.Forms.Label();
            this.lblsaddress = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.dateTimePickerdob = new System.Windows.Forms.DateTimePicker();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.gvsalesman = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvsalesman)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALESMAN INFORMATION";
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Location = new System.Drawing.Point(119, 59);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(24, 13);
            this.lblsid.TabIndex = 1;
            this.lblsid.Text = "ID :";
            // 
            // lblsphone
            // 
            this.lblsphone.AutoSize = true;
            this.lblsphone.Location = new System.Drawing.Point(119, 122);
            this.lblsphone.Name = "lblsphone";
            this.lblsphone.Size = new System.Drawing.Size(64, 13);
            this.lblsphone.TabIndex = 3;
            this.lblsphone.Text = "Phone No : ";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(189, 59);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(142, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(189, 90);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(142, 20);
            this.txtname.TabIndex = 5;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(189, 122);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(142, 20);
            this.txtphone.TabIndex = 6;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnsinsert
            // 
            this.btnsinsert.Location = new System.Drawing.Point(685, 90);
            this.btnsinsert.Name = "btnsinsert";
            this.btnsinsert.Size = new System.Drawing.Size(75, 23);
            this.btnsinsert.TabIndex = 9;
            this.btnsinsert.Text = "Insert";
            this.btnsinsert.UseVisualStyleBackColor = true;
            this.btnsinsert.Click += new System.EventHandler(this.btnsinsert_Click);
            // 
            // btnsremove
            // 
            this.btnsremove.Location = new System.Drawing.Point(685, 162);
            this.btnsremove.Name = "btnsremove";
            this.btnsremove.Size = new System.Drawing.Size(75, 23);
            this.btnsremove.TabIndex = 10;
            this.btnsremove.Text = "Remove";
            this.btnsremove.UseVisualStyleBackColor = true;
            this.btnsremove.Click += new System.EventHandler(this.btnsremove_Click);
            // 
            // btnsupdate
            // 
            this.btnsupdate.Location = new System.Drawing.Point(685, 122);
            this.btnsupdate.Name = "btnsupdate";
            this.btnsupdate.Size = new System.Drawing.Size(75, 23);
            this.btnsupdate.TabIndex = 11;
            this.btnsupdate.Text = "Update";
            this.btnsupdate.UseVisualStyleBackColor = true;
            this.btnsupdate.Click += new System.EventHandler(this.btnsupdate_Click);
            // 
            // btnsreset
            // 
            this.btnsreset.Location = new System.Drawing.Point(685, 200);
            this.btnsreset.Name = "btnsreset";
            this.btnsreset.Size = new System.Drawing.Size(75, 23);
            this.btnsreset.TabIndex = 12;
            this.btnsreset.Text = "Reset";
            this.btnsreset.UseVisualStyleBackColor = true;
            this.btnsreset.Click += new System.EventHandler(this.btnsreset_Click);
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.Location = new System.Drawing.Point(119, 88);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(41, 13);
            this.lblsname.TabIndex = 2;
            this.lblsname.Text = "Name :";
            // 
            // lblsgender
            // 
            this.lblsgender.AutoSize = true;
            this.lblsgender.Location = new System.Drawing.Point(380, 59);
            this.lblsgender.Name = "lblsgender";
            this.lblsgender.Size = new System.Drawing.Size(48, 13);
            this.lblsgender.TabIndex = 13;
            this.lblsgender.Text = "Gender :";
            // 
            // lblsdob
            // 
            this.lblsdob.AutoSize = true;
            this.lblsdob.Location = new System.Drawing.Point(357, 88);
            this.lblsdob.Name = "lblsdob";
            this.lblsdob.Size = new System.Drawing.Size(74, 13);
            this.lblsdob.TabIndex = 14;
            this.lblsdob.Text = "Date Of Birth :";
            // 
            // lblsaddress
            // 
            this.lblsaddress.AutoSize = true;
            this.lblsaddress.Location = new System.Drawing.Point(377, 122);
            this.lblsaddress.Name = "lblsaddress";
            this.lblsaddress.Size = new System.Drawing.Size(51, 13);
            this.lblsaddress.TabIndex = 16;
            this.lblsaddress.Text = "Address :";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(437, 122);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(200, 20);
            this.txtaddress.TabIndex = 19;
            // 
            // dateTimePickerdob
            // 
            this.dateTimePickerdob.CustomFormat = " ";
            this.dateTimePickerdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerdob.Location = new System.Drawing.Point(437, 87);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerdob.TabIndex = 21;
            this.dateTimePickerdob.ValueChanged += new System.EventHandler(this.txtdob_ValueChanged);
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxgender.Location = new System.Drawing.Point(437, 60);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(200, 21);
            this.comboBoxgender.TabIndex = 22;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(704, 415);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // gvsalesman
            // 
            this.gvsalesman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsalesman.Location = new System.Drawing.Point(56, 162);
            this.gvsalesman.Name = "gvsalesman";
            this.gvsalesman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvsalesman.Size = new System.Drawing.Size(618, 247);
            this.gvsalesman.TabIndex = 24;
            this.gvsalesman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvsalesman_CellClick);
            // 
            // Salesman_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvsalesman);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.dateTimePickerdob);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lblsaddress);
            this.Controls.Add(this.lblsdob);
            this.Controls.Add(this.lblsgender);
            this.Controls.Add(this.btnsreset);
            this.Controls.Add(this.btnsupdate);
            this.Controls.Add(this.btnsremove);
            this.Controls.Add(this.btnsinsert);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblsphone);
            this.Controls.Add(this.lblsname);
            this.Controls.Add(this.lblsid);
            this.Controls.Add(this.label1);
            this.Name = "Salesman_Information";
            this.Text = "Salesman_Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Salesman_Information_FormClosed);
            this.Load += new System.EventHandler(this.Salesman_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvsalesman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Label lblsphone;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnsinsert;
        private System.Windows.Forms.Button btnsremove;
        private System.Windows.Forms.Button btnsupdate;
        private System.Windows.Forms.Button btnsreset;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Label lblsgender;
        private System.Windows.Forms.Label lblsdob;
        private System.Windows.Forms.Label lblsaddress;
        private System.Windows.Forms.TextBox txtaddress;
       // private System.Windows.Forms.DataGridView gvsales;
        private System.Windows.Forms.DateTimePicker dateTimePickerdob;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView gvsalesman;
    }
}