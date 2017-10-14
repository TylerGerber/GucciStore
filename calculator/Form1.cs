using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//yo

namespace calculator
{
    public partial class Form1 : Form
    {
        //constants
        const double FLIP_FLOPS = 250;
        const double BELT = 900;
        const double SHIRT = 700;
        const double TAX = 1.13;
        const string CLEAR = " ";

        //variables
        double numOfFlips = 0;
        double numOFBelt = 0;
        double numOfShirt = 0;
        double numOfTax;
        double numOfTendered;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
               

                numOfFlips = Convert.ToDouble(slidesText.Text);
                numOFBelt = Convert.ToDouble(beltText.Text);
                numOfShirt = Convert.ToDouble(shirtText.Text);
               

                double numOfSub = numOfFlips * FLIP_FLOPS
                + numOFBelt * BELT
                + numOfShirt * SHIRT;

                numOfTax = TAX * numOfSub;                   

                subTotal.Text = "$" + numOfSub;

                tax.Text = "$" + Convert.ToString(numOfTax - numOfSub);
                total.Text = "$" + numOfSub * TAX;
            }
            catch
            {
                subTotal.Text = "idiot";
            }
            
            
        }

        private void slidesText_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcualteChange_Click(object sender, EventArgs e)
        {
            try
            {
                

                numOfTendered = Convert.ToDouble(tenderText.Text);

                change.Text = "$" + Convert.ToString(numOfTendered - numOfTax);
            }
           
            catch
            {
                change.Text = "idiot";
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            double beltPrice = numOFBelt * BELT;
            double shirtPrice = numOfShirt * SHIRT;
            double flipPrice = numOfFlips + FLIP_FLOPS;

            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Arial", 13, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            fg.Clear(Color.White);


            fg.DrawString("Recipt" + "\n" + "September 28, 2008" + '\n' + '\n' + "Belt: x" 
                + numOFBelt + " @ $" + beltPrice + "\n" + "Shirt: x" + shirtPrice + "\n"
                + "Flip Flops: x" + flipPrice + '\n' + "\n" + "Subtotal: " + subTotal.Text
                + '\n' + "Tax: " + tax.Text + "\n" + "Total: " + total.Text + "\n" + '\n'
                + "Tenderd: $" + tenderText.Text + "\n" + "Change: " + change.Text 
                + "\n" + "Have a nice day ;)", drawFont, drawBrush, 210, 50);

           
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            fg.Clear(Color.White);

            tax.Text = CLEAR; 
            subTotal.Text = CLEAR;
            total.Text = CLEAR;
            change.Text = CLEAR;
        }
    }
}
