using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_Calculator
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
                //Create Variable
                String Guest_Name, Room_Type;
                int NumberNight;
                double PriceNight;
                double ServiceTax;
                double Discount;
                double TotalAmount;


                //Assigne Variables
                Guest_Name = txtname.Text;
                Room_Type = txtRoomtype.Text;

                NumberNight = int.Parse(txtNights.Text);
                PriceNight = double.Parse(txtpriceNight.Text);

                //Calculate booking Cost
                double subTotal = NumberNight * PriceNight;

                 ServiceTax = subTotal * 0.10;

                Discount = subTotal * 0.05;

                TotalAmount =( subTotal * 2) + ServiceTax - Discount;


                //Display Result

                LblServiceTax.Text = ServiceTax.ToString("C2");
                LblDiscount.Text = Discount.ToString("C2");
                LblTotalAmount.Text = TotalAmount.ToString("C2");


            




            }
            catch { 
            }
        

       

        }

       
    }
}
