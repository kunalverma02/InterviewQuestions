using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.Sorting
{
    class MergeSort
    {

        public int[] MergeSortedArray(int [] arr1, int [] arr2)
        {
            int length1 = arr1.Length;
            int length2 = arr2.Length;

            int mergedArrayLength = length1 + length2;
            int[] mergedArray = new int[mergedArrayLength];

            int i=0;
            int j=0;
            for(int k =0; k< mergedArrayLength; k++)
            {
                if (i < length1 && j <  length2)
                {
                    if (arr1[i] < arr2[j])
                    {

                        mergedArray[k] = arr1[i];
                        i++;
                    }
                    else
                    {
                        mergedArray[k] = arr2[j];
                        j++;
                    }
                }
                else if(i == length1)
                {
                    mergedArray[k] = arr2[j];
                    j++;
                }
                else if (j == length2)
                {
                    mergedArray[k] = arr1[i];
                    i++;
                }
            }

            return mergedArray;

        }
    }
}
