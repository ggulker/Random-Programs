// Garrett Gulker
// Due Date: 10/1/18
// Create an evidence game using windows form program 
// using a grid find 2 pieces of evidence by giving hints on guessed locations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidence_Game
{
    public partial class FindSampleGame : Form
    {
        private int rowSize, colSize;
        private ScanAnalyzer grid = new ScanAnalyzer();
        public FindSampleGame()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //copies sizes to our global variables
            rowSize = Int32.Parse(rowBox.Text);
            colSize = Int32.Parse(colBox.Text);

            //checks for invalid sizes
            if (rowSize > 26 || colSize > 26 || rowSize < 1 || colSize < 1)
                MessageBox.Show("You're graph size is invalid all values must be greater then 0 and smaller then 26");
            else
            {
                rowBox.Clear();
                colBox.Clear();
                GameBegin();
            }
        }

        private void FindSampleGame_Load(object sender, EventArgs e)
        {

        }

        private void GameBegin()
        {
            //reconfiger form for the game
            subTitle.Text = "guess the location";
            StartButton.Visible = false;
            exitBut.Visible = false;
            guessBut.Visible = true;
            quitBut.Visible = true;
            gridForm.Visible = true;
            //creates our scananalyzer and copies to our global then displays
            ScanAnalyzer temp = new ScanAnalyzer(rowSize, colSize);
            grid = temp;
            grid.DisplayGrid(gridForm);

            string[] list = {"1", " 2", "  3", " 4", " 5", "  6", " 7", " 8", " 9", " 10", " 11", " 12", "13", "14", "15", " 16", "17", "18", " 19", "20", " 21", "22", "23", "24", " 25"};
            //prints out the numbers on the top and left of our game
            rowNums.Text = "";
            colNums.Text = "";
            for (int i = 0; i < rowSize; i++)
            {
                rowNums.Text += list[i];
            }
            
            for (int i = 0; i < colSize; i++)
            {
                colNums.Text += list[i];
                colNums.Text += '\n';
            }
        }

        private void guessBut_Click(object sender, EventArgs e)
        {
           int guessRow = Int32.Parse(rowBox.Text);
           int guessCol = Int32.Parse(colBox.Text);
           colBox.Clear();
           rowBox.Clear();
            //checks if guess is in bounds
            if (guessRow > rowSize || guessRow < 1 || guessCol > colSize || guessCol < 1)
                MessageBox.Show("Guess out of bounds stay in bounds of grid");
            else
            {
                //checks guess then resets grid
                bool win = grid.EvaluateGuess(guessRow, guessCol);
                grid.DisplayGrid(gridForm);
                lastGuess.Text = "Last Guess= Row:" + guessRow + " Column:" + guessCol;
                if (win)
                {
                    //if win resets game
                    subTitle.Text = "YOU WIN!";
                    StartButton.Visible = true;
                    exitBut.Visible = true;
                    guessBut.Visible = false;
                    quitBut.Visible = false;
                }
            }
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            //button that closes program
            this.Close();
        }

        private void quitBut_Click(object sender, EventArgs e)
        {
            //exits the game going back to start
            subTitle.Text = "choose a size";
            StartButton.Visible = true;
            exitBut.Visible = true;
            guessBut.Visible = false;
            quitBut.Visible = false;
            gridForm.Visible = false;
        }

    }
}
