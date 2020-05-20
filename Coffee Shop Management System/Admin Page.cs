using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Management_System
{
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {
            adpanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void Admin_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnsalesman_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salesman_Information si = new Salesman_Information();
            si.ShowDialog();
        }

        private void btnwaiter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waiter_Information wi = new Waiter_Information();
            wi.ShowDialog();
        }

        private void btnbilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_and_Billing_System mbs = new Menu_and_Billing_System();
            mbs.ShowDialog();
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

        private void Admin_Page_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
