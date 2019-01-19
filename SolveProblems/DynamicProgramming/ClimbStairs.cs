using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.Recursion
{
    /*You are climbing a stair case. It takes n steps to reach to the top.

    Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
    Note: Given n will be a positive integer.

    Example 1:
    Input: 2
    Output: 2
    Explanation: There are two ways to climb to the top.
    1. 1 step + 1 step
    2. 2 steps
    
    Example 2:
    Input: 3
    Output: 3
    Explanation: There are three ways to climb to the top.
    1. 1 step + 1 step + 1 step
    2. 1 step + 2 steps
    3. 2 steps + 1 step */
    class ClimbStairs
    {
        public int GetStairsCount(int n)
        {
            if (n <= 3)
                return n;

            int[] cache = new int[n + 1];

            cache[1] = 1;
            cache[2] = 2;
            cache[3] = 3;
            return GetCount(cache, n);

        }

        private int GetCount(int[] cache, int n)
        {
            if (n <= 3)
                return n;

            int prevSteps = 0;
            int prev2Steps = 0;
            if (cache[n - 1] != 0)
            {
                prevSteps = cache[n - 1];
            }
            else
            {
                cache[n - 1] = GetCount(cache, n - 1);
                prevSteps = cache[n - 1];
            }

            if (cache[n - 2] != 0)
            {
                prev2Steps = cache[n - 2];
            }
            else
            {
                cache[n - 2] = GetCount(cache, n - 2);
                prev2Steps = cache[n - 2];
            }

            return prevSteps + prev2Steps;
        }

        public int GetStairsCountRecursive(int n)
        {
            if (n <= 3)
                return n;
            int prevSteps = 2;
            int prevSteps2 = 1;
            int steps = 0;
            int count = 3;
            while (count <= n)
            {
                steps = prevSteps + prevSteps2;
                prevSteps2 = prevSteps;
                prevSteps = steps;

                count++;
            }
            return steps;
        }
    }
}
