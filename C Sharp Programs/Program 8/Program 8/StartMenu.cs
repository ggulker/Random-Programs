//Garrett Gulker
//Due: 11/30/18
//create a parent/child form system to keep track of workshop files 
// StartMenu: our parent form that holds all child forms and calls
// all other forms 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //exits the application
        private void exitTextBox_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        //opens a naming form 
        private void newTextBox_Click(object sender, EventArgs e)
        {
            WorkshopName naming = new WorkshopName();
            naming.MdiParent = this;
            naming.Show();
        }

        //opens the dialog and once chosen gives the result
        //and file name to a newly created workshop form
        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Supply Files|*.sup";
            open.Title = "Choose a Workshops File";

            if(open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DialogResult result = open.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    Workshop openFile = new Workshop(result, open.FileName);
                    openFile.MdiParent = this;
                    openFile.Show();
                }
            }
        }

        //calls the currently selected workshops insert method
        private void insertMenu_Click(object sender, EventArgs e)
        {
            //checks to see if clicked window is a workshop
            if(this.ActiveMdiChild is Workshop)
            {
                ((Workshop)this.ActiveMdiChild).OpenInsertForm();
            }
            else
            {
                MessageBox.Show("Please Select a Workshop Window");
            }
        }

        //calls the currently selected workshops delete method
        private void deleteMenu_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Workshop)
            {
                ((Workshop)this.ActiveMdiChild).Delete();
            }
            else
            {
                MessageBox.Show("Please Select a Workshop Window");
            }
        }

        //calls the currently selected workshops save method
        private void saveMenu_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Workshop)
            {
                ((Workshop)this.ActiveMdiChild).Save();
            }
            else
            {
                MessageBox.Show("Please Select a Workshop Window");
            }
        }
    }
}
