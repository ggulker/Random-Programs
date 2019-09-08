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
    public partial class WorkshopName : Form
    {
        public WorkshopName()
        {
            InitializeComponent();
        }

        //closes form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //creates a workshop form with the name given
        private void okButton_Click(object sender, EventArgs e)
        {
            Workshop newFile = new Workshop(nameBox.Text);
            newFile.MdiParent = this.MdiParent;
            newFile.Show();
            this.Close();
        }
    }
}
