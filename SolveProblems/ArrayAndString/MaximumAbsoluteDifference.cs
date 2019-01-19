using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    class MaximumAbsoluteDifference
    {
        public int FindMaximumAbsoluteDifference(List<int> A)
        {

            int maxSum = 0;
            int n = A.Count;
            int i = 0;
            int j = 0;
            int tempSum = 0;
            for (int index = 0; index < n; index++)
            {
                for (int jIndex = index; jIndex < n; jIndex++)
                {
                    i = index + 1;
                    j = jIndex + 1; ;

                    tempSum = Math.Abs(A[i - 1] - A[j - 1]) + Math.Abs(i - j);

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
               
            }
            return maxSum;
        }

        public int FindMaximumAbsoluteDifference1(List<int> A)
        {

            int maxSum = 0;
            int n = A.Count;
            int i = 0;
            int j = 0;
            int tempSum = 0;
            for (int index = 0; index < n; index++)
            {

                    i = index + 1;
                    j = n - index;

                    tempSum = Math.Abs(A[i - 1] - A[j - 1]) + Math.Abs(i - j);

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }

            }
            return maxSum;
        }
    }
}
