using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Over_Time_Hores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Craeting Varibales
            double hourse, hourly, groos, overtime, overpay;

            //get into from the user
            hourse = double.Parse(txthours.Text);
            hourly= double.Parse(txthourly.Text);

            //Using Nastedif to Culculate

            try
            {
                if (hourse > 30)
                {
                    overtime = hourse - 30;
                    overpay = overtime * (hourly * 1.6);

                    groos = (30 * hourly) + overtime;

                    if (groos > 0)
                    {
                        lblgroospay.Text = groos.ToString("c");
                    }

                }
                else {
                    groos = hourse * hourly;
                }
                lbloutput.Text = groos.ToString("c");
            }
            catch {
                MessageBox.Show("Waxa Laga Bahnyahy Soo gili.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing Txet Box and Lable
            txthours.Clear();
            txthourly.Clear();

            lbloutput.Text = " ";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //closing the program
            this.Close();
        }
    }
}
