using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming
{
    /* Given a set of positive numbers, find the total number of subsets whose sum is equal to a given number ‘S’.

    Example 1:

    Input: {1, 1, 2, 3}, S=4
    Output: 3
    The given set has '3' subsets whose sum is '4': {1, 1, 2}, {1, 3}, {1, 3}
    Note that we have two similar sets {1, 3}, because we have two '1' in our input.
    Example 2:

    Input: {1, 2, 7, 1, 5}, S=9
    Output: 3
    The given set has '3' subsets whose sum is '4': {2, 7}, {1, 7, 1}, {1, 2, 1, 5} 
     * 
     */
    class CountOfSubsetSum
    {
        public int GetCountofSubsetSum(int [] nums, int sum)
        {
            if (nums.Length == 0)
                return 0;

            int n = nums.Length;
            int[][] dpCache = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dpCache[i] = new int[sum + 1];
            }
            for (int i = 0; i < n; i++)
            {
                dpCache[i][0] = 1;
            }
            for (int s = 1; s <= sum; s++)
            {
                dpCache[0][s] = nums[0] == s ? 1 : 0;
            }

            for (int i = 1; i < n; i++)
            {
                for (int s = 1; s <= sum; s++)
                {
                    dpCache[i][s] = dpCache[i - 1][s];
                    if(nums[i] <= s)
                    {
                        dpCache[i][s] = dpCache[i][s] + dpCache[i - 1][s - nums[i]]; 
                    }
                }
            }

            return dpCache[n - 1][sum];
        }
    }
}
