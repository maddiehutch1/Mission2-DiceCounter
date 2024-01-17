using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2_DiceCounter
{
    internal class Rolls
    {
        
        public int[,] RollTracker(int rollCount)
        {
            int[,] trackerRolls = { {2, 0}, {3, 0}, {4, 0},
                                    {5, 0}, {6, 0}, {7, 0},
                                    {8, 0}, {9, 0}, {10, 0},
                                    {11, 0}, {12, 0}};
                
            for (int roll = 0; roll < rollCount; roll++)
            {
                Random dice = new Random();

                int d1 = dice.Next(1, 7);
                int d2 = dice.Next(1, 7);

                int totalValue = d1 + d2;

                for (int item = 0; item < trackerRolls.GetLength(0); item++)
                {
                    if (trackerRolls[item, 0] == totalValue)
                    {
                        trackerRolls[item, 1] += 1;
                    }
                }
            }

            return trackerRolls;

        }
       
    }
}
