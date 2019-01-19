using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    /*Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Example:

        Input: [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Note:

        You must do this in-place without making a copy of the array.
        Minimize the total number of operations.
     */
    public class MoveZero
    {
        public int[] MoveZeroes(int[] nums)
        {
            int loopCount = nums.Length;
            for (int i = 0; i < loopCount; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {

                        nums[j - 1] = nums[j];

                    }
                    nums[nums.Length - 1] = 0;
                    loopCount--;
                    i--;
                }
            }
            return nums;
        }

        public void MoveZeroes1(int[] nums)
        {
            int lastNonZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZeroIndex] = nums[i];
                    lastNonZeroIndex++;
                }
            }

            for (int i = lastNonZeroIndex; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

        }
    }
}
