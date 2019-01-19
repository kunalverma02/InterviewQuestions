using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /*Given a non-empty array of integers, every element appears twice except for one. Find that single one.

    Note: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

    Example 1:
    Input: [2,2,1]
    Output: 1
   
    Example 2:
    Input: [4,1,2,1,2]
    Output: 4 
     */
    class SingleNumberInArray
    {
        public int SingleNumber(int[] nums)
        {
            if (nums.Length <= 2)
            {
                return nums[0];
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            Dictionary<int, int> dups = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    if (!dups.ContainsKey(nums[i]))
                        dups.Add(nums[i], i);
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }


            for (int i = 0; i < nums.Length; i++)
            {
                if (!dups.ContainsKey(nums[i]))
                    return nums[i];
            }

            return 0;
        }


        public int SingleNumber1(int[] nums)
        {
            if (nums.Length <= 2)
            {
                return nums[0];
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            Dictionary<int, int> dups = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict.Remove(nums[i]);
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }

            return dict.Keys.FirstOrDefault();
        }


        public int SingleNumberWithoutMemory(int [] nums)
        {
            if (nums.Length <= 2)
            {
                return nums[0];
            }

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                sum = sum - 1;
            }

            return 0;
        }
    }
}
