using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2_DiceCounter
{
    internal class Rolls
    {
        // method returns an array of arrays and uses rollCount input as a parameter
        public int[,] RollTracker(int rollCount)
        {
            // initialize array of arrays
            int[,] trackerRolls = { {2, 0}, {3, 0}, {4, 0},
                                    {5, 0}, {6, 0}, {7, 0},
                                    {8, 0}, {9, 0}, {10, 0},
                                    {11, 0}, {12, 0}};
                
            // use for loop to simulate two dice being rolled, added up to find total
            for (int roll = 0; roll < rollCount; roll++)
            {
                Random dice = new Random();

                int d1 = dice.Next(1, 7);
                int d2 = dice.Next(1, 7);

                int totalValue = d1 + d2;

                // for loop is a counter for the num of times the total shows up
                for (int item = 0; item < trackerRolls.GetLength(0); item++)
                {
                    if (trackerRolls[item, 0] == totalValue)
                    {
                        trackerRolls[item, 1] += 1;
                    }
                }
            }

            // return the updated array of arrays
            return trackerRolls;

        }
       
    }
}
