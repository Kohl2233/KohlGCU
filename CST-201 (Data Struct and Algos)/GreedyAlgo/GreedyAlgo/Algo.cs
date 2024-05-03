using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgo
{
    internal class Algo
    {
        // Variables
        public int numSteps;
        public int numComps;

        public Algo()
        {
            numSteps = 0;
            numComps = 0;
        }

        /// <summary>
        /// Util Function to Return Largest of Two Ints
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int Max(int a, int b)
        {
            numComps++;
            return (a > b) ? a : b;
        }



        /// <summary>
        /// Recursive Method to Find Max Profit
        /// Big O: O(N * W)
        /// </summary>
        /// <param name="numItems"></param>
        /// <param name="weightLimit"></param>
        /// <param name="goods"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        private int KnapSackRecursion(int numItems, int weightLimit, List<TradeGood> goods, int[,] table)
        {
            // Check Base Conditions
            numComps++;
            if (numItems == 0 || weightLimit == 0) { return 0; }
            numComps++;
            if (table[numItems, weightLimit] != -1) { return table[numItems, weightLimit]; }

            numComps++;
            if (goods[numItems - 1].weight > weightLimit)
            {
                // Store Val in Stack and Return Recursive Call
                numSteps++;
                return table[numItems, weightLimit] =
                    KnapSackRecursion(numItems - 1, weightLimit, goods, table); ;
            }
            else
            {
                // Sort and Return that Value
                numSteps++;
                return table[numItems, weightLimit] =
                    Max(goods[numItems - 1].value +
                    KnapSackRecursion(numItems - 1, weightLimit - goods[numItems - 1].weight, goods, table),
                    KnapSackRecursion(numItems - 1, weightLimit, goods, table));
            }
        }



        /// <summary>
        /// Method to Start the KnapSack Algo
        /// Big O: O(n^2), with the initial pop of table
        /// </summary>
        /// <param name="numItems"></param>
        /// <param name="weightLimit"></param>
        /// <param name="goods"></param>
        /// <returns></returns>
        public int KnapSack(int numItems, int weightLimit, List<TradeGood> goods)
        {
            // Delcare Recursion Stack Table, Fill with -1
            int[,] table = new int[numItems + 1, weightLimit + 1];
            for (int i = 0; i < numItems + 1; i++)
            {
                for (int k = 0; k < weightLimit + 1; k++)
                {
                    table[i, k] = -1;
                }
            }

            // Start Recursion
            return KnapSackRecursion(numItems, weightLimit, goods, table);
        }
    }
}
