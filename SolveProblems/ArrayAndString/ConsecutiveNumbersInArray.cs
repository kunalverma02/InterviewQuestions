using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    class ConsecutiveNumbersInArray
    {
        /* 
         Given an unsorted array of integers, find the length of the longest consecutive elements sequence.

            Your algorithm should run in O(n) complexity.

            Example:
            Input: [100, 4, 200, 1, 3, 2]
            Output: 4
            Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
         
         */
        public int ConsecutiveNumbers(int [] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            Array.Sort(nums);

            int currentStrike = 1;
            int longestStrike = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    if (nums[i] == nums[i - 1] + 1)
                    {
                        currentStrike++;
                    }
                    else
                    {
                        longestStrike = Math.Max(currentStrike, longestStrike);
                        currentStrike = 1;
                    }
                }
            }

            return Math.Max(currentStrike, longestStrike); ;
        }

        public int ConsecutiveNumbers1(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                hash.Add(nums[i]);
            }

            int longestStrike = 1;

            foreach (int num in nums)
            {
                if (!hash.Contains(num - 1))
                {
                    int currentStrike = 1;
                    int currentItem = num;

                    while (hash.Contains(currentItem + 1))
                    {
                        currentItem++;
                        currentStrike++;
                    }

                    longestStrike = Math.Max(currentStrike, longestStrike);
                }
            }

            return longestStrike;
        }
    }
}
