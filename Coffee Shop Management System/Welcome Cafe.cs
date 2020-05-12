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
    public partial class Welcome_Cafe : Form
    {
        public Welcome_Cafe()
        {
            InitializeComponent();
        }

        private void btadmin_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignIn_Form s = new SignIn_Form();
            s.ShowDialog();


        }

        private void btsalesman_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_and_Billing_System m = new Menu_and_Billing_System();
            m.ShowDialog();
        }

        private void Welcome_Cafe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Welcome_Cafe_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }
    }
}
