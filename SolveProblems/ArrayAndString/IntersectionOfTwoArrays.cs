using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /* Given two arrays, write a function to compute their intersection.

        Example 1:
        Input: nums1 = [1,2,2,1], nums2 = [2,2]
        Output: [2,2]
        
     *  Example 2:
        Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        Output: [4,9]
        
        Note:
        Each element in the result should appear as many times as it shows in both arrays.
        The result can be in any order.
        
     * Follow up:
        What if the given array is already sorted? How would you optimize your algorithm?
        What if nums1's size is small compared to nums2's size? Which algorithm is better?
        What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?
     */
    class IntersectionOfTwoArrays
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {

            int smallLength;
            int bigLength;
            int[] smallArray;
            int[] bigArray;
            List<int> result = new List<int>();

            if (nums1.Length > nums2.Length)
            {
                smallLength = nums2.Length;
                bigLength = nums1.Length;
                smallArray = nums2;
                bigArray = nums1;
            }
            else
            {
                smallLength = nums1.Length;
                bigLength = nums2.Length;
                smallArray = nums1;
                bigArray = nums2;
            }


            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < bigLength; i++)
            {
                if (!dict.ContainsKey(bigArray[i]))
                {
                    dict.Add(bigArray[i], 1);
                }
                else
                {
                    dict[bigArray[i]] = dict[bigArray[i]] + 1;
                }
            }

            for (int i = 0; i < smallLength; i++)
            {
                if (dict.ContainsKey(smallArray[i]) && dict[smallArray[i]] > 0)
                {
                    result.Add(smallArray[i]);
                    dict[smallArray[i]] = dict[smallArray[i]] - 1;
                }
            }

            return result.ToArray();
        }
    }
}
