//InsertForm: used to collect data so that the user can
//add an item to the workshop
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_8
{
    public partial class InsertForm : Form
    {
        Workshop insertTarget;

        //called with the workshop its adding to and its name
        public InsertForm(Workshop current, string name)
        {
            InitializeComponent();
            insertTarget = current;
            title.Text += " " + name;
        }

        //closes form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //closes the form and returns to the workshop form with the new item info
        private void insertButton_Click(object sender, EventArgs e)
        {
            //checks if any textbox is empty
            if (nameTextBox.Text != "" && 
                amountTextBox.Text != "" && priceTextBox.Text != "")
            {
                try
                {
                    Int32.Parse(amountTextBox.Text);
                    double.Parse(priceTextBox.Text);
                    insertTarget.AddToList(nameTextBox.Text,
                        amountTextBox.Text, priceTextBox.Text);
                    this.Close();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid values for item", "Format Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill all text boxes before continuing");
            }
        }
    }
}
