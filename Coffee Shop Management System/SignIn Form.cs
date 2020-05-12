using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coffee_Shop_Management_System
{
    public partial class SignIn_Form : Form
    {
        string id;
        public SignIn_Form()
        {
            InitializeComponent();
        }
        public SignIn_Form(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void signin_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Form_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
           


        }

        private void buttonsign_Click(object sender, EventArgs e)
        {

            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CoffeeShopDB.mdf;Integrated Security=True;Connect Timeout=30";
            string sql = string.Format("select * from TableSignIn where UserName = '{0}' and Password = '{1}'",txtmail.Text, txtpass.Text);
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            sqlcmd.Connection.Open();
            dt.Load(sqlcmd.ExecuteReader());
            if (dt.Rows.Count > 0)
              {
                MessageBox.Show("Log in success!!");
                MessageBox.Show(dt.Rows[0][0].ToString());
                SignIn_Form signInfo = new SignIn_Form(dt.Rows[0][0].ToString());
                signInfo.Show();
                this.Hide();

               }

              else
               {
                MessageBox.Show("Error!!");



                }
                  sqlcmd.Connection.Close();
            
        }

        private void SignIn_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Welcome_Cafe wc = new Welcome_Cafe();
            wc.Show();
            this.Hide();
        }
    }
}

