using System;
//Anna Dalley
//Section 1
//Group 4
namespace Mission2Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create new object and variables
            ThrowDice td = new ThrowDice();
            int numThrows = 0;

            //string to welcome to program and prompt user how many dice rolls they want
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            
            //takes input from user, changes from string to an integer, and assigns it to the variable initialized above.
            numThrows = int.Parse(Console.ReadLine());

            //Begins printing results
            Console.Write("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + numThrows + ".\n\n");

            //calls method in the ThrowDice class passing in numRolls and returns results
            td.NewRoll(numThrows);

            //Thanks user for playing
            Console.WriteLine("\nThank you for using the dice throwing simulator! Goodbye.");
        }
    }
}
