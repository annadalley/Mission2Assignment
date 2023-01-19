using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2Assignment
{
    public class ThrowDice
    {
        //creates an array to hold the number of times each potential total was rolled
        int[] aThrow = new int[11];
        
        //creates a new method called newRoll that accepts the parameter of numRolls
        public void NewRoll(int rolls)
        {
            //for loop to create 2 random numbers between 1 and less than 7 for each roll
            //adds the 2 random numbers together to get the dice total.
            for (int iCount = 0; iCount < rolls; iCount++)
            {
                Random rnd1 = new Random();
                Random rnd2 = new Random();
                int die1 = rnd1.Next(1, 7);
                int die2 = rnd2.Next(1, 7);
                int total = (die1 + die2);

                //this takes the total minus 2 to get the position of the total in the array, and adds 1 to the current value in that position.
                //example: total = 2.  array[0] = Array[0]+1.
                aThrow[total-2] = aThrow[total-2] + 1;
                
            }
            //for loop to start at 2, and create the display starting from 2: to 12:
            for (int iCount2 = 2; iCount2 < 13; iCount2++)
            {
                Console.Write(iCount2 + ": ");
                //calculates number of stars by taking the value in the array and dividing it by 1% times the number of rolls
                double dStars = (aThrow[iCount2 - 2])/(.01 * rolls);
                //converts number of stars from a decimal to an integer
                int iStars = Convert.ToInt32(dStars);
                //writes a star equal to the number of stars calculated above for each total.
                for (int iCount3 = 0; iCount3 < iStars; iCount3++)
                {
                    Console.Write("*");
                }
                //adds a line after all the stars for each number are added.
                Console.Write("\n");
            }
        }
    }
}


