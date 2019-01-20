using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming
{
    /*
     * Given a set of positive numbers, partition the set into two subsets with a minimum difference between their subset sums.

    *Example 1:

        Input: {1, 2, 3, 9}
        Output: 3
        Explanation: We can partition the given set into two subsets where minimum absolute difference 
        between the sum of numbers is '3'. Following are the two subsets: {1, 2, 3} & {9}.
    
     * Example 2:

        Input: {1, 2, 7, 1, 5}
        Output: 0
        Explanation: We can partition the given set into two subsets where minimum absolute difference 
        between the sum of number is '0'. Following are the two subsets: {1, 2, 5} & {7, 1}.
     
     
     
     * Example 3:

        Input: {1, 3, 100, 4}
        Output: 92
        Explanation: We can partition the given set into two subsets where minimum absolute difference 
        between the sum of numbers i
        Input: {1, 3, 100, 4}
        Output: 92
        Explanation: We can partition the given set into two subsets where minimum absolute difference 
        between the sum of numbers is '92'. Here are the two subsets: {1, 3, 4} & {100}.
     
     
     
     */

    //Logic should be if divide the sum of the array in half. The two number should be near to half to get the min difference.
    //We can get the s1 using Subset sum logic. s1 will be biggest number closest to half sum of the array. we can other sum subset s2 by substracting s1 from sum of the array
    // Difference between s1 and s2 will be the minm difference.
    class MinimumSubsetSumDifference
    {
        public int GetMinmSubsetSumDiff(int [] nums)
        {
            if (nums.Length == 0)
                return 0;

            int sum = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                sum = sum + nums[i];
            }

            int halfSum = sum / 2;

            bool[][] dpCache = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                dpCache[i] = new bool[halfSum + 1];
            }

            for (int i = 0; i < n; i++)
            {
                dpCache[i][0] = true;
            }

            for (int s = 1; s <= halfSum; s++)
            {
                //if the number is equal to sum. set true
                dpCache[0][s] = nums[0] == s ? true : false;
            }

            for (int i = 1; i < n; i++)
            {
                for (int s = 1; s <= halfSum; s++)
                {
                    //copy the true of previous one
                    if (dpCache[i - 1][s] == true)
                        dpCache[i][s] = true;
                    else if(nums[i] <= s)
                    {
                        dpCache[i][s] = dpCache[i - 1][s - nums[i]];
                    }
                }
            }

            int s1 = 0;
            for (int s = halfSum; s >= 0; s--)
            {
                if(dpCache[n-1][s])
                {
                    s1 = s;
                    break;
                }
            }
            int s2 = sum - s1;

            int minDiff = Math.Abs(s1 - s2);

            return minDiff;
        }
    }
}
