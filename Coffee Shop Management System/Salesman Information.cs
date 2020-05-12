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
    public partial class Salesman_Information : Form
    {
        public Salesman_Information()
        {
            InitializeComponent();
        }

        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CoffeeShopDB.mdf;Integrated Security=True;Connect Timeout=30";
        public int id;
        private void Salesman_Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Welcome_Cafe wc = new Welcome_Cafe();
            wc.Show();
            this.Hide();
        }

        private void Salesman_Information_Load(object sender, EventArgs e)
        {

            Gvsalesman();


        }

        private void Gvsalesman()
        {

           
            //string sql = string.Format("select * from salesman where username = '{0}' and password = '{1}'", UserName.Text, passwordBox.Text);
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlcmd = new SqlCommand("Select * from salesman", conn);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataReader sdr = sqlcmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            // sqlcmd.Connection.Open();
            //dt.Load(sqlcmd.ExecuteReader());

            gvsalesman.DataSource = dt;
        }

        private void btnsinsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlcmd = new SqlCommand("INSERT INTO salesman values(@ID,@Name,@Phone,@Gender,@DOB,@Address)",conn);
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@ID",txtid.Text);
                sqlcmd.Parameters.AddWithValue("@Name", txtname.Text);
                sqlcmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                sqlcmd.Parameters.AddWithValue("@Gender", comboBoxgender.Text);
                sqlcmd.Parameters.AddWithValue("@DOB", dateTimePickerdob.Text);
                sqlcmd.Parameters.AddWithValue("@Address", txtaddress.Text);

                conn.Open();
                sqlcmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("New Salesman is Successfully Saved in the Database ","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Gvsalesman();
                ResetForm();
            }
        }

        private bool IsValid()
        {
            if (txtname.Text == string.Empty)
            {

                MessageBox.Show("Salesman Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;


            }
            return true;

        }

        private void btnsreset_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void ResetForm()
        {

            id = 0;
            txtid.Clear();
            txtname.Clear();
            txtphone.Clear();
            comboBoxgender.Text = "";
            txtaddress.Clear();
            dateTimePickerdob.Value = DateTime.Now;
            txtid.Focus();

        }

        private void gvsalesman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(gvsalesman.SelectedRows[0].Cells[0].Value);
            txtid.Text = gvsalesman.SelectedRows[0].Cells[1].Value.ToString();
            txtname.Text= gvsalesman.SelectedRows[0].Cells[2].Value.ToString();
            txtphone.Text = gvsalesman.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxgender.Text = gvsalesman.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePickerdob.Text = gvsalesman.SelectedRows[0].Cells[5].Value.ToString();
            txtaddress.Text = gvsalesman.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void btnsupdate_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlcmd = new SqlCommand("UPDATE salesman SET ID=(@ID,Name=@Name,Phone=@Phone,Gender=@Gender,DOB=@DOB,Address=@Address WHERE ID=(@ID)", conn);
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@ID", txtid.Text);
                sqlcmd.Parameters.AddWithValue("@Name", txtname.Text);
                sqlcmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                sqlcmd.Parameters.AddWithValue("@Gender", comboBoxgender.Text);
                sqlcmd.Parameters.AddWithValue("@DOB", dateTimePickerdob.Text);
                sqlcmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                sqlcmd.Parameters.AddWithValue("@ID", this.id);

                conn.Open();
                sqlcmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Salesman Information is Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Gvsalesman();
                ResetForm();

            }

            else
            {
                MessageBox.Show("Please select Salesman to update Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void btnsremove_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlcmd = new SqlCommand("DELETE FROM salesman WHERE ID=(@ID)", conn);
                
                sqlcmd.Parameters.AddWithValue("@ID", this.id);

                conn.Open();
                sqlcmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Salesman Information is Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Gvsalesman();
                ResetForm();
                  

            }

            else
            {

                MessageBox.Show("Please select Salesman to Delete Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void txtdob_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerdob.CustomFormat = "dd/MM/yyyy";
        }
    }
}
