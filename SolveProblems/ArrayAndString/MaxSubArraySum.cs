using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.ArrayAndString
{
    class MaxSubArraySum
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSumSoFar = int.MinValue;
            int tempSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                tempSum = tempSum + nums[i];

                if (maxSumSoFar < tempSum)
                {
                    maxSumSoFar = tempSum;
                }

                if (tempSum < 0)
                {
                    tempSum = 0;
                }
            }

            return maxSumSoFar;
          
        }

        public List<int> Maxset(List<int> A)
        {
            long maxSum = 0;
            long tempSum = 0;
            // Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
            //int j=0;
            List<int> tempList = new List<int>();
            List<int> listResult = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] >= 0)
                {
                    tempSum = tempSum + A[i];
                    tempList.Add(A[i]);

                    if (maxSum < tempSum)
                    {
                        maxSum = tempSum;
                        listResult = tempList;
                    }
                    

                }
                else
                {
                    if (maxSum == tempSum)
                    {
                        if (tempList.Count > listResult.Count)
                        {
                            listResult = tempList;
                            
                        }
                    }
                    tempList = new List<int>();
                    tempSum = 0;

                }

            }

            return listResult;
        }
    }
}
