using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming.UnBoundedKnapsack
{
    /* Introduction
       We are given a ribbon of length ‘n’ and a set of possible ribbon lengths. 
     * Now we need to cut the ribbon into the maximum number of pieces that comply with the above-mentioned possible lengths. 
     * Write a method that will return the count of pieces.

        Example 1:


        n: 5
        Ribbon Lengths: {2,3,5}
        Output: 2
        Explanation: Ribbon pieces will be {2,3}.
        Example 2:


        n: 7
        Ribbon Lengths: {2,3}
        Output: 3
        Explanation: Ribbon pieces will be {2,2,3}.
        Example 3:


        n: 13
        Ribbon Lengths: {3,5,7}
        Output: 3
        Explanation: Ribbon pieces will be {3,3,7}.
        Problem Statment
        Given a number array to represent possible ribbon lengths and a total ribbon length ‘n’, we need to find the maximum number of pieces that the ribbon can be cut into. 
     */
    class MaximumRibbonCut
    {
        public int SolveMaximumRibbonCut(int[] ribbonLengths, int lTotal)
        {
            if (ribbonLengths.Length == 0 || lTotal == 0)
                return 0;
            int n = ribbonLengths.Length;
            int[][] dpCache = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dpCache[i] = new int[lTotal + 1];
            }

            for (int i = 0; i < n; i++)
            {
                for (int t = 0; t <= lTotal; t++)
                {
                    dpCache[i][t] = int.MinValue;
                }
            }
            for (int i = 0; i < n; i++)
            {
                dpCache[i][0] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int t = 1; t <= lTotal; t++)
                {
                   if(i>0)
                   {
                       dpCache[i][t] = dpCache[i - 1][t];
                   }
                    if(ribbonLengths[i] <=t && dpCache[i][t-ribbonLengths[i]]!=int.MinValue)
                    {
                        dpCache[i][t] = Math.Max(dpCache[i][t], dpCache[i][t - ribbonLengths[i]] +1);
                    }
                }
            }
            return dpCache[n - 1][lTotal] == int.MinValue ? -1 : dpCache[n - 1][lTotal];
        }
    }
}
