using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Management_System
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {

            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CoffeeShopDB.mdf;Integrated Security=True;Connect Timeout=30";
            string sql = string.Format("insert into register (FirstName,LastName,Phone,Mail,Password,ConfirmPassword,Address) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", txtfname.Text, txtlname.Text, txtphonereg.Text, txtmailreg.Text, txtpassreg.Text,txtcpassreg.Text, txtaddressreg.Text);

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            sqlCmd.Connection.Open();

            int rowsAffected = sqlCmd.ExecuteNonQuery();

            if (rowsAffected > 0)
              {
                MessageBox.Show("Registerd Successfully!!");
              }

              else
                {
                MessageBox.Show("Something went wrong!!");
                }
               sqlCmd.Connection.Close();
        }

        private void Welcome_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Register_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

        }
    }







}

      //  private void clicklog_Click(object sender, EventArgs e)
      //  {

      //  }
    

