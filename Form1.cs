/*
 * This program was written by Jason Borum
 * Date: April 1, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
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

namespace Exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRollDice_Click(object sender, EventArgs e)
        {
            //Create new dice objects
            Dice redDie = new Dice(12);
            Dice blueDie = new Dice(6);
            bool snakeEyes = false;

            //get random dice rolls
            int redDigit = 0;
            int blueDigit = 0;

            //Set number of sides for red die
            redDie.NumberOfSides = 12;

            //While loop to test for snake eyes
            while (!snakeEyes)
            {
                //Clear text boxes
                txtDie1.Text = "";
                txtDie2.Text = "";

                //Get random dice rolls
                redDigit = redDie.rollDie();
                blueDigit = blueDie.rollDie();

                //Add dice rolls to the textbox
                txtDie1.Text = Convert.ToString(redDigit);
                txtDie2.Text = Convert.ToString(blueDigit);

                if ((redDigit == blueDigit) && (redDigit == 1))
                {
                    snakeEyes = true;
                    //Send message when snake eyes hits
                    MessageBox.Show(string.Format("You got snake eyes in {0} tries.", redDie.NumberOfRolls));
                }
                
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
