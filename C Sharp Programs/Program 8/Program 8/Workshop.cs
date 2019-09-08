//Workshop: holds the list box that shows all the workshops items
// as well as the workshops name 
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
    public partial class Workshop : Form
    {
        Record formRecord;
        private FileStream output;
        private BinaryFormatter formatter = new BinaryFormatter();

        //called when a new workshop is created
        public Workshop(string name)
        {
            InitializeComponent();
            formRecord = new Record(name);
            nameLabel.Text += name;
        }

        //called if opening a file 
        public Workshop(DialogResult file, string fileName)
        {
            InitializeComponent();
            //called if a invalid file is chosen
            if (fileName == "" || fileName == null)
                MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string name = fileName;

                //creates an input file stream
                FileStream input = new FileStream(name, FileMode.Open, FileAccess.Read);

                //de-serialize the file and saves it to our global record
                formRecord = (Record)formatter.Deserialize(input);
                nameLabel.Text += formRecord.workshop;
                for(int i = 0; i < formRecord.listSize(); i++)
                {
                    itemListBox.Items.Add(formRecord.ItemInfo(i));
                }
            }
        }

        //called when the file needs to be saved
        public void Save()
        {
            //creates a file dialog looking for a .sup file
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Supply Files|*.sup";
            save.Title = "Saving Workshop File.";

            DialogResult result = save.ShowDialog();
            string fileName;
            save.CheckFileExists = false;

            //if canceled does nothing
            if (result != DialogResult.Cancel)
            {
                fileName = save.FileName;
                //makes sure file name is not null
                if (fileName == "" || fileName == null)
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        //creates a save file stream
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                        //serializes and saves the file
                        formatter.Serialize(output, formRecord);
                        output.Close();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("File does not exist.");
                    }
                }
            }
        }

        //opens a form to collect info for new item
        public void OpenInsertForm()
        {
            //creates an insertForm when wanting to add to the file
            InsertForm insert = new InsertForm(this, formRecord.workshop);
            insert.Show();
        }

        //called when the InsertForm is closed
        public void AddToList(string item, string amount, string price)
        {
            int a = Int32.Parse(amount);
            double p = Double.Parse(price);

            //adds insert to record list
            formRecord.Add(item, a, p);

            //adds to listbox
            string listItem = String.Format("{0, -45} | {1, -45} | {2}",
            item, amount, price);
            itemListBox.Items.Add(listItem);
        }

        //deletes selected item from form
        public void Delete()
        {
            //removes from record list
            int index = itemListBox.SelectedIndex-1;
            formRecord.Delete(index);

            //removes from listbox
            itemListBox.Items.RemoveAt(itemListBox.SelectedIndex);
        }

        //if insert button is pressed on workshop form open insert form
        private void insertButton_Click(object sender, EventArgs e)
        {
            OpenInsertForm();
        }

        //if canceled closes form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //if delete is clicked on workshop form
        private void deleteButton_Click(object sender, EventArgs e)
        {   try
            {
                Delete();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("invalid item selected for removal", "Error");
            }
        }
    }
}

