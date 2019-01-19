using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ByteByByte50Questions
{
    class ByteByByteQuestions
    {
        /*Find the median of two sorted arrays.
        
         Example:
         arr1 = [1, 3, 5]
         arr2 = [2, 4, 6]
         median(arr1, arr2) = 3.5
         */
        public double MedianOfTwoSortedArrays(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;

            int sortedArrayLength = length1 + length2;

            int[] sortedArray = new int[sortedArrayLength];

            int i = 0;
            int j = 0;
            for (int k = 0; k < sortedArrayLength; k++)
            {
                if (i < length1 && j < length2)
                {
                    if (nums1[i] < nums2[j])
                    {
                        sortedArray[k] = nums1[i];
                        i++;  
                    }
                    else
                    {
                        sortedArray[k] = nums2[j];
                        j++;
                    }
                }
                else if (i == length1)
                {
                    if (length2 != 0)
                    {
                        sortedArray[k] = nums2[j];
                        j++;
                    }
                }
                else
                {
                    if (length1 != 0)
                    {
                        sortedArray[k] = nums1[i];
                        i++;
                    }
                }
            }



            double median;
            if (sortedArrayLength % 2 == 0)
            {
                median = (Convert.ToDouble(sortedArray[sortedArrayLength / 2 - 1] + sortedArray[sortedArrayLength / 2])) / 2.0;
            }
            else
            {
                median = Convert.ToDouble(sortedArray[sortedArrayLength / 2]);
            }

            return median;
        }
        public double FindMedianSortedArrays(int[] A, int[] B)
        {
            int m = A.Length;
            int n = B.Length;
            if (m > n)
            { // to ensure m<=n
                int[] temp = A; A = B; B = temp;
                int tmp = m; m = n; n = tmp;
            }
            int iMin = 0, iMax = m, halfLen = (m + n + 1) / 2;
            while (iMin <= iMax)
            {
                int i = (iMin + iMax) / 2;
                int j = halfLen - i;
                if (i < iMax && B[j - 1] > A[i])
                {
                    iMin = i + 1; // i is too small
                }
                else if (i > iMin && A[i - 1] > B[j])
                {
                    iMax = i - 1; // i is too big
                }
                else
                { // i is perfect
                    int maxLeft = 0;
                    if (i == 0) 
                    { 
                        maxLeft = B[j - 1]; 
                    }
                    else if (j == 0) 
                    {
                        maxLeft = A[i - 1]; 
                    }
                    else 
                    { 
                        maxLeft = Math.Max(A[i - 1], B[j - 1]); 
                    }
                    if ((m + n) % 2 == 1) 
                    { 
                        return maxLeft; 
                    }

                    int minRight = 0;
                    if (i == m) 
                    {
                        minRight = B[j];
                    }
                    else if (j == n) 
                    {
                        minRight = A[i]; 
                    }
                    else { 
                        minRight = Math.Min(B[j], A[i]);
                    }

                    return (maxLeft + minRight) / 2.0;
                }
            }
            return 0.0;
        }
    }
}
