// Garrett Gulker
// Project 7
// 11/13/18
// Create an image from c# graphics 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_7
{
    public partial class Background : Form
    {

        public Background()
        {
            InitializeComponent();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            //all brushes used in the program
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);

            //background rectangles
            e.Graphics.FillRectangle(redBrush, 0, 0, 640, 480);
            Rectangle rect = new Rectangle(10, 10, 460, 370);
            e.Graphics.FillRectangle(orangeBrush, rect);
            e.Graphics.FillRectangle(yellowBrush, 20, 20, 440, 350);
            e.Graphics.FillRectangle(redBrush, 30, 30, 420, 330);

            //string above the face
            Font font = new Font("Arial", 40);
            e.Graphics.DrawString("Smile!", font, yellowBrush, 155, 40);

            //left smile
            e.Graphics.FillEllipse(yellowBrush, 20, 100, 150, 150);
            e.Graphics.FillEllipse(blackBrush, 40, 120, 30, 30);
            e.Graphics.FillEllipse(blackBrush, 110, 120, 30, 30);
            e.Graphics.FillEllipse(blackBrush, 65, 180, 60, 60);
            e.Graphics.FillRectangle(yellowBrush, 60, 160, 70, 60);

            //right face
            e.Graphics.FillEllipse(yellowBrush, 300, 100, 150, 150);
            e.Graphics.FillEllipse(blackBrush, 320, 120, 30, 30);
            e.Graphics.FillEllipse(blackBrush, 390, 120, 30, 30);
            e.Graphics.FillEllipse(blackBrush, 345, 180, 60, 60);
            e.Graphics.FillRectangle(yellowBrush, 340, 160, 70, 60);

            //center face
            e.Graphics.FillEllipse(yellowBrush, 135, 100, 200, 200);
            e.Graphics.FillEllipse(blackBrush, 160, 130, 50, 50);
            e.Graphics.FillEllipse(blackBrush, 260, 130, 50, 50);
            e.Graphics.FillEllipse(blackBrush, 190, 205, 90, 90);
            e.Graphics.FillRectangle(yellowBrush, 190, 190, 90, 70);

        }
    }
}
