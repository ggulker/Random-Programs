/*
 * Garrett Gulker
 * Cotemperary Prog Lang: c#
 * 11/6/18
 * Create a working pizza making program for a new restraunt
 * 
 * StartPage: used as a place to show the current cost and 
 * sends to CustomPage when wanting to make a new pizza
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_6
{
    public partial class StartPage : Form
    {
        double grandTotal;
        //used at the start of the program setting our total to 0
        public StartPage()
        {
            InitializeComponent();
            grandTotal = 0;
        }

        //when coming back from CustomPage sets all the all
        //the labels and  generates taxes and total
        public StartPage(double givenTotal)
        {
            InitializeComponent();
            grandTotal = givenTotal;
            SubLabel.Text = "Sub Total: $" + grandTotal.ToString("#.##");
            double taxes = grandTotal * .03;
            TaxLabel.Text = "Taxes: $" + taxes.ToString("#.##");
            double total = taxes + grandTotal;
            TotalLabel.Text = "Total: $" + total.ToString("#.##");
        }

        //closes the program
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        //sends to CustomPage
        private void AddPizzaButton_Click(object sender, EventArgs e)
        {
            CustomPage custom = new CustomPage(grandTotal);
            custom.Show();
            this.Hide();
        }

        //clears order by restarting the program
        private void ClearButton_Click(object sender, EventArgs e)
        {
            StartPage start = new StartPage();
            start.Show();
            this.Close();
        }
    }
}
