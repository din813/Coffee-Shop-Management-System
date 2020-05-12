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
    public partial class Waiter_Information : Form
    {
        public Waiter_Information()
        {
            InitializeComponent();
        }

        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CoffeeShopDB.mdf;Integrated Security=True;Connect Timeout=30";
        public int id;
        private void Waiter_Information_Load(object sender, EventArgs e)
        {

            Gvwaiter();
        }

        private void Gvwaiter()
        {

            
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlcmd = new SqlCommand("Select * from waiter", conn);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataReader sdr = sqlcmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            // sqlcmd.Connection.Open();
            //dt.Load(sqlcmd.ExecuteReader());

            gvwaiter.DataSource = dt;


        }

        private void Waiter_Information_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnwinsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlcmd = new SqlCommand("INSERT INTO waiter values(@ID,@Name,@Phone,@Gender,@DOB,@Address)", conn);
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@ID", txtid.Text);
                sqlcmd.Parameters.AddWithValue("@Name", txtname.Text);
                sqlcmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                sqlcmd.Parameters.AddWithValue("@Gender", comboBoxgender.Text);
                sqlcmd.Parameters.AddWithValue("@DOB", dateTimePickerDOB.Text);
                sqlcmd.Parameters.AddWithValue("@Address", txtaddress.Text);

                conn.Open();
                sqlcmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("New Waiter is Successfully Saved in the Database ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Gvwaiter();
                ResetForm();

            }

        }

        private bool IsValid()
        {
            if (txtname.Text == string.Empty)
            {

                MessageBox.Show("Waiter Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;


            }
            return true;

        }

        private void btnwreset_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void ResetForm()
        {
            txtid.Clear();
            txtname.Clear();
            txtphone.Clear();
            comboBoxgender.Text = "";
            txtaddress.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            txtid.Focus();
        }

        private void gvwaiter_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            id = Convert.ToInt32(gvwaiter.SelectedRows[0].Cells[0].Value);
            txtid.Text = gvwaiter.SelectedRows[0].Cells[1].Value.ToString();
            txtname.Text = gvwaiter.SelectedRows[0].Cells[2].Value.ToString();
            txtphone.Text = gvwaiter.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxgender.Text = gvwaiter.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePickerDOB.Text = gvwaiter.SelectedRows[0].Cells[5].Value.ToString();
            txtaddress.Text = gvwaiter.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnwupdate_Click(object sender, EventArgs e)
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
                sqlcmd.Parameters.AddWithValue("@DOB", dateTimePickerDOB.Text);
                sqlcmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                sqlcmd.Parameters.AddWithValue("@ID", this.id);

                conn.Open();
                sqlcmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Waiter Information is Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Gvwaiter();
                ResetForm();

            }

            else
            {
                MessageBox.Show("Please select Row to update Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void btnwremove_Click(object sender, EventArgs e)
        {

            if (id > 0)
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlcmd = new SqlCommand("DELETE FROM waiter WHERE ID=(@ID)", conn);

                sqlcmd.Parameters.AddWithValue("@ID", this.id);

                conn.Open();
                sqlcmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show(" Do you Want to Waiter Information Delete?", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Gvwaiter();
                ResetForm();


            }

            else
            {

                MessageBox.Show("Please select Row to Delete Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDOB.CustomFormat = "dd/MM/yyyy";
        }
    }
}

