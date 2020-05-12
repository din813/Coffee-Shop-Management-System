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
    public partial class Menu_and_Billing_System : Form
    {
        public Menu_and_Billing_System()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void blcoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (blcoffee.Checked == true)
            {
                txtblack.Enabled = true;
            }
            if (blcoffee.Checked == false)
            {
                txtblack.Enabled = false;
                txtblack.Text = "0";

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToLongTimeString();
        }

        private void Menu_and_Billing_System_Load(object sender, EventArgs e)
        {
            label14.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtamerican.Text = "0";
            txtblack.Text = "0";
            txtbrown.Text = "0";
            txtburger.Text = "0";
            txtcake.Text = "0";
            txtcappu.Text = "0";
            txtchoc.Text = "0";
            txtcold.Text = "0";
            txtespre.Text = "0";
            txtgreen.Text = "0";
            txtlatte.Text = "0";
            txtmocha.Text = "0";
            txtnoodles.Text = "0";
            txtpizza.Text = "0";
            txtsandwitch.Text = "0";
            txtsoup.Text = "0";
            txtsugar.Text = "0";
            txtvelvet.Text = "0";
            lbfood.Text = "0";
            lbdrinks.Text = "0";
            lbcharge.Text = "5.75";
            txtblack.Enabled = false;
            txtcold.Enabled = false;
            txtgreen.Enabled = false;
            txtbrown.Enabled = false;
            txtsugar.Enabled = false;
            txtchoc.Enabled = false;
            txtcappu.Enabled = false;
            txtamerican.Enabled = false;
            txtlatte.Enabled = false;
            txtespre.Enabled = false;
            txtmocha.Enabled = false;
            txtcake.Enabled = false;
            txtvelvet.Enabled = false;
            txtsandwitch.Enabled = false;
            txtburger.Enabled = false;
            txtpizza.Enabled = false;
            txtsoup.Enabled = false;
            txtnoodles.Enabled = false;




        }

        private void resetb_Click(object sender, EventArgs e)
        {
            txtamerican.Text = "0";
            txtblack.Text = "0";
            txtbrown.Text = "0";
            txtburger.Text = "0";
            txtcake.Text = "0";
            txtcappu.Text = "0";
            txtchoc.Text = "0";
            txtcold.Text = "0";
            txtespre.Text = "0";
            txtgreen.Text = "0";
            txtlatte.Text = "0";
            txtmocha.Text = "0";
            txtnoodles.Text = "0";
            txtpizza.Text = "0";
            txtsandwitch.Text = "0";
            txtsoup.Text = "0";
            txtsugar.Text = "0";
            txtvelvet.Text = "0";
            lbfood.Text = "0";
            lbdrinks.Text = "0";
            lbcharge.Text = "5.75";
            lbtax.Text = "0";
            lbsubtotal.Text = "0";
            lbtotal.Text = "0";







        }

        private void panel6_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtblack_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtblack_Click(object sender, EventArgs e)
        {
            txtblack.Text = "";
            txtblack.Focus();

        }

        

       

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                txtgreen.Enabled = true;
            }
            if (checkBox3.Checked == false)
            {
                txtgreen.Enabled = false;
                txtgreen.Text = "0";
            }
        }

        private void txtgreen_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                txtbrown.Enabled = true;
                
            }


            if (checkBox4.Checked == false)
            {
                txtbrown.Enabled = false;
                txtbrown.Text = "0";
            }
        }

        private void txtbrown_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbrown_Click(object sender, EventArgs e)
        {
            txtbrown.Text = "";
            txtbrown.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                txtsugar.Enabled = true;
            }
            if (checkBox5.Checked == false)
            {
                txtsugar.Enabled = false;
                txtsugar.Text = "0";
            }
        }

        private void txtsugar_Click(object sender, EventArgs e)
        {
            txtsugar.Text = "";
            txtsugar.Focus();

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                txtchoc.Enabled = true;
            }
            if (checkBox6.Checked == false)
            {
                txtchoc.Enabled = false;
                txtchoc.Text = "0";
            }
        }

        private void txtchoc_Click(object sender, EventArgs e)
        {
            txtchoc.Text = "";
            txtchoc.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                txtcappu.Enabled = true;
            }
            if (checkBox7.Checked == false)
            {
                txtcappu.Enabled = false;
                txtcappu.Text = "0";
            }
        }

        private void txtcappu_Click(object sender, EventArgs e)
        {
            txtcappu.Text = "";
            txtcappu.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                txtamerican.Enabled = true;
            }
            if (checkBox16.Checked == false)
            {
                txtamerican.Enabled = false;
                txtamerican.Text = "0";
            }
        }

        private void txtamerican_Click(object sender, EventArgs e)
        {
            txtamerican.Text = "";
            txtamerican.Focus();

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                txtlatte.Enabled = true;
            }
            if (checkBox17.Checked == false)
            {
                txtlatte.Enabled = false;
                txtlatte.Text = "0";
            }
        }

        private void txtlatte_Click(object sender, EventArgs e)
        {
            txtlatte.Text = "";
            txtlatte.Focus();

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                txtespre.Enabled = true;
            }
            if (checkBox18.Checked == false)
            {
                txtespre.Enabled = false;
                txtespre.Text = "0";
            }
        }

        private void txtespre_Click(object sender, EventArgs e)
        {
            txtespre.Text = "";
            txtespre.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                txtmocha.Enabled = true;
            }
            if (checkBox8.Checked == false)
            {
                txtmocha.Enabled = false;
                txtmocha.Text = "0";
            }
        }

        private void txtmocha_Click(object sender, EventArgs e)
        {
            txtmocha.Text = "";
            txtmocha.Focus();

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                txtcake.Enabled = true;
            }
            if (checkBox9.Checked == false)
            {
                txtcake.Enabled = false;
                txtcake.Text = "0";
            }
        }

        private void txtcake_Click(object sender, EventArgs e)
        {
            txtcake.Text = "";
            txtcake.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                txtvelvet.Enabled = true;
            }
            if (checkBox10.Checked == false)
            {
                txtvelvet.Enabled = false;
                txtvelvet.Text = "0";
            }
        }

        private void txtvelvet_Click(object sender, EventArgs e)
        {
            txtvelvet.Text = "";
            txtvelvet.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                txtsandwitch.Enabled = true;
            }
            if (checkBox11.Checked == false)
            {
                txtsandwitch.Enabled = false;
                txtsandwitch.Text = "0";
            }
        }

        private void txtsandwitch_Click(object sender, EventArgs e)
        {
            txtsandwitch.Text = "";
            txtsandwitch.Focus();

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                txtburger.Enabled = true;
            }
            if (checkBox12.Checked == false)
            {
                txtburger.Enabled = false;
                txtburger.Text = "0";
            }
        }

        private void txtburger_Click(object sender, EventArgs e)
        {
            txtburger.Text = "";
            txtburger.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                txtpizza.Enabled = true;
            }
            if (checkBox13.Checked == false)
            {
                txtpizza.Enabled = false;
                txtpizza.Text = "0";
            }
        }

        private void txtpizza_Click(object sender, EventArgs e)
        {
            txtpizza.Text = "";
            txtpizza.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                txtsoup.Enabled = true;
            }
            if (checkBox14.Checked == false)
            {
                txtsoup.Enabled = false;
                txtsoup.Text = "0";
            }
        }

        private void txtsoup_Click(object sender, EventArgs e)
        {
            txtsoup.Text = "";
            txtsoup.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                txtnoodles.Enabled = true;
            }
            if (checkBox15.Checked == false)
            {
                txtnoodles.Enabled = false;
                txtnoodles.Text = "0";
            }
        }

        private void txtnoodles_Click(object sender, EventArgs e)
        {
            txtnoodles.Text = "";
            txtnoodles.Focus();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtsreceipt.Text, new Font("Arial", 14,FontStyle.Regular), Brushes.Black, 120, 120);

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                txtcold.Enabled = true;
            }
            if (checkBox20.Checked == false)
            {
                txtcold.Enabled = false;
                txtcold.Text = "0";
            }
        }

        private void txtcold_Click(object sender, EventArgs e)
        {
            txtcold.Text = "";
            txtcold.Focus();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtsreceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtsreceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtsreceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtsreceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1 openFile = new openFileDialog1();

            openFile.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)";

            if (openFile.showDialog() == System.Windows.Forms.DialogResult.OK)
                rtsreceipt.LoadFile(openFile.Filename, RichTextBoxStreamType.PlainText);



        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           // saveFileDialog1 saveFile = new saveFileDialog1();

        }

        private void receiptb_Click(object sender, EventArgs e)
        {
            rtsreceipt.Clear();
            rtsreceipt.AppendText(Environment.NewLine);
            rtsreceipt.AppendText(" \t---------------------------------------------------" + Environment.NewLine);
            rtsreceipt.AppendText("\t\t"+"Browny Cafe"+Environment.NewLine);
            rtsreceipt.AppendText("\t\t" + "Menu Receipt\t" + Environment.NewLine);
            rtsreceipt.AppendText("\t"+label14.Text+"\t"+label15.Text);
            rtsreceipt.AppendText(" \t---------------------------------------------------"+Environment.NewLine+Environment.NewLine);
            rtsreceipt.AppendText("  Menu Name\t\t" +"Qty\t" +"Menu Price\t"+"Price\n"+ Environment.NewLine);

            rtsreceipt.AppendText("  Black Coffee\t\t"       + txtblack.Text +"\t80\t" +Environment.NewLine);
            rtsreceipt.AppendText("  Cold Coffee\t\t"        + txtcold.Text + "\t65"+Environment.NewLine);
            rtsreceipt.AppendText("  Green Coffee\t\t"       + txtgreen.Text + "\t70"+Environment.NewLine);
            rtsreceipt.AppendText("  Brown Coffee\t\t"       + txtbrown.Text + "\t90"+Environment.NewLine);
            rtsreceipt.AppendText("  Sugar Free Coffee\t"  + txtsugar.Text + "\t50"+Environment.NewLine);
            rtsreceipt.AppendText("  Chocolate Coffee\t"   + txtchoc.Text + "\t60"+Environment.NewLine);
            rtsreceipt.AppendText("  Cappuccino Coffee\t"  + txtcappu.Text + "\t120"+Environment.NewLine);
            rtsreceipt.AppendText("  American Coffee\t"    + txtamerican.Text + "\t90"+Environment.NewLine);
            rtsreceipt.AppendText("  Cafe Latte\t\t"         + txtlatte.Text +"\t120"+ Environment.NewLine);
            rtsreceipt.AppendText("  Espresso\t\t"           + txtespre.Text +"\t100"+ Environment.NewLine);
            rtsreceipt.AppendText("  Cafe Mocha\t\t"         + txtmocha.Text +"\t110"+ Environment.NewLine);
            rtsreceipt.AppendText("  Coffee Cake\t\t"        + txtcake.Text + "\t80"+Environment.NewLine);
            rtsreceipt.AppendText("  Velvet Cake\t\t"        + txtvelvet.Text + "\t85"+Environment.NewLine);
            rtsreceipt.AppendText("  Sandwitch\t\t"          + txtsandwitch.Text +"\t70"+ Environment.NewLine);
            rtsreceipt.AppendText("  Burger\t\t"             + txtburger.Text + "\t180"+Environment.NewLine);
            rtsreceipt.AppendText("  Pizza\t\t\t"              + txtpizza.Text + "\t120"+Environment.NewLine);
            rtsreceipt.AppendText("  Soup\t\t\t"               + txtsoup.Text +"\t60"+ Environment.NewLine);
            rtsreceipt.AppendText("  Noodles\t\t"            + txtnoodles.Text + "\t55"+Environment.NewLine);
            rtsreceipt.AppendText(" ----------------------------------------------------" + Environment.NewLine);
            rtsreceipt.AppendText("Service Charge\t\t\t\t"+lbcharge.Text + Environment.NewLine);
            rtsreceipt.AppendText("----------------------------------------------------" + Environment.NewLine);
            rtsreceipt.AppendText("Tax\t\t\t\t" + lbtax.Text + Environment.NewLine);
            rtsreceipt.AppendText("Sub Total\t\t\t" + lbsubtotal.Text + Environment.NewLine);
            rtsreceipt.AppendText("Total Cost\t\t\t" + lbtotal.Text + Environment.NewLine);



        }

        private void totalb_Click(object sender, EventArgs e)
        {
            double tax = 0.75;
            double black, cold, green, brown, sugar, choc, capp, ame, lat,espre, mocha, cake, velvet, sandw, bur, piz, soup, noodles;
            black = 80;cold = 65;green = 70;brown = 90;sugar = 50;choc = 60;capp = 120;mocha = 110;cake = 80;sandw = 70;bur = 180;
            piz = 120;soup = 60;noodles = 55;espre = 100;ame = 90;lat = 120;velvet = 85;

            double black_Cof = Convert.ToDouble(txtblack.Text) ;
            double cold_Cof = Convert.ToDouble(txtcold.Text) ;
            double green_Cof = Convert.ToDouble(txtgreen.Text) ;
            double brown_Cof = Convert.ToDouble(txtbrown.Text) ;
            double sug_Cof = Convert.ToDouble(txtsugar.Text) ;
            double choc_Cof = Convert.ToDouble(txtchoc.Text) ;
            double capp_Cof = Convert.ToDouble(txtcappu.Text) ;
            double ame_Cof = Convert.ToDouble(txtamerican.Text) ;
            double lat_Cof = Convert.ToDouble(txtlatte.Text) ;
            double espre_fo = Convert.ToDouble(txtespre.Text) ;
            double mocha_fo = Convert.ToDouble(txtmocha.Text) ;
            double choc_cake = Convert.ToDouble(txtcake.Text) ;
            double velvet_cake = Convert.ToDouble(txtvelvet.Text) ;
            double sand_fo = Convert.ToDouble(txtsandwitch.Text) ;
            double bur_fo = Convert.ToDouble(txtburger.Text) ;
            double piz_fo = Convert.ToDouble(txtpizza.Text) ;
            double soup_fo = Convert.ToDouble(txtsoup.Text);
            double noodles_fo = Convert.ToDouble(txtnoodles.Text) ;


            Cafe eat_in_Cafe = new Cafe(black_Cof,cold_Cof,green_Cof,brown_Cof,sug_Cof,choc_Cof,capp_Cof,ame_Cof,lat_Cof,
                espre_fo,mocha_fo,choc_cake,velvet_cake,sand_fo,bur_fo,piz_fo,soup_fo,noodles_fo);

            double cost_of_drinks = (black_Cof * black) + (cold_Cof * cold) + (green_Cof * green) + (brown_Cof * brown) + (sug_Cof * sugar)
                + (choc_Cof * choc) + (capp_Cof * capp) + (ame_Cof * ame) + (espre_fo * espre) + (lat_Cof * lat);

            lbdrinks.Text = Convert.ToString(cost_of_drinks);    

            double cost_of_food = (mocha_fo*mocha)+(choc_cake*choc)+(velvet_cake*velvet)+(sand_fo*sandw)+(bur_fo*bur)
                + (soup_fo * soup)+(piz_fo*piz)+(noodles_fo*noodles);

            lbfood.Text = Convert.ToString(cost_of_food);


            double service_charge = Convert.ToDouble(lbcharge.Text);

            lbsubtotal.Text = Convert.ToString(cost_of_drinks+cost_of_food+service_charge);
            lbtax.Text = Convert.ToString(((cost_of_drinks + cost_of_food + service_charge) * tax) / 100);
            double itax = Convert.ToDouble(lbtax.Text);
            lbtotal.Text = Convert.ToString(cost_of_drinks + cost_of_food+ service_charge+itax);



             double Price  = (black_Cof * black) + (cold_Cof * cold) + (green_Cof * green) + (brown_Cof * brown) + (sug_Cof * sugar)
              + (choc_Cof * choc) + (capp_Cof * capp) + (ame_Cof * ame) + (espre_fo * espre) + (lat_Cof * lat);


            

            //double price = Convert.ToDouble(lbblack.Text);


        }

        private void rtsreceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_and_Billing_System_FormClosed(object sender, FormClosedEventArgs e)
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