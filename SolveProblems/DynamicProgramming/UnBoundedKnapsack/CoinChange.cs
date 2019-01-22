using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming.UnBoundedKnapsack
{
    /* Introduction
    Given an infinite supply of ‘n’ coin denominations and a total money amount, we are asked to find the total number of distinct ways to make up that amount.

    Example:
    Denominations: {1,2,3}
    Total amount: 5
    Output: 5
    Explanation: There are five ways to make the change for '5', here are those ways:
      1. {1,1,1,1,1} 
      2. {1,1,1,2} 
      3. {1,2,2}
      4. {1,1,3}
      5. {2,3}
    Problem Statment
    Given a number array to represent different coin denominations and a total amount ‘T’, 
     * we need to find all the different ways to make change for ‘T’ with the given coin denominations. We can assume an infinite supply of coins, 
     * therefore, each coin can be chosen multiple times.*/
    class CoinChange
    {
        public int SolveCoinChange(int[] denominations, int amount)
        {
            if (denominations.Length == 0)
                return 0;
            int n = denominations.Length;
            int[][] dpCache = new int[n][];

            for (int i = 0; i < n; i++)
            {
                dpCache[i] = new int[amount + 1];
            }

            //Set value when amount is Zero.
            for (int i = 0; i < n; i++)
            {
                dpCache[i][0] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int a = 0; a <= amount; a++)
                {
                    if(denominations[i] <= a)
                    {
                        dpCache[i][a] = dpCache[i][a - denominations[i]];
                    }
                    if(i>0)
                    {
                        dpCache[i][a] = dpCache[i][a] + dpCache[i - 1][a];
                    }
                }
            }

            return dpCache[n - 1][amount];
        }
    }
}
