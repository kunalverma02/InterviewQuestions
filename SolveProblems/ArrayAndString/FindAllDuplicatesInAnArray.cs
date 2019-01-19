using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /*
     Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
     Find all the elements that appear twice in this array.
     Could you do it without extra space and in O(n) runtime?

        Example:
        Input:
        [4,3,2,7,8,2,3,1]

        Output:
        [2,3]
     
     */
    class FindAllDuplicatesInAnArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            Dictionary<int, int> uniqueElement = new Dictionary<int, int>();
            List<int> dups = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(uniqueElement.ContainsKey(nums[i]))
                {
                    dups.Add(nums[i]);
                }
                else
                {
                    uniqueElement.Add(nums[i], i);
                }
            }

            return dups;
        }

        /* Example:
        Input:
        [1, 5, 4,3,3,4,7]

             i = 0, 1,  2, 3  4
         index = 0, 4,  3, 2  2
                -1, -3,-3,-4, -4 
        Output: 
        [3, 4] */
        public IList<int> FindDuplicatesWithoutExtraMemory(int[] nums)
        {
            List<int> dups = new List<int>();
           
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;

                if(nums[index] < 0)
                {
                    dups.Add(index + 1);
                }
                else
                {
                    nums[index] = -nums[index];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Math.Abs(nums[i]);
            }

            return dups;
        }
    }
}
