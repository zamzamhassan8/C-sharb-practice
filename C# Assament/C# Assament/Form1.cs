using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Assament
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double Descountrate = 0;
                int Numberpackegs=0; 
                int subtotal = 0;
                double Descountamount = 0;
                double totalamount = 0;
                
                int pricepackages;

                if (int .TryParse(txtpackages.Text, out Numberpackegs))
                {
                }
                 
                if (int.TryParse(txtprice.Text, out pricepackages))
                {

                }
                if (Numberpackegs >=10)
                {
                    Descountrate = 0.20;
                }
                 if (Numberpackegs >=20)
                {
                    Descountrate = 0.30;
                }
                 if (Numberpackegs >=50)
                {
                    Descountrate = 0.40;
                }
                 if (Numberpackegs >100)
                {
                    Descountrate = 0.50;
                }
                if (Numberpackegs<0)
                {
                    MessageBox.Show("lagama ogolo tiro negative ah");
                }
                    subtotal = Numberpackegs * pricepackages;
                Descountamount = subtotal * Descountrate;
                totalamount = subtotal - Descountamount;

                listBox.Items.Add("Numberpackegs " + "" + Numberpackegs);
                listBox.Items.Add("pricepackegs" + "" + pricepackages);
                listBox.Items.Add("subtotal" + "" + subtotal);
                listBox.Items.Add("Descount" + "" + Descountrate * 100 + "%");
                listBox.Items.Add("Descountamount" + "" + Descountamount.ToString("c2"));
                listBox.Items.Add("totalamount" + "" + totalamount);
            }




            catch (Exception)
            {
                MessageBox.Show("waa qaldan codeka");
            }
            
      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
