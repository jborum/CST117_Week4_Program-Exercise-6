/*
 * This program was written by Jason Borum
 * Date: April 1, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Dice
    {
        //Declare class properties
        private int numberOfSides;
        private int numberOfRolls;

        //Initilize random number object
        Random randomNumber = new Random();

        //Assessor for number of side
        public int NumberOfSides
        {
            get
            {
                return numberOfSides;
            }
            set
            {
                numberOfSides = value;
            }
        }

        //Accessor for number of rolls
        public int NumberOfRolls
        {
            get
            {
                return numberOfRolls;
            }
        }

        //rollDie() method
        public int rollDie()
        {
            //Use random number to generate die face value.
            //Random number must be selected between 1 and the number of sides +1
            numberOfRolls++;
            return this.randomNumber.Next(1, this.numberOfSides + 1);
        }

        //Constructor that takes an integer arument to determine the number of sides of the die.
        public Dice(int numberOfSides)
        {
            //Prevent the user from entering sides that are less than 4 or greater than 20
            if (numberOfSides > 20)
            {
                this.numberOfSides = 20;
            }
            else if (numberOfSides < 4)
            {
                this.numberOfSides = 4;
            } else
            this.numberOfSides = numberOfSides;
        } // end of Dice Constructor

        //Constructor without arguments
        public Dice()
        {
            this.numberOfSides = 6;
        }

    } // end of Dice Class
} // end of project namespace
