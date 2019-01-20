using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming.UnBoundedKnapsack
{
    /* 
     Given a rod of length ‘n’, we are asked to cut the rod and sell the pieces in a way that will maximize the profit. 
     * We are also given the price of every piece of length ‘i’ where ‘1 <= i <= n’.

        Example:

        Lengths: [1, 2, 3, 4, 5]
        Prices: [2, 6, 7, 10, 13]
        Rod Length: 5

        Let’s try different combinations of cutting the rod:

        Five pieces of length 1 => 10 price
        Two pieces of length 2 and one piece of length 1 => 14 price
        One piece of length 3 and two pieces of length 1 => 11 price
        One piece of length 3 and one piece of length 2 => 13 price
        One piece of length 4 and one piece of length 1 => 12 price
        One piece of length 5 => 13 price

        This shows that we get the maximum price (14) by cutting the rod into two pieces of length ‘2’ and one piece of length ‘1’.
     */
    class RodCutting
    {
        public int SolveRodCutting(int[] lengths, int [] prices, int rodLength)
        {
            if (lengths.Length == 0 || lengths.Length != prices.Length || rodLength <= 0)
                return 0;

            int n = prices.Length;
            int[][] dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[rodLength + 1];
            }
            for (int i = 0; i < n; i++)
            {
                dp[i][0] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int l = 1; l <= rodLength; l++)
                {
                    int profit1 =0, profit2=0;
                    if(lengths[i] <= l)
                    {
                        profit1 = prices[i] + dp[i][l - lengths[i]];
                    }
                    if(i>0)
                    {
                        profit2 = dp[i - 1][l];
                    }

                    dp[i][l] = Math.Max(profit1, profit2);
                }
            }
            return dp[n - 1][rodLength];
        }
    }
}
