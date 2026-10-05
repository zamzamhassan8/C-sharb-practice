using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Cost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating Varibals
            double test1,test2,test3 ,avreage;
            string grade = " ";

            try
            {
                //Get Score Frome The User
                test1 = double.Parse(txtscore1.Text);
                test2 = double.Parse(txtScor2.Text);
                test3 = double.Parse(txtScore3.Text);

                //calculate the avrage
                avreage = (test1 + test2 + test3) / 3;

                //using if and ifelse 

                if (avreage >= 90)
                {
                    grade = "A+";
                }
                else if (avreage >= 80)
                {
                    grade = "A";
                }
                else if (avreage >= 70)
                {
                    grade = "B+";
                }
                else if (avreage >= 60)
                {
                    grade = "B";
                }

                else {
                    MessageBox.Show("Sorry You Fill ");
                }

                //disblaying on the lebale 
                lbloutput.Text = "Avrage:" + avreage.ToString("f1") + " " + "Grade:" + grade;

                    

            }
            catch
            {
                MessageBox.Show("Enter Right information .");
            }




        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing Text box and lable 
            txtscore1.Clear();
            txtScor2.Clear();
            txtScore3.Clear();

            lbloutput.Text = " ";



        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //Closing The Program

            this.Close();

        }
    }
}
