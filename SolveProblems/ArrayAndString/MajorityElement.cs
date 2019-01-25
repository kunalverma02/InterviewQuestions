using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /* Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

        You may assume that the array is non-empty and the majority element always exist in the array.

        Example 1:
        Input: [3,2,3]
        Output: 3
        
        Example 2:
        Input: [2,2,1,1,1,2,2]
        Output: 2 
         */
    class MajorityElement
    {
        public int MajorityElement1(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] += 1;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            
            var key = dict.Where(item => item.Value >= nums.Length / 2).SingleOrDefault(); ;
            return key.Key;
        }
    }
}
