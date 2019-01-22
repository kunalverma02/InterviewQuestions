using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming.UnBoundedKnapsack
{
    /*
     Introduction
        Given an infinite supply of ‘n’ coin denominations and a total money amount, we are asked to find the minimum number of coins needed to make up that amount.

        
      * Example 
        Denominations: {1,2,3}
        Total amount: 5
        Output: 2
        Explanation: We need minimum of two coins {2,3} to make a total of '5'
        
      * Example 2:
        Denominations: {1,2,3}
        Total amount: 11
        Output: 4
        Explanation: We need minimum four coins {2,3,3,3} to make a total of '11'
        
      * Problem Statment
        Given a number array to represent different coin denominations and a total amount ‘T’, 
      * we need to find the minimum number of coins needed to make change for ‘T’. 
      * We can assume an infinite supply of coins, therefore, each coin can be chosen multiple times. 
      */
    class MinimumCoinChange
    {
        //it will be minimum of dp[i-1][t] , dp[i][t-coins[i]] +1
        public int SolveMinimumCoinChange(int[] coins, int total)
        {
            if (coins.Length == 0 || total == 0)
                return 0;
            int n = coins.Length;
            int[][] dpCache = new int[n][];
            //initite the array
            for (int i = 0; i < n; i++)
            {
                dpCache[i] = new int[total + 1];
            }
            for (int i = 0; i < n; i++)
            {
                for (int t = 0; t <= total; t++)
                {
                    dpCache[i][t] = int.MaxValue;
                }
            }
            //for 0 total min coin required would be zero.
            for (int i = 0; i < n; i++)
            {
                dpCache[i][0] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                for (int t = 0; t <= total; t++)
                {
                    if(i>0)
                    {
                        dpCache[i][t] = dpCache[i - 1][t];
                    }
                    if (coins[i] <= t && dpCache[i][t - coins[i]] != int.MaxValue)
                    {
                        dpCache[i][t] = Math.Min(dpCache[i][t], dpCache[i][t - coins[i]] + 1);
                    }
                }
            }

            return dpCache[n - 1][total] != int.MaxValue ? dpCache[n - 1][total] : -1;
        }
    }
}
