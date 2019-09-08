/*
 * CustomPage: the form where the user can make their own pizza
 * or choose from a selection of specialty pizzas returning the value
 * back to StartPage once finished
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_6
{
    public partial class CustomPage : Form
    {
        //keeps track of our current totals
        double total, toppingPrice = 0, orderTotal;
        int sizePrice = 5;

        //checks if item is currently on or off
        bool provolone, chedder, mozzarella, pepperoni, bacon, ham, sausage,
            beef, jalapeno, mushroom, onion, olive, spinach;

        //takes in the current grandtotal to add to it and return it
        public CustomPage(double grandTotal)
        {
            InitializeComponent();
            orderTotal = grandTotal;
        }

        //changes images of what side is chosen on click
        private void LeftHalf_Click(object sender, EventArgs e)
        {
            LeftSide.BackgroundImage = Image.FromFile(filename:
                            Directory.GetCurrentDirectory() +
                              "\\Resources\\LeftSideChosen.jpg");
            RightSide.BackgroundImage = Image.FromFile(filename:
                            Directory.GetCurrentDirectory() +
                              "\\Resources\\RightSideIcon.jpg");
            Whole.BackgroundImage = Image.FromFile(filename:
                            Directory.GetCurrentDirectory() +
                              "\\Resources\\WholePizzaIcon.jpg");
        }

        private void Whole_Click(object sender, EventArgs e)
        {
            LeftSide.BackgroundImage = Image.FromFile(filename:
                            Directory.GetCurrentDirectory() +
                              "\\Resources\\LeftSideIcon.jpg");
            RightSide.BackgroundImage = Image.FromFile(filename:
                            Directory.GetCurrentDirectory() +
                              "\\Resources\\RightSideIcon.jpg");
            Whole.BackgroundImage = Image.FromFile(filename:
                            Directory.GetCurrentDirectory() +
                              "\\Resources\\WholePizzaChosen.jpg");
        }

        private void RightSide_Click(object sender, EventArgs e)
        {
            LeftSide.BackgroundImage = Image.FromFile(filename:
                            Directory.GetCurrentDirectory() +
                              "\\Resources\\LeftSideIcon.jpg");
            RightSide.BackgroundImage = Image.FromFile(filename:
                            Directory.GetCurrentDirectory() +
                              "\\Resources\\RightSideChosen.jpg");
            Whole.BackgroundImage = Image.FromFile(filename:
                            Directory.GetCurrentDirectory() +
                              "\\Resources\\WholePizzaIcon.jpg");
        }

        //when a specialty is chosen enables all needed checkboxes
        //and disables the check box groups 
        private void SpecialtyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            switch(SpecialtyBox.Text)
            {
                case ("Meat Lover"):
                    PepperoniBox.Checked = true;
                    BaconBox.Checked = true;
                    HamBox.Checked = true;
                    SausageBox.Checked = true;
                    BeefBox.Checked = true;
                    MozzarellaBox.Checked = true;
                    MeatsBox.Enabled = false;
                    VeggiBox.Enabled = false;
                    CheeseBox.Enabled = false;
                    break;

                case ("Veggie Lover"):
                    JalapenoBox.Checked = true;
                    MushroomBox.Checked = true;
                    OnionBox.Checked = true;
                    OliveBox.Checked = true;
                    SpinachBox.Checked = true;
                    ProvoloneBox.Checked = true;
                    MeatsBox.Enabled = false;
                    VeggiBox.Enabled = false;
                    CheeseBox.Enabled = false;
                    break;

                case ("Cheese Lover"):
                    ProvoloneBox.Checked = true;
                    ChedderBox.Checked = true;
                    MozzarellaBox.Checked = true;
                    MeatsBox.Enabled = false;
                    VeggiBox.Enabled = false;
                    CheeseBox.Enabled = false;
                    break;

                case ("Caterina's Italian"):
                    SausageBox.Checked = true;
                    MushroomBox.Checked = true;
                    PepperoniBox.Checked = true;
                    SpinachBox.Checked = true;
                    ChedderBox.Checked = true;
                    MozzarellaBox.Checked = true;
                    OliveBox.Checked = true;
                    MeatsBox.Enabled = false;
                    VeggiBox.Enabled = false;
                    CheeseBox.Enabled = false;
                    break;

                case ("Custom"):
                    MeatsBox.Enabled = true;
                    VeggiBox.Enabled = true;
                    CheeseBox.Enabled = true;
                    break;
            }
        }

        //sets the pizza back to custom intern clearing everything
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SpecialtyBox.SelectedIndex = 0;
        }

        //all checkboxes when clicked run ToppingChange and send in if being
        //enabled or disabled
        private void MozzarellaCheck(object sender, EventArgs e)
        {
            mozzarella = !mozzarella;
            ToppingChange(mozzarella, 1);
        }

        private void ChedderCheck(object sender, EventArgs e)
        {
            chedder = !chedder;
            ToppingChange(chedder, 1);
        }

        private void ProvoloneCheck(object sender, EventArgs e)
        {
            provolone = !provolone;
            ToppingChange(provolone, 1);
        }

        private void SpinachCheck(object sender, EventArgs e)
        {
            spinach = !spinach;
            ToppingChange(spinach,.9);
        }

        private void OliveCheck(object sender, EventArgs e)
        {
            olive = !olive;
            ToppingChange(olive, 1);
        }

        private void OnionCheck(object sender, EventArgs e)
        {
            onion = !onion;
            ToppingChange(onion, .5);
        }

        private void MushroomCheck(object sender, EventArgs e)
        {
            mushroom = !mushroom;
            ToppingChange(mushroom, .6);
        }

        private void JalapenoCheck(object sender, EventArgs e)
        {
            jalapeno = !jalapeno;
            ToppingChange(jalapeno, .9);
        }

        private void BeefCheck(object sender, EventArgs e)
        {
            beef = !beef;
            ToppingChange(beef, .75);
        }

        private void SausageCheck(object sender, EventArgs e)
        {
            sausage = !sausage;
            ToppingChange(sausage, .75);
        }

        private void HamCheck(object sender, EventArgs e)
        {
            ham = !ham;
            ToppingChange(ham, .5);
            
        }

        private void BaconChecked(object sender, EventArgs e)
        {
            bacon = !bacon;
            ToppingChange(bacon, .8);
        }

        private void PepperoniCheck(object sender, EventArgs e)
        {
            pepperoni = !pepperoni;
            ToppingChange(pepperoni, .5);
        }
        
        //takes away from our total topping price if disabling and 
        //adding if enabled
        private void ToppingChange(bool changed, double price)
        {
            total = sizePrice;
            if (changed)
                toppingPrice += price;
            else
                toppingPrice -= price;
            total += toppingPrice;
            TotalLabel.Text = "Total: $" + total;
        }

        //sends back to start page with pizzas price
        private void FinishButton_Click(object sender, EventArgs e)
        {
            total = toppingPrice + sizePrice;
            orderTotal += total;
            StartPage done = new StartPage(orderTotal);
            done.Show();
            this.Close();
        }

        //size radio buttons all run on this method changing the price
        //of our size
        private void SizeChanged(object sender, EventArgs e)
        {
            if (PersRadButton.Checked)
                sizePrice = 5;
            if (SmallRadButton.Checked)
                sizePrice = 7;
            if (MediumRadButton.Checked)
                sizePrice = 11;
            if (LargeRadButton.Checked)
                sizePrice = 13;

            total = sizePrice + toppingPrice;
            TotalLabel.Text = "Total: $" + total;
        }

        //sets all check boxes to disabled
        private void Clear()
        {
            PepperoniBox.Checked = false;
            BaconBox.Checked = false;
            HamBox.Checked = false;
            SausageBox.Checked = false;
            BeefBox.Checked = false;
            JalapenoBox.Checked = false;
            MushroomBox.Checked = false;
            OnionBox.Checked = false;
            OliveBox.Checked = false;
            SpinachBox.Checked = false;
            ProvoloneBox.Checked = false;
            ChedderBox.Checked = false;
            MozzarellaBox.Checked = false;
        }
    }
}
