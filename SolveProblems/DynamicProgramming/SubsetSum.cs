using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.DynamicProgramming
{
    /* 
     Problem Statement
        Given a set of positive numbers, determine if there exists a subset whose sum is equal to a given number ‘S’.

        Example 1:

        Input: {1, 2, 3, 7}, S=6
        Output: True
        The given set has a subset whose sum is '6': {1, 2, 3}
        Example 2:

        Input: {1, 2, 7, 1, 5}, S=10
        Output: True
        The given set has a subset whose sum is '10': {1, 2, 7}
        Example 3:

        Input: {1, 3, 4, 8}, S=6
        Output: False
        The given set does not have any subset whose sum is equal to '6'.
     */
    class SubsetSum
    {
        public bool SolveSubsetSum(int[] nums, int sum)
        {
            if (nums.Length == 0)
                return false;
            int n = nums.Length;
            bool[][] dpCache = new bool[n][];

            for (int i = 0; i < n; i++)
            {
                dpCache[i] = new bool[sum + 1];
            }

            for (int i = 0; i < n; i++)
            {
                dpCache[i][0] = true;
            }

            for (int i = 0; i < sum +1; i++)
            {
                //With only one number, we can form a subset only when the required sum is equal to its value
                dpCache[0][i] = nums[i] == i ? true : false;
            }

            for (int i = 1; i < n; i++)
            {
                for (int s = 1; s < sum +1; s++)
                {
                    // if we can get the sum 's' without the number at index 'i' 
                    if(dpCache[i-1][s])
                    {
                        dpCache[i][s] = true;
                    }
                    else if(nums[i]<= s)
                    {
                        dpCache[i][s] = dpCache[i - 1][s - nums[i]];
                    }
                }
            }

            return dpCache[n - 1][sum];
        }
    }
}
