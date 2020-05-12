namespace Coffee_Shop_Management_System
{
    partial class Welcome_Cafe
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
            this.btadmin = new System.Windows.Forms.Button();
            this.btsalesman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(148, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Browny Cafe";
            // 
            // btadmin
            // 
            this.btadmin.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadmin.Location = new System.Drawing.Point(12, 415);
            this.btadmin.Name = "btadmin";
            this.btadmin.Size = new System.Drawing.Size(75, 33);
            this.btadmin.TabIndex = 1;
            this.btadmin.Text = "ADMIN";
            this.btadmin.UseVisualStyleBackColor = true;
            this.btadmin.Click += new System.EventHandler(this.btadmin_Click);
            // 
            // btsalesman
            // 
            this.btsalesman.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalesman.Location = new System.Drawing.Point(676, 404);
            this.btsalesman.Name = "btsalesman";
            this.btsalesman.Size = new System.Drawing.Size(112, 34);
            this.btsalesman.TabIndex = 2;
            this.btsalesman.Text = "SALESMAN";
            this.btsalesman.UseVisualStyleBackColor = true;
            this.btsalesman.Click += new System.EventHandler(this.btsalesman_Click);
            // 
            // Welcome_Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee_Shop_Management_System.Properties.Resources.welcome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsalesman);
            this.Controls.Add(this.btadmin);
            this.Controls.Add(this.label1);
            this.Name = "Welcome_Cafe";
            this.Text = "Welcome_Cafe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Welcome_Cafe_FormClosed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btadmin;
        private System.Windows.Forms.Button btsalesman;
    }
}