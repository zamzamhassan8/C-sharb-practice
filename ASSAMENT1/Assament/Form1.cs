using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assament
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttshowinfo_Click(object sender, EventArgs e)
        {
            //step 1
            string name, deparment, fullinfo;
            
            name = txtname.Text;
            int studentid= int.Parse(txtstudentid.Text);
            deparment=txtdepartment.Text;
            int semsiter = int.Parse(txtsemester.Text);

            //step2

            fullinfo = name + " ," + studentid + " ," + deparment + " ," + semsiter;

            //step3
            lblshowinfo.Text = fullinfo;



           

        }

        private void bttclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lblshowinfo.Text=string.Empty;
        }
    }
}
