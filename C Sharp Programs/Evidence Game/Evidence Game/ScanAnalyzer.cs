
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidence_Game
{
    class ScanAnalyzer
    {
        private int rowSize;
        private int colSize;
        private int ansR;
        private int ansC;
        private int ansR2;
        private int ansC2;
        private char[,] x;
        private int guess;
        private bool firstFound = false;
        private bool secondFound = false;

        public ScanAnalyzer()
        {

        }
        //constructs grid based on given size
        public ScanAnalyzer(int row, int col)
        {
            rowSize = row;
            colSize = col;
            char[,] grid = new char[row, col];

            //create our grid and copy to our global
            for (int r = 0; r < row; r++)
                for (int c = 0; c < col; c++)
                    grid[r, c] = '~';
            x = grid;
            guess = 0;
            //create all our answers placements
            Random rnd = new Random();
            ansR = rnd.Next(1, row);
            ansC = rnd.Next(1, col);
            ansR2 = rnd.Next(1, row);
            ansC2 = rnd.Next(1, col);
        }

        public void DisplayGrid(Label label)
        {
            //resets grid
            label.Text = "";
            //prints our grid 
            for (int r = 0; r < rowSize; r++)
            {
                for (int c = 0; c < colSize; c++)
                {
                    label.Text += x[r, c];
                    label.Text += " ";
                    if (c > 7)
                        label.Text += " ";
                }
                label.Text += '\n';
            }
        }

        public bool EvaluateGuess(int guessR, int guessC)
        {
            //switch determines if on first evidence or second
            switch (firstFound)
            {
                case false:
                    //checks to see if guess is correct
                    if (guessR == ansR && guessC == ansC)
                    {
                        firstFound = true;
                        x[ansR - 1, ansC - 1] = 'X';
                    }
                    else
                    {
                        //checks to see if hint is left/right or up/down
                        if (guess % 2 == 0)
                        {
                            //checks guess to see what symbol to place
                            //if already in right column returns a row hint
                            if (guessC == ansC)
                            {
                                if (guessR > ansR)
                                    x[guessR - 1, guessC - 1] = '^';
                                else
                                    x[guessR - 1, guessC - 1] = 'V';
                            }
                            else if (guessC > ansC)
                            {
                                x[guessR - 1, guessC - 1] = '<';
                            }
                            else
                            {
                                x[guessR - 1, guessC - 1] = '>';
                            }
                            guess++;
                        }
                        else
                        {
                            //if already in correct row gives column hint
                            if (guessR == ansR)
                            {
                                if (guessC > ansC)
                                    x[guessR - 1, guessC - 1] = '<';
                                else
                                    x[guessR - 1, guessC - 1] = '>';
                            }
                            else if (guessR > ansR)
                            {
                                x[guessR - 1, guessC - 1] = '^';
                            }
                            else
                            {
                                x[guessR - 1, guessC - 1] = 'V';
                            }
                            guess++;
                        }
                    }
                    break;

                case true:
                    //same as above just for the second answer after finding first
                    if (guessR == ansR2 && guessC == ansC2)
                    {
                        secondFound = true;
                        x[ansR2-1, ansC2-1] = 'X';
                    }
                    else
                    {
                        if (guess % 2 == 0)
                        {
                            if (guessC == ansC2)
                            {
                                if (guessR > ansR2)
                                    x[guessR - 1, guessC - 1] = '^';
                                else
                                    x[guessR - 1, guessC - 1] = 'V';
                            }
                            else if (guessC > ansC2)
                            {
                                x[guessR - 1, guessC - 1] = '<';
                            }
                            else
                            {
                                x[guessR - 1, guessC - 1] = '>';
                            }
                            guess++;
                        }
                        else
                        {
                            if (guessR == ansR2)
                            {
                                if (guessC > ansC2)
                                    x[guessR - 1, guessC - 1] = '<';
                                else
                                    x[guessR - 1, guessC - 1] = '>';
                            }
                            else if (guessR > ansR2)
                            {
                                x[guessR - 1, guessC - 1] = '^';
                            }
                            else
                            {
                                x[guessR - 1, guessC - 1] = 'V';
                            }
                            guess++;
                        }
                    }
                    break;
            }
            //returns true or false if you won
            if (firstFound && secondFound)
                return true;
            else
                return false;
        }
    }
}
