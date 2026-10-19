using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assament_Arbaco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {


          
            //Creating Vriblae
            string name;
            string roomtype = " ";
            int age, nights, gusts;
            decimal breakfast = 0;
            int rate = 0;
            int maxgust = 0;
            decimal discont = 0;
            bool BookingApprovid = true;
            int cost = 0;
            decimal surcharge = 0;
            decimal Seniordescont = 0;

            decimal total;

            //Inizallion varbles
            name = txtguestname.Text;
            age = int.Parse(txtguestage.Text);
            nights = int.Parse(txtnumberofnights.Text);
            gusts = int.Parse(txtnumberofguest.Text);

            //Validate Using Try Parse
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name Can Not Be Empty.");

            }
            else
            {

            }
            if (int.TryParse(txtguestage.Text, out age))
            {
                if (age < 18 || age > 90)
                {
                    MessageBox.Show("The Age Must Be Between 18-90.");
                }

                else
                {


                }
            }


            if (int.TryParse(txtguestname.Text, out gusts))
            {
                if (gusts < 1 || gusts > 6)
                {
                    MessageBox.Show("The Number Og Guesst Must Be Between 1-6");
                }
                else
                {

                }
            }

            if (int.TryParse(txtnumberofnights.Text, out nights))
            {
                if (nights < 1 || nights > 30)
                {
                    MessageBox.Show("Sorry The Nights Can Not More Than 30 Days. ");
                }
                else
                {

                }
            }

            if (radiobtnstndard.Checked) roomtype = "Standred";
            else if (radiobtnnormal.Checked) roomtype = "Normal";
            else if (radiobtnhight.Checked) roomtype = "Hight";

            switch (roomtype)
            {
                case "Standred":
                    rate = 50;
                    maxgust = 2;
                    break;
                case "Normal":
                    rate = 80;
                    maxgust = 4;
                    break;
                case "Hight":
                    rate = 160;
                    maxgust = 6;
                    break;

                default:
                    {
                        MessageBox.Show("Please Select Room Type You Want");
                    }
                    break;
            }

            if (roomtype != " " && gusts < maxgust)
            {
                MessageBox.Show(roomtype + "Room Allows A Maximum Of " + maxgust + " Gustes Sorry.");

            }

            if (BookingApprovid == true)
            {


            }
            else
            {
                MessageBox.Show("Sorry Your Booking Is Rajactid");
            }

            cost = rate * nights;

            if (nights >= 10)
            {
                discont = 0.12m;
            }
            else if (nights >= 5)
            {
                discont = 0.05m;
            }

            decimal nightdescont = cost * discont;
            decimal afterdiscont = cost - nightdescont;

            if (checkbreak.Checked)
            {
                breakfast = 10 * nights;

            }

            if (age >= 60)
            {
                Seniordescont = afterdiscont * 0.05m;
            }

            if (gusts <= 6)
            {
                surcharge = afterdiscont * 0.05m;
            }

            total = afterdiscont - Seniordescont - surcharge + breakfast;

            listBoxDisblay.Items.Add(BookingApprovid);
            listBoxDisblay.Items.Add(" ");
            listBoxDisblay.Items.Add("");

            listBoxDisblay.Items.Add("Gustes Name:" + name);
            listBoxDisblay.Items.Add("Age:" + age);
            listBoxDisblay.Items.Add("Room Type:" + roomtype);
            listBoxDisblay.Items.Add("Rate of The Type Room: $" + rate);
            listBoxDisblay.Items.Add("Gusts:" + gusts);
            listBoxDisblay.Items.Add("Nights:" + nights);
            listBoxDisblay.Items.Add("Room Cost: $" + cost);
            listBoxDisblay.Items.Add("Night Desconts: $" + nightdescont);
            listBoxDisblay.Items.Add("Senior Descount: $" + Seniordescont);
            listBoxDisblay.Items.Add("Service Surcharge: $" + surcharge);
            listBoxDisblay.Items.Add("Brekfast Cost: $" + breakfast);
            listBoxDisblay.Items.Add("------------------------------");
            listBoxDisblay.Items.Add("Total Cost: $" + total);



        }

        private void btnclear_Click(object sender, EventArgs e)
        {
         
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            listBoxDisblay.Items.Clear();
            txtguestage.Clear();
            txtguestname.Clear();
            txtnumberofnights.Clear();
            txtguestname.Clear();
            txtnumberofguest.Clear();
            radiobtnstndard.Checked = false;
            radiobtnnormal.Checked = false;
            radiobtnhight.Checked = false;
            checkbreak.Checked = false;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

