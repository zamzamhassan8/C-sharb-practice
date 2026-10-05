using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Creating Variblae
            int range;

            try
            {
                //take range from user
                range=int.Parse(txtinteger.Text);

                if (range <= 10)
                {
                    lbloutput.Text = range + ":Is In Range.";
                }
                else {
                    lbloutput.Text = range + ":Is not In The Range. ";
                }
            }
            catch {
                MessageBox.Show("Please Enter Coreect Info:");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing The text box And LABLE

            txtinteger.Text = " ";
            lbloutput.Text=" ";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //Exit the Program
            this.Close();
        }
    }
}
